import { Component, OnInit, Inject } from "@angular/core";
import { MatDialogRef, DateAdapter, MAT_DIALOG_DATA } from "@angular/material";
import { DialogData } from "../project-info/resources-table-for-project/project-type/project-type.component";
import { ProjectTypeService } from "../../../../../core/services/project-type/project-type.service";
import { ProjectType } from "../../../../../shared/models/project-type/project-type.model";

@Component({
  selector: "app-project-type-form",
  templateUrl: "./project-type-form.component.html",
  styleUrls: ["./project-type-form.component.less"],
  providers: [ProjectTypeService]
})
export class ProjectTypeFormComponent implements OnInit {
  ngOnInit(): void {}

  constructor(
    private dialog: MatDialogRef<ProjectTypeFormComponent>,
    public service: ProjectTypeService,
    public dateAdapter: DateAdapter<Date>,
    @Inject(MAT_DIALOG_DATA) public data: DialogData
  ) {}

  onCloseForm(): void {
    this.dialog.close();
  }

  onSubmit() {
    let newData = new ProjectType();
    newData.id = this.data.id;
    newData.typeName = this.data.name;
    this.service.Update(newData);
  }
}
