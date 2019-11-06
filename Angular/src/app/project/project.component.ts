import { Component, OnInit } from '@angular/core';
import {HttpService} from './http.service';
import {Project} from './project';
import {MatDialog, MatDialogConfig} from '@angular/material';
import { CreateProjectComponent } from '../create-project/create-project.component';
import { ProjectService } from './project.service';

@Component({
  selector: 'app-project',
  templateUrl: './project.component.html',
  styleUrls: ['./project.component.less'],
  providers:[ProjectService, HttpService]
})
export class ProjectComponent implements OnInit {

  projects:Project[];

  constructor(private httpService:HttpService,
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

  onEdit(id:number){
    this.service.initializeFormGroup(<Project>this.httpService.getProjectInfo(id));
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    this.dialog.open(CreateProjectComponent,dialogConfig);
  }
}
