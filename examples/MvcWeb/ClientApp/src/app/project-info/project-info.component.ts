import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Project } from '../project/project';
import { Resource } from '../general-resources/resource-models/resource';
import { trigger, state, style } from '@angular/animations';
import { ResourceService } from '../resources-table/resource.service';
import { HttpService } from '../project/http.service';
import { ProjectParticipationService } from '../project-participants/project-participation.service';

@Component({
  selector: 'app-project-info',
  templateUrl: './project-info.component.html',
  styleUrls: ['./project-info.component.less'],
  encapsulation: ViewEncapsulation.None,
  animations: [
    trigger('openClose', [
      state('open', style({
        display: 'initial'
      })),
      state('closed', style({        
        display: 'none'      
      })),
    ]),
  ],
  providers: [HttpService, ProjectParticipationService]
})
export class ProjectInfoComponent implements OnInit {

  constructor(private route: ActivatedRoute, private http: HttpService,
              private resourceService: ResourceService, private participService:ProjectParticipationService) { }

  projectInfo: Project ;
  projectId: number;
  generateOnceResourcesTable = false;
  sortedResourcesByCategory: Resource[][] = [];
  isOpen = false;

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
    this.isOpen = !this.isOpen;
    this.generateOnceResourcesTable = true;   
  }

  onJoin(){
    this.participService.createParticipRequest(this.projectId);
  }
}

