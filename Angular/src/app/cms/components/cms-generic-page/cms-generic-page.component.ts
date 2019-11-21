import { Component, OnInit } from '@angular/core';
import {CmsRouteHelperService} from '../../services/cms-route-helper.service';
import {CmsRoute} from '../../../toolbar/toolbar-item/cms-route';
import {Subscription} from 'rxjs';

@Component({
  selector: 'app-cms-generic-page',
  templateUrl: './cms-generic-page.component.html',
  styleUrls: ['./cms-generic-page.component.less']
})
export class CmsGenericPageComponent implements OnInit {
  private cmsRoute: CmsRoute;
  private subscription = new Subscription();

  constructor(private cmsRouteHelperService: CmsRouteHelperService) {
    this.subscribeOnCmsRouteChange();
  }

  ngOnInit() {
  }

  subscribeOnCmsRouteChange(): void {
    const subscription = this.cmsRouteHelperService.currentRouteSubject.subscribe(next => {
      this.cmsRoute = next;
      console.log(next); // in order to show that it works // TODO: remove logging cmsRoute
    });
    this.subscription.add(subscription);
  }

}
