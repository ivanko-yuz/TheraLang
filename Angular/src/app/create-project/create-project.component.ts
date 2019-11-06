import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material';
import { ProjectService } from '../project/project.service';

@Component({
  selector: 'app-create-project',
  templateUrl: './create-project.component.html',
  styleUrls: ['./create-project.component.less'],
  providers: [ProjectService]
})
export class CreateProjectComponent implements OnInit {

  constructor(private dialog:MatDialog,
     public service: ProjectService) { }

  ngOnInit() {
    
  }

  onClose() {
    this.service.form.reset();
    this.dialog.closeAll();}

  onSubmit() {
    if (this.service.form.valid) {
      if (!this.service.form.get('id').value)
        this.service.addProject(this.service.form.value);
      else
      this.service.editProject(this.service.form.value);
      this.service.form.reset();
      this.onClose();
    }
    else {
      const controls = this.service.form.controls;
      Object.keys(controls)
       .forEach(controlName => controls[controlName].markAsTouched());
       return;
     }
  }
}