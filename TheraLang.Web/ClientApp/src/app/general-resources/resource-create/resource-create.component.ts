import { Component, OnInit } from '@angular/core';
import {MatDialogRef} from '@angular/material/dialog';
import { ResourceCreateService } from './resource-create.service';
import { ResourceCategory } from '../resource-models/resource-category';

@Component({
  selector: 'app-resource-create',
  templateUrl: './resource-create.component.html',
  styleUrls: ['./resource-create.component.less'],
})
export class ResourceCreateComponent implements OnInit {

  categories : ResourceCategory[];

  constructor(private dialog : MatDialogRef<ResourceCreateComponent>,
    public service : ResourceCreateService) { }

  ngOnInit() {
    this.service.getCategories().subscribe((categories : ResourceCategory[]) => this.categories = categories);
  }

  onClose(){
    this.service.resourceForm.reset();
    this.service.initializeForm();
    this.dialog.close();
  }

  onSubmit(){
    if (this.service.resourceForm.invalid) {
      const controls = this.service.resourceForm.controls;
      Object.keys(controls)
        .forEach(controlName => controls[controlName].markAsTouched());
      return;
    }
    else if (!this.service.resourceForm.get('id').value) {
      this.service.addResource(this.service.resourceForm.value);
      this.onClose();
    }
    else {
      this.service.addResource(this.service.resourceForm.value);
      this.onClose();
    }
  }
}
