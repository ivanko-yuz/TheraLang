import { Component, OnInit } from '@angular/core';
import {HttpService} from './http.service';
import {Project} from './project';
import {MatDialog, MatDialogConfig} from '@angular/material';
import { CreateProjectComponent } from '../create-project/create-project.component';
import { Resource } from '../resources-table/resourceCategory';

@Component({
  selector: 'app-project',
  templateUrl: './project.component.html',
  styleUrls: ['./project.component.less'],
  providers:[HttpService]
})
export class ProjectComponent implements OnInit {

  projects:Project[];

  constructor(private httpService:HttpService,
    private dialog:MatDialog) { }

  ngOnInit() {
    this.httpService.getAllProjects().subscribe((data : Project[]) => this.projects = data);   
  }
  
  onCreate(){
    const dialogConfig = new MatDialogConfig();
    dialogConfig.autoFocus = true;
    dialogConfig.width = "60%";
    dialogConfig.height = "40%";
  this.dialog.open(CreateProjectComponent, dialogConfig);
  }

}
