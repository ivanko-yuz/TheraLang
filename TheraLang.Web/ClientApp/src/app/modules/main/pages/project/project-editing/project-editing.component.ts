import { Component, OnInit } from "@angular/core";
import { DateAdapter } from "@angular/material";
import { ProjectService } from "../../../../../core/http/project/project.service";
import { ProjectType } from "../../../../../shared/models/project-type/project-type.model";
import { TranslateService } from "@ngx-translate/core";
import { Router } from '@angular/router';

@Component({
  selector: 'app-project-editing',
  templateUrl: './project-editing.component.html',
  styleUrls: ['./project-editing.component.less']
})
export class ProjectEditingComponent implements OnInit {
  projectTypes: ProjectType[];
  constructor(
    public service: ProjectService,
    public dateAdapter: DateAdapter<Date>,
    private translate: TranslateService,
    private router: Router
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
    }  else {
      this.service.editProject(this.service.form.value);
      
    }
  }

}
