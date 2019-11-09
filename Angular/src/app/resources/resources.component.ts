import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Resource } from './resource';
import { Project } from '../project/project';
import { ActivatedRoute } from '@angular/router';
import { HttpProjectService } from '../project/shared/http-project.service';

@Component({
  selector: 'app-resources',
  templateUrl: './resources.component.html',
  styleUrls: ['./resources.component.less'],
  providers:[HttpProjectService]
})
export class ResourcesComponent implements OnInit {

  projectResources : Resource[];
  constructor(private route: ActivatedRoute,private http:HttpProjectService) { };

  ngOnInit() {    
    this.http.getAllResourcesWithoutId().subscribe((_data:Resource[])=> this.projectResources=_data );
  }

}
