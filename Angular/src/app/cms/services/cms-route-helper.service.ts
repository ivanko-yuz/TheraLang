import { Injectable } from '@angular/core';
import {SiteMapService} from './site-map.service';
import {Subject, Subscription} from 'rxjs';
import {CmsRoute} from '../../toolbar/toolbar-item/cms-route';
import {ToolbarItem} from '../../toolbar/toolbar-item/toolbar-item';

@Injectable({
  providedIn: 'root'
})
export class CmsRouteHelperService {

  public currentRoute: CmsRoute;
  public currentRouteSubject = new Subject<CmsRoute>();
  private siteSlugMap: Map<string, CmsRoute>;
  private subscription = new Subscription();

  constructor(private siteMapService: SiteMapService) {
    this.subscribeOnToolbarItems();
    this.subscribeRoute();
  }

  private subscribeOnToolbarItems(): void {
    const subscription = this.siteMapService.toolbarItems.subscribe(next => {
      this.siteSlugMap = this.createSiteSlugMap(next);
    });
    this.subscription.add(subscription);
  }

  private subscribeRoute(): void {
    const subscription = this.currentRouteSubject.subscribe(next => {
      this.currentRoute = next;
    });
    this.subscription.add(subscription);
  }

  public updateRouteByPath(path: string): void {
    const nextRoute = this.siteSlugMap.get(path);
    if (nextRoute) {
      this.currentRouteSubject.next(this.siteSlugMap.get(path));
    } else {
      this.currentRouteSubject.error('no routes found');
    }
  }

  public updateRoute(cmsRoute: CmsRoute): void {
    this.currentRouteSubject.next(cmsRoute);
  }

  private createSiteSlugMap(toolbarItems: ToolbarItem[]): Map<string, CmsRoute> {
    const map = new Map<string, CmsRoute>();
    toolbarItems.forEach(item => {
      this.createSiteSlugMap(item.subItems)
        .forEach((value, key) => map.set(key, value));
      map.set(item.permalink, item.cmsRoute);
    });
    return map;
  }
}
