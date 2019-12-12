import { ProjectTypeService } from './project-type.service';
import { ProjectType } from './project-type.model';
import { ProjectTypeHttp } from './project-type-Http.service';
import { ProjectTypeFormComponent } from 'src/app/project-type-form/project-type-form.component';
import { Component, OnInit } from '@angular/core';
import { DialogService } from 'src/app/shared/services/dialog.service';
import { MatDialog } from '@angular/material';
import { ProjectTypeCreateFormComponent } from 'src/app/project-type-create-form/project-type-create-form.component';

export interface DialogData {
  id: number;
  name: string;
}

@Component({
  selector: 'app-project-type',
  templateUrl: './project-type.component.html',
  styleUrls: ['./project-type.component.less'],
  providers: [ProjectTypeService, ProjectTypeFormComponent]
})

export class ProjectTypeComponent implements OnInit {
  id: number;
  name: string;
  displayedColumns: string[] = ['typeName', 'actions'];
  projectTypes: ProjectType[];

  constructor(private projectTypeService: ProjectTypeService,
    private dialogService: DialogService,
    private http: ProjectTypeHttp,
    public dialog: MatDialog,
  ) { }
  dataSource: any; //TODO: Ostap

  async ngOnInit() {
    this.projectTypes = await this.projectTypeService.getAllProjectTypes();
  }

  onCreate() {
    let dialogRef = this.dialog.open(ProjectTypeCreateFormComponent, {
      width: '250px'
    }).afterClosed().subscribe(res => { this.ngOnInit() });
  }

  onEdit(projectType: ProjectType) {
    let dialogRef = this.dialog.open(ProjectTypeFormComponent, {
      width: '250px',
      data: { name: projectType.typeName, id: projectType.id }
    }).afterClosed().subscribe(res => { this.ngOnInit() });
  }

  onDelete(id: number) {
    this.http.delete(id).subscribe(
      async res => { this.projectTypes = await this.projectTypeService.getAllProjectTypes(); });
  }





}
