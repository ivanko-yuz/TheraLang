import { Component, OnInit } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { TypeProject } from "./TypeProject";
import { Observable } from "rxjs";
import { TypeProjectHttp } from "./TypeProjectHttp.service";
import { error } from "@angular/compiler/src/util";
import { TypeProjectService } from "./type-project.service";
import { MatDialogRef } from "@angular/material";

@Component({
  selector: "app-type-project",
  templateUrl: "./type-project.component.html",
  styleUrls: ["./type-project.component.less"]
})
export class TypeProjectComponent implements OnInit {
  constructor(
    private dialog: MatDialogRef<TypeProjectComponent>,
    public service: TypeProjectService
  ) {}

  ngOnInit() {}
  onClose() {
    this.service.form.reset();
    this.service.initializeFormGroup();
    this.dialog.close();
  }

  // onSubmit() {
  //   if (this.service.form.invalid) {
  //     const controls = this.service.form.controls;
  //     Object.keys(controls).forEach(controlName =>
  //       controls[controlName].markAsTouched()
  //     );
  //     return;
  //   } else if (!this.service.form.get("id").value) {
  //     this.service.addProject(this.service.form.value);
  //     this.onClose();
  //   } else {
  //     this.service.editProject(this.service.form.value);
  //     this.onClose();
  //   }
  // }
}
