import { Injectable } from "@angular/core";
import { TypeProject } from "./TypeProject";
import { FormBuilder, Validators } from "@angular/forms";
import { Observable } from "rxjs";
import { TypeProjectHttp } from "./TypeProjectHttp.service";
import { NotificationService } from "../shared/services/notification.service";
import { typeProjectUrl } from "../shared/api-endpoint.constants";

@Injectable({
  providedIn: "root"
})
export class TypeProjectService {
  constructor(
    private fb: FormBuilder,
    private http: TypeProjectHttp,
    private notificationService: NotificationService
  ) {}

  public form = this.fb.group({
    id: [null],
    name: [
      "",
      [Validators.required, Validators.minLength(3), Validators.maxLength(50)]
    ]
  });

  initializeFormGroup() {
    this.form.setValue({
      id: null,
      name: ""
    });
  }

  populateForm(typeProject: TypeProject) {
    this.form.setValue(typeProject);
  }

  btnPut(typeProject: TypeProject) {
    let putUrl = typeProjectUrl + typeProject.id;
    this.http.put(putUrl, typeProject).subscribe(
      response => {
        this.notificationService.success(
          "Project type was successfully updated"
        );
      },
      error => {
        this.notificationService.warn("Project type was not updated");
      }
    );
  }

  btnPost(newTypeProject: TypeProject): Observable<any> {
    this.http.post(newTypeProject).subscribe(
      response => {
        this.notificationService.success("Project type was successfully added");
      },
      error => {
        this.notificationService.warn("Project type was not added");
      }
    );
    return;
  }

  btnDelete(id: number) {
    this.http.delete(id).subscribe(
      response => {
        this.notificationService.success(
          "Project type was successfully deleted"
        );
      },
      error => {
        this.notificationService.warn("Project type was not updated");
      }
    );
  }
}
