import { Component, OnInit } from '@angular/core';
import { MatDialogRef, DateAdapter } from '@angular/material';
import { ProjectService } from '../project/project.service';
import { TranslateService } from '@ngx-translate/core';

@Component({
  selector: 'app-create-project',
  templateUrl: './project-form.component.html',
  styleUrls: ['./project-form.component.less'],
  providers: [ProjectService]

})
export class ProjectFormComponent implements OnInit {

  constructor(private dialog: MatDialogRef<ProjectFormComponent>,
              public service: ProjectService,
              public dateAdapter: DateAdapter<Date>,
              private translate: TranslateService) { }

  ngOnInit() {
    this.dateAdapter.setLocale(this.translate.currentLang);
    this.dateAdapter.getFirstDayOfWeek = () => 1;
  }
  onClose() {
    this.service.form.reset();
    this.service.initializeFormGroup();
    this.dialog.close();
  }

  onSubmit() {
    if (this.service.form.invalid) {
      const controls = this.service.form.controls;
      Object.keys(controls)
        .forEach(controlName => controls[controlName].markAsTouched());
      return;
    } else if (!this.service.form.get('id').value) {
      this.service.addProject(this.service.form.value);
      this.onClose();
    } else {
      this.service.editProject(this.service.form.value);
      this.onClose();
    }
  }
}
