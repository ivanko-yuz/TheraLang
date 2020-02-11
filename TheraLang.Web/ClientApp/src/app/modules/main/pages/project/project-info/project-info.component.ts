import { Component, OnInit, ViewEncapsulation } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { Project } from "../../../../../shared/models/project/project";
import { Resource } from "../../../../../shared/models/resource/resource";
import { trigger, state, style, transition, animate } from "@angular/animations";
import { HttpService } from "../../../../../core/http/http/http.service";
import { ProjectParticipationService } from "../../../../../core/http/project-participants/project-participation.service";
import { ResourceService } from "../../../../../core/http/resource/resource.service";
import { TranslateService } from "@ngx-translate/core";
import { NotificationService } from "src/app/core/services/notification/notification.service";
import { DialogService } from 'src/app/core/services/dialog/dialog.service';
import { ProjectService } from 'src/app/core/http/project/project.service';
import { UserService } from 'src/app/core/auth/user.service';

@Component({
  selector: "app-project-info",
  templateUrl: "./project-info.component.html",
  styleUrls: ["./project-info.component.less"],
  encapsulation: ViewEncapsulation.None,
  animations: [
    trigger("openCloseContent", [
      state(
        "open",
        style({
          opacity: 1
        })
      ),
      state(
        "closed",
        style({
          opacity: 0
        })
      ),
      transition('open => closed', animate('.5s')),
      transition('closed => open', animate('.9s'))
    ]),
    trigger("openCloseArrow", [
      state(
        "open",
        style({
          transform: 'rotate(-180deg)'
        })
      ),
      state(
        "closed",
        style({
          transform: 'rotate(0)'
        })
      ),
      transition('open => closed', animate('.5s')),
      transition('closed => open', animate('.5s'))
    ])
  ],
  providers: [HttpService, ProjectParticipationService]
})

export class ProjectInfoComponent implements OnInit {
  constructor(
    private route: ActivatedRoute,
    private http: HttpService,
    private resourceService: ResourceService,
    private participService: ProjectParticipationService,
    private notificationService: NotificationService,
    private translate: TranslateService,
    private dialogService: DialogService,
    private router: Router,
    private userService: UserService,
    public service: ProjectService
  ) { }

  projectInfo: Project;
  projectId: number;
  generateOnceResourcesTable = false;
  sortedResourcesByCategory: Resource[][] = [];
  isOpen = false;
  private arrowStyle: string;

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      this.projectId = +params.get("id");
      this.http
        .getProjectInfo(this.projectId)
        .subscribe((data: Project) => (this.projectInfo = data));
    });
  }

  async getResourcesData() {
    if (!this.generateOnceResourcesTable) {
      const allResources = await this.resourceService.getAllResourcesByProjId(
        this.projectId
      );
      this.sortedResourcesByCategory = this.resourceService.sortAllResourcesByCategories(
        allResources
      );
    }
    this.generateOnceResourcesTable = true;
  }

  onJoin() {
    this.participService.createParticipRequest(this.projectId).subscribe(
      async msg => {
        msg = await this.translate
          .get("common.messages.request-sent")
          .toPromise();
        this.notificationService.success(msg);
      },
      async error => {
        console.log(error);
        this.notificationService.warn(
          await this.translate
            .get("common.messages.cant-send-request")
            .toPromise()
        );
      }
    );
  }

  isAuthenticated() {
    return this.userService.isAuthenticated();
  }

  isAdmin() {
    return this.userService.isAdmin();
  }

  isMember() {
    return this.userService.isMember();
  }

  isOwner(){
    return this.userService.isAuthenticated();
  }
  
  getProjectProgress(project: Project) {
    return (project.donationsSum / project.donationTargetSum);
  }

  onEdit(project) {
    this.service.initializeFormGroup();
    this.service.populateForm(project);
    this.dialogService.openFormDialog(ProjectInfoComponent);
  }

  async onDelete(id) {
    this.dialogService
      .openConfirmDialog(
        await this.translate.get("common.r-u-sure").toPromise()
      )
      .afterClosed()
      .subscribe(async res => {
        if (res) {
          this.http.deleteProject(id).subscribe(result => {
            this.router.navigate(["/projects"]);
          });
          this.notificationService.warn(
            await this.translate.get("common.deleted-successfully").toPromise()
          );
        }
      });
  }

  arrowOpener(){
    if(this.arrowStyle == "rotator"){
      this.arrowStyle = "";
    }
    else{
      this.arrowStyle = "rotator";
    }
    this.isOpen = !this.isOpen;
  }
  getDetails(){
    this.getResourcesData();
    this.arrowOpener();

  }
}
