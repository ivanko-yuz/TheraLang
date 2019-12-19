import {AfterViewInit, Component, OnDestroy, OnInit} from '@angular/core';
import {ProjectParticipationRequest} from '../project-participants/project-participation-request';
import {EventService} from '../project-participants/event-service';
import {SiteMapService} from '../cms/services/site-map.service';
import {ToolbarItem} from './toolbar-item/toolbar-item';
import {Subscription} from 'rxjs';
import {ProjectParticipationService} from '../project-participants/project-participation.service';
import {ProjectParticipationRequestStatus} from '../shared/enums/project-participation-request-status';
import {DialogService} from '../shared/services/dialog.service';
import {LoginComponent} from '../user/login/login.component';
import {UserService} from '../user/user.service';
import {PermissionsService} from './Permissions/permissions.service';
import {Permissions} from './Permissions/permissions.enum';


@Component({
  selector: 'app-toolbar',
  templateUrl: './toolbar.component.html',
  styleUrls: ['./toolbar.component.less']
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
    private userService: UserService,
    private role: PermissionsService
  ) { }

  ngOnInit() {
    this.subscribeOnSiteMapService();
    const subscription =
      this.participantService.getAllProjectParticipants().subscribe((projectParticipation: ProjectParticipationRequest[]) => {
      this.projectParticipation = projectParticipation;
      if ((this.projectParticipation.filter(x => x.status === ProjectParticipationRequestStatus.New)).length > 0) {
        this.hasNotification = true;
      }
    });
    this.subscription.add(subscription);
    this.userService.isAuthenticated().subscribe((isAuthinticated: boolean) => (this.isAuthinticated = isAuthinticated));
  }


  ngAfterViewInit(): void {
    this.eventService.childEventListner().subscribe(click => {
      this.hasNotification = false;
    });
  }

  subscribeOnSiteMapService(): void {
    const toolbarItemsSubscription =
      this.siteMapService.toolbarItems.subscribe(
        next => this.toolbarItems = next
        ,
        error => 'do nothing for now'
      );
    this.subscription.add(toolbarItemsSubscription);
  }

  ngOnDestroy(): void {
      this.subscription.unsubscribe();
  }

  onLogin(){
   this.dialog.openFormDialog(LoginComponent);
  }

  isRoleMaster(): boolean {
    return this.role.role < Permissions.Slave;
  }

  isRoleAdmin(): boolean {
    return this.role.role < Permissions.Master;
  }
}
