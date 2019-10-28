import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Resource } from './resource';
import { HttpService } from '../project/http.service';
import { Project } from '../project/project';

@Component({
  selector: 'app-resources',
  templateUrl: './resources.component.html',
  styleUrls: ['./resources.component.less'],
  providers:[HttpService]
})
export class ResourcesComponent implements OnInit {

  resources : Resource;
  projects : Project;
  constructor(private httpService:HttpService) { }

  ngOnInit() {    
    // this.httpService.getAllResources().subscribe((data : Resource) => this.resources = {
    //   id : data['Id'],
    //   name : data['DateTime'],
    //   type : data['Type']
    // });
  }

}
