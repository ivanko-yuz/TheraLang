import {Component, EventEmitter, Input, OnInit, Output} from '@angular/core';
import {ResourceCategory} from "../../../../../shared/models/resource/resource-category";
import {Router} from "@angular/router";
import {Resource} from "../../../../../shared/models/resource/resource";
import {ResourceService} from "../../../../../core/http/resource/resource.service";
import {FormBuilder, FormGroup, Validators} from "@angular/forms";
import {forbiddenExtensionValidator} from "../../../../../shared/directives/files/forbidden-extension.directive";
import {ForbiddenExts} from "../../../../../configs/resource.constants";
import {atLeastOne} from "../../../../../shared/directives/files/atleastone-form.directive.";
import {FileInput} from "ngx-material-file-input";
import {Observable, throwError} from "rxjs";
import {catchError} from "rxjs/operators";
import {NotificationService} from "../../../../../core/services/notification/notification.service";
import {TranslateService} from "@ngx-translate/core";

@Component({
  selector: 'app-resource-form',
  templateUrl: './resource-form.component.html',
  styleUrls: ['./resource-form.component.less']
})
export class ResourceFormComponent implements OnInit {

  @Input() initValue: Resource;
  @Input() formTitle: string;
  @Output() onFormSubmit: EventEmitter<Resource> = new EventEmitter<Resource>();
  @Output() onCancel: EventEmitter<void> = new EventEmitter<void>();

  categories: Observable<ResourceCategory[]>;
  public resourceForm: FormGroup;

  constructor(
    public service: ResourceService,
    private router: Router,
    private formBuilder: FormBuilder
  ) {

  }

  ngOnInit() {
    this.categories = this.service
      .getResourceCategories(null,true).pipe(
        catchError(err => {
          console.log(err);
          return throwError(err);
        })
    );
    this.resourceForm = this.formBuilder.group(
      {
        id: [this.initValue && this.initValue.id || null],
        name: [
          this.initValue && this.initValue.name || "",
          [
            Validators.required,
            Validators.minLength(3),
            Validators.maxLength(50)
          ]
        ],
        description: [
          this.initValue && this.initValue.description || "",
          [
            Validators.required,
            Validators.minLength(5),
            Validators.maxLength(512)
          ]
        ],
        url: [this.initValue && this.initValue.url || "",[Validators.maxLength(256), Validators.minLength(4)]],
        file: [null, [forbiddenExtensionValidator(ForbiddenExts)]],
        categoryId: [this.initValue && this.initValue.categoryId || null, Validators.required]
      },
      {validators: [atLeastOne(Validators.required, ["url", "file"])]}
    );

    if(this.initValue && this.initValue.url){
      this.resourceForm.get("url").disable();
      this.resourceForm.get("file").disable();
    }
    else {
      this.resourceForm.get("file").valueChanges.subscribe(val => {
        const isValidFile = !this.isNullOrEmpty(val);
        if (isValidFile) {
          this.resourceForm.get("url").disable();
        } else if (this.resourceForm.get("url").disabled) {
          this.resourceForm.get("url").enable();
        }
      });
      this.resourceForm.get("url").valueChanges.subscribe(val => {
        const isValidUrl = val !== "";
        if (isValidUrl) {
          this.resourceForm.get("file").disable();
        } else if (this.resourceForm.get("file").disabled) {
          this.resourceForm.get("file").enable();
        }
      });
    }
  }

  onSubmit() {
    if (this.resourceForm.invalid) {
      const controls = this.resourceForm.controls;
      Object.keys(controls).forEach(controlName =>
        controls[controlName].markAsTouched()
      );
      return;
    }
    const resource: Resource = this.resourceForm.value;
    if (resource.file != null) {
      resource.file = this.resourceForm.value.file.files[0];
    }
    if (this.resourceForm.get("url").disabled) {
      resource.url = "";
    }
    this.onFormSubmit.emit(resource);
  }


  isNullOrEmpty(fileInput: FileInput) {
    if (fileInput == null) {
      return true;
    }
    if (fileInput.files == null) {
      return true;
    }
    if (fileInput.files.length == 0) {
      return true;
    }
    return fileInput.files[0].size == 0;
  }
}
