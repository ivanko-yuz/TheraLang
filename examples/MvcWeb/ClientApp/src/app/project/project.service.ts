import { Injectable } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Project } from './project';
import { HttpService } from './http.service';
import { NotificationService } from '../shared/services/notification.service';

@Injectable({
  providedIn: 'root'
})
export class ProjectService {

  constructor(private fb: FormBuilder,
    private httpService: HttpService,
    private notificationService: NotificationService) { }

  public form = this.fb.group({
    id: [null],
    name: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(50)]],
    description: ['', [Validators.required, Validators.minLength(5), Validators.maxLength(8000)]],
    details: ['', Validators.maxLength(8000)],
    projectStart: ['', Validators.required],
    projectEnd: [''],
    type: ['', [Validators.required, Validators.minLength(3)]],
  });


  initializeFormGroup() {
    this.form.setValue({
      id: null,
      name: '',
      description: '',
      details: '',
      projectStart: '',
      projectEnd: '',
      type: '',
    });
  }


  populateForm(project) {
    this.form.setValue(project);
  }

  addProject(project: Project) {
    this.httpService.createProject(project);
  }

  editProject(project: Project) {
    this.httpService.updateProject(project);
  }
}
