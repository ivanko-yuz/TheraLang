import { Component, OnInit } from "@angular/core";
import { HttpService } from "../../../../core/http/http/http.service";
import { Project } from "../../../../shared/models/project/project";
import { ProjectFormComponent } from "./project-form/project-form.component";
import { ProjectService } from "../../../../core/http/project/project.service";
import { DialogService } from "../../../../core/services/dialog/dialog.service";
import { MatDialog, MatDialogConfig } from "@angular/material";
import { TranslateService } from "@ngx-translate/core";
import { AsyncScheduler } from "rxjs/internal/scheduler/AsyncScheduler";
import { NotificationService } from "src/app/core/services/notification/notification.service";

@Component({
  selector: "app-project",
  templateUrl: "./project.component.html",
  styleUrls: ["./project.component.less"],
  providers: []
})
export class ProjectComponent implements OnInit {
  projects: Project[];

  constructor(
    private httpService: HttpService,
    private dialogService: DialogService,
    public service: ProjectService,
    private notificationService: NotificationService,
    private translate: TranslateService
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
    this.service.initializeFormGroup();
    this.service.populateForm(project);
    this.dialogService.openFormDialog(ProjectFormComponent);
  }

  async onDelete(id) {
    this.dialogService
      .openConfirmDialog(
        await this.translate.get("common.r-u-sure").toPromise()
      )
      .afterClosed()
      .subscribe(async res => {
        if (res) {
          this.httpService.deleteProject(id).subscribe(result => {
            this.httpService
              .getAllProjects()
              .subscribe((projects: Project[]) => (this.projects = projects));
          });
          this.notificationService.warn(
            await this.translate.get("common.deleted-successfully").toPromise()
          );
        }
      });
  }
}
