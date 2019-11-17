import { ResourceService } from '../resources-table/resource.service';
import { Component, OnInit, ViewEncapsulation, AfterViewInit } from '@angular/core';
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

  projectInfo: Project;
  projectId: number;
  generateOnceResourcesTable = false;
  sortedResourcesByCategory: Resource[][] = [];

  ngAfterViewInit() {
    $('#resTabId').hide();
  }

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      this.projectId = +params.get('id');
      this.http.getProjectInfo(this.projectId).subscribe((data: Project) => this.projectInfo = data);
    });
  }
  
  async getResourcesData() {
    if (!this.generateOnceResourcesTable) {
      const allResources = await this.resourceService.getAllResourcesByProjId(this.projectId);
      this.sortedResourcesByCategory = this.resourceService.sortAllResourcesByCategories(allResources);
    }
    this.generateOnceResourcesTable = true;
    $('#resTabId').slideToggle('slow');
  }
}







