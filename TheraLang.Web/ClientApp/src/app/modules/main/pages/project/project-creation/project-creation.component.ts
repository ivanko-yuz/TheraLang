import { Component, OnInit } from "@angular/core";
import { DateAdapter } from "@angular/material";
import { ProjectService } from "../../../../../core/http/project/project.service";
import { ProjectType } from "../../../../../shared/models/project-type/project-type.model";
import { TranslateService } from "@ngx-translate/core";
import { Router } from '@angular/router';

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
    private router: Router
  ) {}

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
      this.service.addProject(this.service.form.value);
      this.router.navigate(["/"]);
      
    } else {
      this.service.editProject(this.service.form.value);
      
    }
  }
}