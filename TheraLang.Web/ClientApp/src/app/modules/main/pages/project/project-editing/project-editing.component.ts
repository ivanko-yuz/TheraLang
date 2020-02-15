import { Component, OnInit } from "@angular/core";
import { DateAdapter } from "@angular/material";
import { ProjectService } from "../../../../../core/http/project/project.service";
import { ProjectType } from "../../../../../shared/models/project-type/project-type.model";
import { TranslateService } from "@ngx-translate/core";
import { Router, ActivatedRoute } from '@angular/router';
import { Project } from 'src/app/shared/models/project/project';
import { HttpService } from 'src/app/core/http/http/http.service';

@Component({
  selector: 'app-project-editing',
  templateUrl: './project-editing.component.html',
  styleUrls: ['./project-editing.component.less']
})
export class ProjectEditingComponent implements OnInit {
  projectTypes: ProjectType[];
  projectId:number;
  constructor(
    public service: ProjectService,
    public dateAdapter: DateAdapter<Date>,
    private translate: TranslateService,
    private router: Router,
    private route: ActivatedRoute,
    private httpService: HttpService,
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
      this.route.params.subscribe(params => {this.projectId= +params['id'];})
      this.httpService.getProjectInfo(this.projectId)
      .subscribe((data: Project) => (this.populateForm(data)));
  }

  populateForm(data: Project) {
    this.service.form.setValue({
      id: data.id,
      name: data.name,
      description: data.description,
      details: data.details,
      projectStart: data.projectStart,
      projectEnd: data.projectEnd,
      typeId: data.typeId,
      donationTargetSum: data.donationTargetSum
    })
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
      this.router.navigate(["/projects"]);
      
    }
  }

}