import { Component, OnInit } from "@angular/core";
import { HttpService } from "../../../../core/http/http/http.service";
import { Project } from "../../../../shared/models/project/project";
import { ProjectService } from "../../../../core/http/project/project.service";
import { DialogService } from "../../../../core/services/dialog/dialog.service";
import { MatDialog, MatDialogConfig } from "@angular/material";
import { TranslateService } from "@ngx-translate/core";
import { AsyncScheduler } from "rxjs/internal/scheduler/AsyncScheduler";
import { NotificationService } from "src/app/core/services/notification/notification.service";
import { PercentPipe } from '@angular/common';
import { UserService } from 'src/app/core/auth/user.service';
import { Router } from '@angular/router';
import { ProjectCreationComponent } from './project-creation/project-creation.component';

@Component({
  selector: "app-project",
  templateUrl: "./project.component.html",
  styleUrls: ["./project.component.less"],
  providers: []
})
export class ProjectComponent implements OnInit {
  projects: Project[];
  imgPath:string

  constructor(
    private httpService: HttpService,
    private dialogService: DialogService,
    public service: ProjectService,
    private notificationService: NotificationService,
    private translate: TranslateService,
    private userService: UserService, 
    private router: Router
  ) {}

  ngOnInit() {
    this.httpService
      .getAllProjects()
      .subscribe((projects: Project[]) => (this.projects = projects));
  }

  onCreate() {
    this.router.navigate(["projects/create"]);
  }

  onEdit(project) {

       this.router.navigate(["projects/edit/" + project.id]);
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

  getProjectProgress(project: Project) {
    return (project.donationsSum / project.donationTargetSum);
  }
  isAuthenticated()
  {
       return this.userService.isAuthenticated();
  }
  isAdmin()
  {
    return this.userService.isAdmin();
  }

}
