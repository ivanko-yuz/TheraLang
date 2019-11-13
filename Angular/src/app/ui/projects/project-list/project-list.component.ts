import { Component, OnInit } from '@angular/core';
import {Project} from '../shared/project';
import {MatDialog, MatDialogConfig} from '@angular/material';
import { ProjectFormComponent } from '../project-form/project-form.component';
import { HttpProjectService } from '../shared/http-project.service';
import { ProjectService } from '../shared/project.service';


@Component({
  selector: 'app-project-list',
  templateUrl: './project-list.component.html',
  styleUrls: ['./project-list.component.less'],
  providers:[]
})
export class ProjectListComponent implements OnInit {

  projects: Project[];

  constructor(private httpService:HttpProjectService,
    private dialog:MatDialog,
    private service:ProjectService) { }

  ngOnInit() {
    this.httpService.getAllProjects().subscribe((data:Project[]) => this.projects=data);
  }

  onCreate(){
    const dialogConfig = new MatDialogConfig();
    dialogConfig.autoFocus = true;
    dialogConfig.disableClose = true;
    dialogConfig.width = '60%';
    dialogConfig.panelClass = 'form';

    this.dialog.open(ProjectFormComponent, dialogConfig);
  }

  project:Project = new Project(1, 'abcde', 'qwerty', 'awdawed')

  onEdit(id:number){
    this.service.populateForm(<Project>this.httpService.getProjectInfo(id));
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    this.dialog.open(ProjectFormComponent,dialogConfig);
  }
}
