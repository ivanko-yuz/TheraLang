import { Component, OnInit } from "@angular/core";
import { MatDialogRef } from "@angular/material";
import { TypeProjectService } from "../type-project-form/type-project.service";

@Component({
  selector: "app-type-project-form",
  templateUrl: "./type-project-form.component.html",
  styleUrls: ["./type-project-form.component.less"]
})
export class TypeProjectFormComponent implements OnInit {
  constructor(
    private dialog: MatDialogRef<TypeProjectFormComponent>,
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
