import { Injectable } from "@angular/core";
import { FormBuilder, Validators } from "@angular/forms";
import { Resource } from "../../../shared/models/resource/resource";
import {
  resourceUrl,
  categoryUrl
} from "../../../configs/api-endpoint.constants";
import { HttpClient } from "@angular/common/http";
import { TranslateService } from "@ngx-translate/core";
import { NotificationService } from "../../services/notification/notification.service";
import { ForbiddenExts } from "src/app/configs/resource.constants";
import { forbiddenExtensionValidator } from "src/app/shared/directives/files/forbidden-extension.directive";

@Injectable({
  providedIn: "root"
})
export class ResourceCreateService {
  private resourceUrl = resourceUrl;
  private categoryUrl = categoryUrl;

  constructor(
    private formBuilder: FormBuilder,
    private notificationService: NotificationService,
    private http: HttpClient,
    private translate: TranslateService
  ) {}

  public resourceForm = this.formBuilder.group({
    id: [null],
    name: [
      "",
      [Validators.required, Validators.minLength(3), Validators.maxLength(50)]
    ],
    description: [
      "",
      [Validators.required, Validators.minLength(5), Validators.maxLength(5000)]
    ],
    // url: [""],
    // fileName: [""],
    file: [null, [forbiddenExtensionValidator(ForbiddenExts)]],
    categoryId: [null, Validators.required]
  });

  initializeForm() {
    this.resourceForm.setValue({
      id: null,
      name: "",
      description: "",
      // url: "",
      // fileName: "",
      file: File,
      categoryId: null
    });
  }

  postResource(resource: Resource) {
    const formData = new FormData();
    formData.append("name", resource.name);
    formData.append("description", resource.description);
    formData.append("categoryId", resource.categoryId.toString());
    formData.append("File", resource.file as File);
    return this.http.post(this.resourceUrl + "/" + "create", formData);
  }

  putResource(resource: Resource) {
    return this.http.put(this.resourceUrl + "/" + "update", resource);
  }

  getCategories() {
    return this.http.get(this.categoryUrl + "/" + "get");
  }

  populateForm(resource) {
    this.resourceForm.setValue(resource);
  }

  addResource(resource: Resource) {
    this.postResource(resource).subscribe(
      async response => {
        this.notificationService.success(
          await this.translate.get("common.created-successfully").toPromise()
        );
      },
      async error => {
        this.notificationService.warn(
          await this.translate.get("common.wth").toPromise()
        );
      }
    );
  }

  updateResource(resource: Resource) {
    this.putResource(resource).subscribe(
      async response => {
        this.notificationService.success(
          await this.translate.get("common.updated-successfully").toPromise()
        );
      },
      async error => {
        this.notificationService.warn(
          await this.translate.get("common.wth").toPromise()
        );
      }
    );
  }
}
