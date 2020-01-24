import { Component, OnInit, ViewEncapsulation } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { Project } from "../../../../../shared/models/project/project";
import { Resource } from "../../../../../shared/models/resource/resource";
import { trigger, state, style } from "@angular/animations";
import { HttpService } from "../../../../../core/http/http/http.service";
import { ProjectParticipationService } from "../../../../../core/http/project-participants/project-participation.service";
import { ResourceService } from "../../../../../core/http/resource/resource.service";
import { TranslateService } from "@ngx-translate/core";
import { NotificationService } from "src/app/core/services/notification/notification.service";

@Component({
  selector: "app-project-info",
  templateUrl: "./project-info.component.html",
  styleUrls: ["./project-info.component.less"],
  encapsulation: ViewEncapsulation.None,
  animations: [
    trigger("openClose", [
      state(
        "open",
        style({
          display: "initial"
        })
      ),
      state(
        "closed",
        style({
          display: "none"
        })
      )
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
    private translate: TranslateService
  ) {}

  projectInfo: Project;
  projectId: number;
  generateOnceResourcesTable = false;
  sortedResourcesByCategory: Resource[][] = [];
  isOpen = false;

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
    this.isOpen = !this.isOpen;
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
}
