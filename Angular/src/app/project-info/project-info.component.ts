import { ResourceService } from '../resources-table/resource.service';
import { Component, OnInit, ViewEncapsulation, OnDestroy, AfterViewInit} from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HttpService } from '../project/http.service';
import { Project } from '../project/project';
import * as $ from 'jquery';

@Component({
  selector: 'app-project-info',
  templateUrl: './project-info.component.html',
  styleUrls: ['./project-info.component.less'],
  encapsulation: ViewEncapsulation.None,
  providers: [HttpService]
})
export class ProjectInfoComponent implements OnInit, AfterViewInit {

  constructor(private route: ActivatedRoute, private http: HttpService,
    private resourceService: ResourceService) { }

  projectInfo: Project;  
  projectId: number;
  // projectResources: Resource[] = this.resourceService.allProjectResources;
  generateOnceResourcesTable: boolean = false; 

  ngAfterViewInit() {
    $("#resTabId").hide()
  }

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      this.projectId = +params.get('id');
      this.http.getProjectInfo(this.projectId).subscribe((data: Project) => this.projectInfo = data);
    });
  }

  getResourcesData() {   
    if(!this.generateOnceResourcesTable){
    this.resourceService.getAllResourcesByProjId(this.projectId); 
    this.resourceService.getAllResourceCategories(); 
    this.resourceService.getAallUniqueResourceCategories();    
    }
    this.generateOnceResourcesTable = true;
    $('#resTabId').slideToggle('slow');

  }
}







