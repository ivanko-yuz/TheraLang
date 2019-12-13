import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Project } from '../project/project';
import { Resource } from '../general-resources/resource-models/resource';
import { trigger, state, style } from '@angular/animations';
import { HttpService } from '../project/http.service';
import { ProjectParticipationService } from '../project-participants/project-participation.service';
import { ResourceService } from './resources-table-for-project/resources-table/resource.service';
import { NotificationService } from '../shared/services/notification.service';
import { MatDialog } from '@angular/material';
import { AddResourcesToProjectComponent } from '../add-resources-to-project/add-resources-to-project.component';

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
    private resourceService: ResourceService,
    private participService: ProjectParticipationService,
    private notificationService: NotificationService,
    public dialog: MatDialog, ) { }

  projectInfo: Project;
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

  onJoin() {
    this.participService.createParticipRequest(this.projectId).subscribe(
      (res) => {
        if (res.ok) {
          this.notificationService.success('Заявку надіслано')
        }
      },
      (error) => {
        console.log(error);
        this.notificationService.warn('Неможливо надіслати заявку')
      });;
  }

  addResToProject() {
    let dialogRef = this.dialog.open(AddResourcesToProjectComponent, {
      width: '250px',
      // data: { name: projectType.typeName, id: projectType.id }
    }).afterClosed().subscribe(res => { this.ngOnInit() });
  }
}

