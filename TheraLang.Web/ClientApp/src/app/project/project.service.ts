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
    description: ['', [Validators.required, Validators.maxLength(8000)]],
    details: ['', Validators.maxLength(8000)],
    projectStart: ['', Validators.required],
    projectEnd: [''],
    typeId: ['', Validators.required],
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
    });
  }


  populateForm(project) {
    this.form.setValue(project);
  }

  addProject(project: Project) {
    this.httpService.createProject(project).subscribe(
<<<<<<< HEAD
      (msg: string) => {
       msg = 'Проект створено';
       this.notificationService.success(msg)
      },
      (error) => {
         console.log(error);
         this.notificationService.warn('Помилка при створенні проекту');
=======
      (res) => {
        if (res.ok) {
          this.notificationService.success('Проект успішно створено')
        }
      },
      (error) => {
        console.log(error);
        this.notificationService.warn('Помилка при створенні')
>>>>>>> master
      });
  }

  editProject(project: Project) {
    this.httpService.updateProject(project).subscribe(
<<<<<<< HEAD
      (msg: string) => {
        msg = 'Проект оновлено';
        this.notificationService.success(msg);
       },
       (error) => {
          console.log(error);
          this.notificationService.warn('Помилка при оновленні проекту')
       });
  }

  getProjectTypes(){
    return this.httpService.getAllProjectTypes();
=======
      (res) => {
        if (res.ok) {
          this.notificationService.success('Проект успішно оновлено')
        }
      },
      (error) => {
        console.log(error);
        this.notificationService.warn('Помилка при оновленні')
      });
>>>>>>> master
  }
}

