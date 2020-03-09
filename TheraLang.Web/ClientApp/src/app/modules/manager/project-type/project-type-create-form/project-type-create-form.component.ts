import { Component, OnInit } from "@angular/core";
import { ProjectTypeService } from "../../../../core/services/project-type/project-type.service";
import { ProjectType } from "../../../../shared/models/project-type/project-type.model";
import { DateAdapter, MatDialogRef } from "@angular/material";

@Component({
  selector: "app-project-type-create-form",
  templateUrl: "./project-type-create-form.component.html",
  styleUrls: ["./project-type-create-form.component.less"]
})
export class ProjectTypeCreateFormComponent implements OnInit {
  newData: ProjectType;

  ngOnInit(): void {
    this.newData = new ProjectType();
  }

  constructor(
    private dialog: MatDialogRef<ProjectTypeCreateFormComponent>,
    public service: ProjectTypeService,
    public dateAdapter: DateAdapter<Date>
  ) {}

  onCloseForm(): void {
    this.dialog.close();
  }

  onSubmit() {
    this.service.Create(this.newData);
  }
}
