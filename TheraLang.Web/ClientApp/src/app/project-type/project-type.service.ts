import { Injectable } from '@angular/core';
import { ProjectType } from './ProjectType';
import { FormBuilder, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import { ProjectTypeHttp } from './ProjectTypeHttp.service';
import { NotificationService } from '../shared/services/notification.service';

@Injectable({
  providedIn: "root"
})
export class ProjectTypeService {
  constructor(
    private fb: FormBuilder,
    private http: ProjectTypeHttp,
    private notificationService: NotificationService
  ) { }

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

  populateForm(projectType: ProjectType) {
    this.form.setValue(projectType);
  }

  btnPut(projectType: ProjectType) {
    this.http.put(projectType).subscribe(
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

  btnPost(newProjectType: ProjectType): Observable<any> {
    this.http.post(newProjectType).subscribe(
      response => {
        this.notificationService.success("Project type was successfully added");
      },
      error => {
        this.notificationService.warn("Project type was not added");
      }
    );
    return;
  }

  btnDelete(projectTypeId: number) {
    this.http.delete(projectTypeId).subscribe(
      response => {
        this.notificationService.success(
          "Project type was successfully deleted"
        );
      },
      error => {
        this.notificationService.warn("Project type was not deleted");
      }
    );
  }
}
