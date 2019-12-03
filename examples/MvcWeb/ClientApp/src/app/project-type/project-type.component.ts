import { Component, OnInit } from '@angular/core';
import { ProjectTypeService } from './project-type.service';
import { MatDialogRef } from '@angular/material';

@Component({
  selector: "app-project-type",
  templateUrl: "./project-type.component.html",
  styleUrls: ["./project-type.component.less"]
})
export class ProjectTypeComponent implements OnInit {
  constructor(
    private dialog: MatDialogRef<ProjectTypeComponent>,
    public service: ProjectTypeService
  ) { }

  ngOnInit() { }
  onClose() {
    this.service.form.reset();
    this.service.initializeFormGroup();
    this.dialog.close();
  }

  onSubmit() {
    if (this.service.form.invalid) {
      const controls = this.service.form.controls;
      Object.keys(controls).forEach(controlName =>
        controls[controlName].markAsTouched()
      );
    }
    if (!this.service.form.get("id").value) {
      this.service.btnPost(this.service.form.value);
      this.onClose();
    } else {
      this.service.btnPut(this.service.form.value);
      this.onClose();
    }
  }
}
