import { Component, OnInit, ViewEncapsulation, ViewChild, AfterViewInit} from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Project } from '../project/project';
import { Resource } from '../resources/resource';
import * as $ from 'jquery';
import { HttpProjectService } from '../project/shared/http-project.service';

@Component({
  selector: 'app-project-info',
  templateUrl: './project-info.component.html',
  styleUrls: ['./project-info.component.less'],
  encapsulation: ViewEncapsulation.None,
  providers:[HttpProjectService]
})
export class ProjectInfoComponent implements OnInit {

  constructor(private route: ActivatedRoute,private http:HttpProjectService) { };

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






