import { Injectable } from "@angular/core";
import { TypeProject } from "./TypeProject";
import { Component, OnInit } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { FormBuilder, Validators } from "@angular/forms";
import { Observable } from "rxjs";
import { TypeProjectHttp } from "./TypeProjectHttp.service";
import { NotificationService } from "../shared/services/notification.service";

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
      name: "wer"
    });
  }

  populateForm(typeProject) {
    this.form.setValue(typeProject);
  }

  private url = "https://localhost:44355/api/typeProject";
  myvalue: string;

  btnPut() {
    let putUrl = this.url + "/" + 1;
    let newProj: TypeProject = new TypeProject(1, "updated");
    this.http.put(putUrl, newProj).subscribe(
      response => {
        this.notificationService.success("");
      },
      error => {
        this.notificationService.warn("");
      }
    );
  }

  btnPost(newTypeProject: TypeProject): Observable<any> {
    this.http.post(newTypeProject).subscribe(
      response => {
        this.notificationService.success("");
      },
      error => {
        this.notificationService.warn("");
      }
    );
    return;
  }

  btnDelete(id: number) {
    let code: number;
    this.http.delete(id).subscribe(
      response => {
        this.notificationService.success("");
      },
      error => {
        this.notificationService.warn("");
      }
    );
  }
}
