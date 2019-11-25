import { Component, OnInit } from "@angular/core";
import { HttpService } from "./http.service";
import { Project } from "./project";
import { MatDialog, MatDialogConfig } from "@angular/material";
import { Resource } from "../resources-table/resource";
import { TypeProjectComponent } from "../type-project/type-project.component";
import { TypeProjectService } from "../type-project/type-project.service";
import { ProjectFormComponent } from "../project-form/project-form.component";
import { ProjectService } from "./project.service";
import { DialogService } from "../shared/services/dialog.service";

@Component({
  selector: "app-project",
  templateUrl: "./project.component.html",
  styleUrls: ["./project.component.less"],
  providers: [ProjectService]
})
export class ProjectComponent implements OnInit {
  projects: Project[];

  constructor(
    private httpService: HttpService,
    private dialogService: DialogService,
    private service: ProjectService,
    private dialog: MatDialog,
    private typeProjectService: TypeProjectService
  ) {}

  ngOnInit() {
    this.httpService
      .getAllProjects()
      .subscribe((projects: Project[]) => (this.projects = projects));
  }

  onCreate() {
    this.service.initializeFormGroup();
    this.dialogService.openFormDialog(ProjectFormComponent);
  }

  onEdit(project) {
    this.service.populateForm(project);
    this.dialogService.openFormDialog(ProjectFormComponent);
  }

  onCreateTypeProject() {
    this.typeProjectService.initializeFormGroup();
    // this.typeProjectService.openFormDialog(TypeProjectFormComponent);
    //from SHARED
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = "60%";
    dialogConfig.panelClass = "form";
    this.dialog.open(TypeProjectComponent, dialogConfig);
  }
}
