import {Component, OnInit, AfterViewInit, OnDestroy} from '@angular/core';
import { HttpService } from '../project/http.service';
import { ProjectParticipationRequest } from '../project-participants/project-participation-request';
import { EventService } from '../project-participants/event-service';
import { RequestStatus } from '../request-status-enum';
import {SiteMapService} from '../cms/services/site-map.service';
import {ToolbarItem} from './toolbar-item/toolbar-item';
import {Subscription} from 'rxjs';
import { EventService } from '../project-participants/event-service';
import { RequestStatus } from '../request-status.enum';
import { ProjectParticipantService } from '../project-participants/project-participant.service';


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

  constructor(
    private participantService: ProjectParticipantService,
    private eventService: EventService,
    private siteMapService: SiteMapService
  ) { }

  ngOnInit() {
    this.subscribeOnSiteMapService();
    const subscription =
      this.participantService.getAllProjectParticipants().subscribe((projectParticipation: ProjectParticipationRequest[]) => {
      this.projectParticipation = projectParticipation;
      if ((this.projectParticipation.filter(x => x.status === RequestStatus.New)).length > 0) {
        this.hasNotification = true;
      }
    });
    this.subscription.add(subscription);
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
}
