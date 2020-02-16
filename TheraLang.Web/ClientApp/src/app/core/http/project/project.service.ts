import { Injectable } from "@angular/core";
import { FormBuilder, Validators, FormGroup } from "@angular/forms";
import { Project } from "../../../shared/models/project/project";
import { HttpService } from "../http/http.service";
import { TranslateService } from "@ngx-translate/core";
import { NotificationService } from "../../services/notification/notification.service";
import { JwtHelperService } from '@auth0/angular-jwt';
import { HttpClient } from '@angular/common/http';
import { baseUrl } from 'src/app/configs/api-endpoint.constants';

@Injectable({
  providedIn: "root"
})
export class ProjectService {

  private url = baseUrl + "projects/";

  constructor(
    private fb: FormBuilder,
    private httpService: HttpService,
    private http: HttpClient,
    private notificationService: NotificationService,
    private translate: TranslateService,
    private jwtHelper: JwtHelperService,
  ) { }

  form: FormGroup = this.fb.group({
    id: [""],
    name: [
      "",
      [Validators.required, Validators.minLength(3), Validators.maxLength(50)]
    ],
    description: [
      "",
      [
        Validators.required,
        Validators.minLength(10),
        Validators.maxLength(8000)
      ]
    ],
    details: ["", Validators.maxLength(8000)],
    projectStart: ["", Validators.required],
    projectEnd: [""],
    typeId: ["", Validators.required],
    donationTargetSum: [""]
  });

  initializeFormGroup() {
    this.form.setValue({
      id: null,
      name: "",
      description: "",
      details: "",
      projectStart: "",
      projectEnd: "",
      typeId: "",
      donationTargetSum: ""
    });
  }

  populateForm(project: Project) {
    this.form.setValue({
      id: project.id,
      name: project.name,
      description: project.description,
      details: project.details,
      projectStart: project.projectStart,
      projectEnd: project.projectEnd,
      typeId: project.typeId,
      donationTargetSum: project.donationTargetSum
    });
  }

  createProject(project: Project) {
    return this.http.post(this.url + "create", project);
  }

  updateProject(project: Project) {
    return this.http.put(this.url + "update" + "/" + project.id, project);
  }

  getProjectTypes() {
    return this.httpService.getAllProjectTypes();
  }
}
