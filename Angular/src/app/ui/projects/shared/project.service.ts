import { Injectable, forwardRef, Inject } from '@angular/core';
import { FormBuilder, Validators, FormGroup, FormControl } from '@angular/forms';
import { HttpProjectService } from '../shared/http-project.service';
import { Project } from './project';

export class ProjectService {

  constructor(
    @Inject(forwardRef(() => HttpProjectService))
    private httpService: HttpProjectService,
    private fb = new FormBuilder(),
  ) { }

  form = this.fb.group({
    id: [null],
    name: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(50)]],
    description: ['', [Validators.required, Validators.minLength(5), Validators.maxLength(8000)]],
    type: ['', [Validators.required, Validators.minLength(3)]],
  });

  initializeFormGroup() {
    this.form.setValue({
      id: null,
      name: '',
      description: '',
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
