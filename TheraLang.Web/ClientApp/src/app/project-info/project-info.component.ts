import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Project } from '../project/project';
import { Resource } from '../general-resources/resource-models/resource';
import { trigger, state, style } from '@angular/animations';
import { HttpService } from '../project/http.service';
import { ProjectParticipationService } from '../project-participants/project-participation.service';
import { ResourceService } from './resources-table-for-project/resources-table/resource.service';
import { NotificationService } from '../shared/services/notification.service';
import { TranslateService } from '@ngx-translate/core';
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
    private translate: TranslateService,
    public dialog: MatDialog,
  ) { }

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
      async (msg) => {
        msg = await this.translate.get('common.messages.request-sent').toPromise();
        this.notificationService.success(msg);
      },
      async (error) => {
        console.log(error);
        this.notificationService.warn(await this.translate.get('common.messages.cant-send-request').toPromise());
      });
  }

  addResToProject() {
    let dialogRef = this.dialog.open(AddResourcesToProjectComponent, {
      width: '420px',
      height: '500px',
      data: { id: this.projectId },
    }).afterClosed().subscribe(res => { this.ngOnInit() });
  }
}

