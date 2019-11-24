import { Component, OnInit } from "@angular/core";
import { HttpService } from "./http.service";
import { Project } from "./project";
import { MatDialog, MatDialogConfig } from "@angular/material";
import { CreateProjectComponent } from "../create-project/create-project.component";
import { Resource } from "../resources-table/resource";
import { TypeProjectComponent } from "../type-project/type-project.component";
import { TypeProjectService } from "../type-project-form/type-project.service";
import { DialogService } from "../shared/services/dialog.service";

import { from } from "rxjs";

@Component({
  selector: "app-project",
  templateUrl: "./project.component.html",
  styleUrls: ["./project.component.less"]
})
export class ProjectComponent implements OnInit {
  projects: Project[];

  constructor(
    private httpService: HttpService,
    private dialog: MatDialog,
    private typeProjectService: TypeProjectService
  ) {}

  ngOnInit() {
    this.httpService
      .getAllProjects()
      .subscribe((projects: Project[]) => (this.projects = projects));
  }

  onCreate() {
    const dialogConfig = new MatDialogConfig();
    dialogConfig.autoFocus = true;
    dialogConfig.width = "60%";
    dialogConfig.height = "40%";
    this.dialog.open(CreateProjectComponent, dialogConfig);
  }

  // ShowDialogTypeProject(id: number) {
  //   const dialogConfig = new MatDialogConfig();
  //   dialogConfig.autoFocus = true;
  //   dialogConfig.data
  //   this.dialog.open(TypeProjectComponent, dialogConfig); //todo refactor  component NewTypeProgectComponent
  // }

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
