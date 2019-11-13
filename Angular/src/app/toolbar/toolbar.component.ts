import {Component, OnInit, AfterViewInit, OnDestroy} from '@angular/core';
import { HttpService } from '../project/http.service';
import { ProjectParticipationRequest } from '../project-participants/project-participation-request';
import { EventService } from '../project-participants/event-service';
import { RequestStatus } from '../request-status-enum';
import {SiteMapService} from '../cms/services/site-map.service';
import {ToolbarItem} from './toolbar-item/toolbar-item';
import {Subject, Subscription} from 'rxjs';
import {SiteMap} from '../cms/models/site-map';

@Component({
  selector: 'app-toolbar',
  templateUrl: './toolbar.component.html',
  styleUrls: ['./toolbar.component.less'],
  providers: [HttpService]
})
export class ToolbarComponent implements OnInit, AfterViewInit, OnDestroy {

  hasNotification = true;
  projectParticipation: ProjectParticipationRequest[];
  toolbarItems: ToolbarItem[] = [];
  private subscription = new Subscription();

  constructor(private httpService: HttpService, private evtSvc: EventService, private siteMapService: SiteMapService) { }

  ngOnInit() {
    this.subscribeOnSiteMapService();
    this.subscribeOnProjectParticipants();
  }

  ngAfterViewInit(): void {
    this.evtSvc.childEventListner().subscribe(info => {
      this.hasNotification = false;
    });
  }

  subscribeOnProjectParticipants(): void {
    const subscription =
      this.httpService.getAllProjectParticipants().subscribe((data: ProjectParticipationRequest[]) => {
        this.projectParticipation = data;
        if ((this.projectParticipation.filter(x => x.status === RequestStatus.New)).length === 0) {
          this.hasNotification = false;
        }
      });
    this.subscription.add(subscription);
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
