import { Component, OnInit, AfterViewInit, OnDestroy } from "@angular/core";
import { ProjectParticipationRequest } from "src/app/shared/models/project-participation/project-participation-request";
import { ToolbarItem } from "./toolbar-item/toolbar-item";
import { Subscription } from "rxjs";
import { ProjectParticipationService } from "../http/project-participants/project-participation.service";
import { EventService } from "../services/event/event-service";
import { SiteMapService } from "../http/cms/site-map.service";
import { DialogService } from "../services/dialog/dialog.service";
import { UserService } from "../auth/user.service";
import { ProjectParticipationRequestStatus } from "src/app/configs/project-participation-request-status";
import { LoginComponent } from "../auth/login/login.component";

@Component({
  selector: "app-toolbar",
  templateUrl: "./toolbar.component.html",
  styleUrls: ["./toolbar.component.less"]
})
export class ToolbarComponent implements OnInit, AfterViewInit, OnDestroy {
  hasNotification: boolean = false;
  projectParticipation: ProjectParticipationRequest[];
  toolbarItems: ToolbarItem[] = [];
  private subscription = new Subscription();
  isAuthinticated: boolean;

  constructor(
    private participantService: ProjectParticipationService,
    private eventService: EventService,
    private siteMapService: SiteMapService,
    private dialog: DialogService,
    private userService: UserService
  ) {}

  ngOnInit() {
    this.subscribeOnSiteMapService();
    const subscription = this.participantService
      .getAllProjectParticipants()
      .subscribe((projectParticipation: ProjectParticipationRequest[]) => {
        this.projectParticipation = projectParticipation;
        if (
          this.projectParticipation.filter(
            x => x.status === ProjectParticipationRequestStatus.New
          ).length > 0
        ) {
          this.hasNotification = true;
        }
      });
    this.subscription.add(subscription);
    this.userService
      .isAuthenticated()
      .subscribe(
        (isAuthinticated: boolean) => (this.isAuthinticated = isAuthinticated)
      );
  }

  ngAfterViewInit(): void {
    this.eventService.childEventListner().subscribe(click => {
      this.hasNotification = false;
    });
  }

  subscribeOnSiteMapService(): void {
    const toolbarItemsSubscription = this.siteMapService.toolbarItems.subscribe(
      next => (this.toolbarItems = next),
      error => "do nothing for now"
    );
    this.subscription.add(toolbarItemsSubscription);
  }

  ngOnDestroy(): void {
    this.subscription.unsubscribe();
  }

  onLogin() {
    this.dialog.openFormDialog(LoginComponent);
  }
}
