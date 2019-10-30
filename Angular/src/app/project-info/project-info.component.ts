import { Component, OnInit, ViewEncapsulation, ViewChild, AfterViewInit} from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HttpService } from '../project/http.service';
import { Project } from '../project/project';
import { Resource } from '../resources/resource';
import * as $ from 'jquery';

@Component({
  selector: 'app-project-info',
  templateUrl: './project-info.component.html',
  styleUrls: ['./project-info.component.less'],
  encapsulation: ViewEncapsulation.None,
  providers:[HttpService]
})
export class ProjectInfoComponent implements OnInit {

  constructor(private route: ActivatedRoute,private http:HttpService) { };

  projectInfo : Project; 
  projectResources : Resource[];
  id : number;
  ngOnInit() {
    this.route.paramMap.subscribe(params=>{
      this.id = +params.get('this.id');
      this.http.getProjectInfo(this.id).subscribe((data:Project) => this.projectInfo=data);    
      $(document).ready(function(){
        $(".resTab").hide();
    });
  
    });    
  }
  
  getResources(){
    this.http.getAllResourcesById(this.id).subscribe((_data:Resource[])=> this.projectResources=_data );

    $(".resButton").click(function(){
      $( ".resTab" ).slideToggle("slow");        
    });}
}






