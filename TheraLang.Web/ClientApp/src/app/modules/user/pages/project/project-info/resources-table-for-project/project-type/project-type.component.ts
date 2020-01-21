import { ProjectTypeService } from "../../../../../../../core/services/project-type/project-type.service";
import { ProjectType } from "../../../../../../../shared/models/project-type/project-type.model";
import { ProjectTypeHttp } from "../../../../../../../core/http/project-type/project-type-Http.service";
import { MatDialog } from "@angular/material";
import { Component, OnInit } from "@angular/core";
import { ProjectTypeFormComponent } from "../../../project-type-form/project-type-form.component";
import { DialogService } from "src/app/core/services/dialog/dialog.service";
import { ProjectTypeCreateFormComponent } from "../../../project-type-create-form/project-type-create-form.component";

export interface DialogData {
  id: number;
  name: string;
}

@Component({
  selector: "app-project-type",
  templateUrl: "./project-type.component.html",
  styleUrls: ["./project-type.component.less"],
  providers: [ProjectTypeService, ProjectTypeFormComponent]
})
export class ProjectTypeComponent implements OnInit {
  id: number;
  name: string;
  displayedColumns: string[] = ["typeName", "actions"];
  projectTypes: ProjectType[];

  constructor(
    private projectTypeService: ProjectTypeService,
    private dialogService: DialogService,
    private http: ProjectTypeHttp,
    public dialog: MatDialog
  ) {}
  dataSource: any; //TODO: Ostap

  async ngOnInit() {
    this.projectTypes = await this.projectTypeService.getAllProjectTypes();
  }

  onCreate() {
    let dialogRef = this.dialog
      .open(ProjectTypeCreateFormComponent, {
        width: "250px"
      })
      .afterClosed()
      .subscribe(res => {
        this.ngOnInit();
      });
  }

  onEdit(projectType: ProjectType) {
    let dialogRef = this.dialog
      .open(ProjectTypeFormComponent, {
        width: "250px",
        data: { name: projectType.typeName, id: projectType.id }
      })
      .afterClosed()
      .subscribe(res => {
        this.ngOnInit();
      });
  }

  onDelete(id: number) {
    this.http.delete(id).subscribe(async res => {
      this.projectTypes = await this.projectTypeService.getAllProjectTypes();
    });
  }
}
