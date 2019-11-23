import { Injectable } from "@angular/core";
import { FormBuilder, Validators } from "@angular/forms";
import { TypeProjectHttp } from "../type-project/TypeProjectHttp.service";
import { TypeProject } from "../type-project/TypeProject";
// import { NotificationService } from '../shared/services/notification.service';

@Injectable({
  providedIn: "root"
})
export class TypeProjectService {
  constructor(private fb: FormBuilder, private httpService: TypeProjectHttp) {}

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
      name: "wer"
    });
  }

  populateForm(typeProject) {
    this.form.setValue(typeProject);
  }

  addProject(typeProject: TypeProject) {
    this.httpService.post(typeProject);
    // this.notificationService.success("")
  }

  editProject(typeProject: TypeProject) {
    this.httpService.put("url", typeProject);
  }
}
