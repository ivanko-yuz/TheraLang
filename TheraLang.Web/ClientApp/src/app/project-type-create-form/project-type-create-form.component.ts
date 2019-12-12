import { Component, OnInit } from '@angular/core';
import { ProjectTypeService } from '../project-info/resources-table-for-project/project-type/project-type.service';
import { ProjectType } from '../project-info/resources-table-for-project/project-type/project-type.model';
import { DateAdapter, MatDialogRef } from '@angular/material';

@Component({
  selector: 'app-project-type-create-form',
  templateUrl: './project-type-create-form.component.html',
  styleUrls: ['./project-type-create-form.component.less']
})
export class ProjectTypeCreateFormComponent implements OnInit {

  newData: ProjectType;

  ngOnInit(): void {
    this.newData = new ProjectType();
  }

  constructor(private dialog: MatDialogRef<ProjectTypeCreateFormComponent>,
    public service: ProjectTypeService,
    public dateAdapter: DateAdapter<Date>,
  ) { }

  onCancelClick(): void {
    this.dialog.close();
  }

  onOkClick() {
    this.service.Create(this.newData);
  }

}
