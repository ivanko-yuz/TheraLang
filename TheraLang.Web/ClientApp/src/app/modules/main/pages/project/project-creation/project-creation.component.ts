import { Component, OnInit } from "@angular/core";
import { DateAdapter } from "@angular/material";
import { ProjectService } from "../../../../../core/http/project/project.service";
import { ProjectType } from "../../../../../shared/models/project-type/project-type.model";
import { TranslateService } from "@ngx-translate/core";
import { Router } from '@angular/router';
import { NotificationService } from 'src/app/core/services/notification/notification.service';
import { Project } from 'src/app/shared/models/project/project';

@Component({
  selector: "app-create-project",
  templateUrl: "./project-creation.component.html",
  styleUrls: ["./project-creation.component.less"],
  providers: [ProjectService]
})
export class ProjectCreationComponent implements OnInit {
  projectTypes: ProjectType[];


  constructor(
    public service: ProjectService,
    public dateAdapter: DateAdapter<Date>,
    private translate: TranslateService,
    private router: Router,
    private notificationService: NotificationService
  ) { }

  ngOnInit() {
    this.dateAdapter.setLocale(this.translate.currentLang),
      (this.dateAdapter.getFirstDayOfWeek = () => {
        return 1;
      }),
      this.service
        .getProjectTypes()
        .subscribe(
          (projectTypes: ProjectType[]) => (this.projectTypes = projectTypes)
        );
  }


  onSubmit() {
    if (this.service.form.invalid) {
      const controls = this.service.form.controls;
      Object.keys(controls).forEach(controlName =>
        controls[controlName].markAsTouched()
      );
      return;
    } else if (!this.service.form.get("id").value) {
      const project: Project = this.service.form.value;
      console.log(project.name);
      if(project.ImgFile != null){
        project.ImgFile  = this.service.form.value.ImgFile.files[0] as File;
      }
      this.service.createProject(project).subscribe(
        async (msg: string) => {
          msg = await this.translate
            .get("common.created-successfully")
            .toPromise();
          this.notificationService.success(msg);
          this.router.navigate(["/"]);
        },
        async error => {
          console.log(error);
          this.notificationService.warn(
            await this.translate.get("common.wth").toPromise()
          );
        }
      );
    } else {
      // TODO: Is it needed here?
      // this.service.updateProject(this.service.form.value);
    }
  }
}
