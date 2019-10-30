import { Component, OnInit } from '@angular/core';
import {HttpService} from './http.service';
import {Project} from './project';

@Component({
  selector: 'app-project',
  templateUrl: './project.component.html',
  styleUrls: ['./project.component.less'],
  providers:[HttpService]
})
export class ProjectComponent implements OnInit {

  projects:Project[];

  constructor(private httpService:HttpService) { }

  ngOnInit() {
    this.httpService.getAllProjects().subscribe((data : Project[]) => this.projects = data);   
  }

}
