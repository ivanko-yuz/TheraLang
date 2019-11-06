import { FormBuilder, Validators, FormGroup, FormControl } from "@angular/forms";
import { Project } from './project';
import { HttpService } from './http.service';


export class ProjectService {

  constructor(
    private fb = new FormBuilder(),
    private httpService: HttpService,
  ) { }

  form = this.fb.group({
    id: [null],
    name: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(50)]],
    description: ['', [Validators.required, Validators.minLength(5), Validators.maxLength(8000)]],
    type: ['', [Validators.required, Validators.minLength(3)]],
  });

  initializeFormGroup(project) {
    this.form.setValue(project);
  }

  addProject(project: Project) {
    this.httpService.createProject(project);
  }

  editProject(project: Project) {
    this.httpService.updateProject(project);
  }
}


