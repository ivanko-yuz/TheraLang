import { Component, OnInit } from '@angular/core';
import {CmsRouteHelperService} from '../../services/cms-route-helper.service';
import {CmsRoute} from '../../../toolbar/toolbar-item/cms-route';
import {Subscription} from 'rxjs';
import {Router} from '@angular/router';

@Component({
  selector: 'app-cms-generic-page',
  templateUrl: './cms-generic-page.component.html',
  styleUrls: ['./cms-generic-page.component.less']
})
export class CmsGenericPageComponent implements OnInit {
  private cmsRoute: CmsRoute;
  private subscription = new Subscription();

  constructor(private cmsRouteHelperService: CmsRouteHelperService, private router: Router) {
    this.subscribeOnCmsRouteChange();
  }

  ngOnInit() {
    if (!this.cmsRoute) {
      this.cmsRouteHelperService.updateRouteByPath(this.router.url);
    }
  }

  subscribeOnCmsRouteChange(): void {
    const subscription = this.cmsRouteHelperService.currentRouteSubject.subscribe(next => {
      this.cmsRoute = next;
      console.log(next); // in order to show that it works // TODO: remove logging cmsRoute
    });
    this.subscription.add(subscription);
  }

}
