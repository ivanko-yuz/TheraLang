import { Component, OnInit } from '@angular/core';
import {Project} from './project';
import {MatDialog, MatDialogConfig} from '@angular/material';
import { CreateProjectComponent } from '../create-project/create-project.component';
import { ProjectService } from './shared/project.service';
import { HttpProjectService } from './shared/http-project.service';
import { Resource } from '../resources-table/resource';


@Component({
  selector: 'app-project',
  templateUrl: './project.component.html',
  styleUrls: ['./project.component.less'],
  providers:[]
})
export class ProjectComponent implements OnInit {

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

    this.dialog.open(CreateProjectComponent, dialogConfig);
  }

  project:Project = new Project(1, 'abcde', 'qwerty', 'awdawed')

  onEdit(id:number){
    this.service.populateForm(<Project>this.httpService.getProjectInfo(id));
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    this.dialog.open(CreateProjectComponent,dialogConfig);
  }
}
