import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Resource } from './resource';
import { HttpService } from '../project/http.service';
import { Project } from '../project/project';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-resources',
  templateUrl: './resources.component.html',
  styleUrls: ['./resources.component.less'],
  providers:[HttpService]
})
export class ResourcesComponent implements OnInit {

  projectResources : Resource[];
  constructor(private route: ActivatedRoute,private http:HttpService) { };

  ngOnInit() {    
    this.http.getAllResourcesWithoutId().subscribe((_data:Resource[])=> this.projectResources=_data );
  }

}
