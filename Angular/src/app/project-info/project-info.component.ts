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

  ngOnInit() {
    this.route.paramMap.subscribe(params=>{
      let id = +params.get('id');
      this.http.getProjectInfo(id).subscribe((data:Project) => this.projectInfo=data);

      this.http.getAllResourcesById(id).subscribe((_data:Resource[])=> this.projectResources=_data );

      $(document).ready(function(){
        $(".resTab").hide();
    });
      $(".resButton").click(function(){
        $( ".resTab" ).slideToggle("slow");
      });
    });

  }
}






