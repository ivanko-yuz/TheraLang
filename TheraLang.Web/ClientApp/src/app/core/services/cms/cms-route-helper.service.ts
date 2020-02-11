import { Injectable } from "@angular/core";
import { SiteMapService } from "../../http/manager/site-map.service";
import { Subject, Subscription } from "rxjs";
import { CmsRoute } from "../../../modules/main/toolbar/toolbar-item/cms-route";
import { ToolbarItem } from "../../../modules/main/toolbar/cms-pages-toolbar-item/toolbar-item";

@Injectable({
  providedIn: "root"
})
export class CmsRouteHelperService {
  public currentRoute: CmsRoute;
  public currentRouteSubject = new Subject<CmsRoute>();
  private siteSlugMap: Map<string, CmsRoute>;
  private siteSlugMapSubject = new Subject<Map<string, CmsRoute>>();
  private subscription = new Subscription();

  constructor(private siteMapService: SiteMapService) {
    this.subscribeOnToolbarItems();
    this.subscribeRoute();
    this.subscribeSiteSlugMap();
  }

  private subscribeOnToolbarItems(): void {
    const subscription = this.siteMapService.toolbarItems.subscribe(next => {
      this.siteSlugMapSubject.next(this.createSiteSlugMap(next));
    });
    this.subscription.add(subscription);
  }

  private subscribeRoute(): void {
    const subscription = this.currentRouteSubject.subscribe(next => {
      this.currentRoute = next;
    });
    this.subscription.add(subscription);
  }

  private subscribeSiteSlugMap(): void {
    const subscription = this.siteSlugMapSubject.subscribe(next => {
      this.siteSlugMap = next;
    });
    this.subscription.add(subscription);
  }

  private getRouteByPathAndUpdate(
    siteSlugMap: Map<string, CmsRoute>,
    path: string
  ): void {
    const nextRoute = siteSlugMap.get(path);
    if (nextRoute) {
      this.currentRouteSubject.next(nextRoute);
    } else {
      this.currentRouteSubject.error("no routes found");
    }
  }

  public updateRouteByPath(path: string): void {
    if (this.siteMapService.siteMapUpdating || !this.siteSlugMap) {
      this.siteSlugMapSubject.subscribe(next =>
        this.getRouteByPathAndUpdate(next, path)
      );
    } else {
      this.getRouteByPathAndUpdate(this.siteSlugMap, path);
    }
  }

  public updateRoute(cmsRoute: CmsRoute): void {
    this.currentRouteSubject.next(cmsRoute);
  }

  private createSiteSlugMap(
    toolbarItems: ToolbarItem[]
  ): Map<string, CmsRoute> {
    const map = new Map<string, CmsRoute>();
    toolbarItems.forEach(item => {
      this.createSiteSlugMap(item.subItems).forEach((value, key) =>
        map.set(key, value)
      );
      map.set(item.permalink, item.cmsRoute);
    });
    return map;
  }
}
