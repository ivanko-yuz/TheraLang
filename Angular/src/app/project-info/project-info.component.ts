import { ResourceService } from '../resources-table/resource.service';
import { Component, OnInit, ViewEncapsulation, OnDestroy, AfterViewInit} from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HttpService } from '../project/http.service';
import { Project } from '../project/project';
import * as $ from 'jquery';
import { Resource } from '../resources-table/resource';

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

  projectInfo: Project= new Project(0,"","","");
  projectId: number;
  // projectResources: Resource[] = this.resourceService.allProjectResources;
  generateOnceResourcesTable: boolean = false; 
  resources:Resource[][]=[];

  ngAfterViewInit() {
    $("#resTabId").hide()
  }

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      this.projectId = +params.get('id');
      this.http.getProjectInfo(this.projectId).subscribe((data: Project) => this.projectInfo = data);
    });
  }

  async getResourcesData() {   
    if(!this.generateOnceResourcesTable){
      let resources = await this.resourceService.getAllResourcesByProjId(this.projectId);   
      this.resources = this.resourceService.sort(resources);
      //this.resourceService.getAllResourceCategories(); 
      // this.resourceService.getAallUniqueResourceCategories();
    }
    this.generateOnceResourcesTable = true;
    $('#resTabId').slideToggle('slow');

  }
}







