import { Injectable } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { Project } from './project';
import { HttpService } from './http.service';
import { NotificationService } from '../shared/services/notification.service';
import { TranslateService } from '@ngx-translate/core';

@Injectable({
  providedIn: 'root'
})
export class ProjectService {

  constructor(private fb: FormBuilder,
    private httpService: HttpService,
    private notificationService: NotificationService,
    private translate: TranslateService
  ) { }

  form: FormGroup = this.fb.group({
    id: [''],
    name: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(50)]],
    description: ['', [Validators.required, Validators.minLength(10), Validators.maxLength(8000)]],
    details: ['', Validators.maxLength(8000)],
    projectStart: ['', Validators.required],
    projectEnd: [''],
    typeId: ['', Validators.required],
    donationTargetSum: ['']
  });


  initializeFormGroup() {
    this.form.setValue({
      id: null,
      name: '',
      description: '',
      details: '',
      projectStart: '',
      projectEnd: '',
      typeId: '',
      donationTargetSum: '',
    });
  }


  populateForm(project: Project) {
    this.form.setValue({
      id: project.id,
      name: project.name,
      description: project.description,
      details: project.details,
      projectStart: project.projectStart,
      projectEnd: project.projectEnd,
      typeId: project.typeId,
      donationTargetSum: project.donationTargetSum,
    });
  }

  addProject(project: Project) {
    this.httpService.createProject(project).subscribe(
      async (msg: string) => {
        msg = await this.translate.get('common.created-successfully').toPromise();
        this.notificationService.success(msg);
      },
      async (error) => {
        console.log(error);
        this.notificationService.warn(await this.translate.get('common.wth').toPromise());
      });

  }

  editProject(project: Project) {
    this.httpService.updateProject(project).subscribe(
      async (msg: string) => {
        msg = await this.translate.get('updated-successfully').toPromise();
        this.notificationService.success(msg);
      },
      async (error) => {
        console.log(error);
        this.notificationService.warn(await this.translate.get('common.wth').toPromise());
      });
  }

  getProjectTypes() {
    return this.httpService.getAllProjectTypes();
  }
}

