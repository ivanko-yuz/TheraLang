import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { SiteMap } from "../../../shared/models/site-map/site-map";
import { Observable, Subject } from "rxjs";
import { ToolbarItem } from "../../toolbar/cms-pages-toolbar-item/toolbar-item";
import { CmsRoute } from "../../toolbar/toolbar-item/cms-route";
import { cmsSitemapUrl } from "src/app/configs/api-endpoint.constants";

@Injectable({
  providedIn: "root"
})
export class SiteMapService {
  siteMap = new Subject<SiteMap[]>();
  toolbarItems = new Subject<ToolbarItem[]>();
  siteMapUpdating = false;

  constructor(private http: HttpClient) {
    this.updateToolbarItemsOnSubscription();
    this.updateSiteMap();
  }

  public getSiteMap(): Observable<SiteMap[]> {
    return this.http.get<SiteMap[]>(cmsSitemapUrl);
  }

  updateSiteMap(): void {
    if (this.siteMapUpdating) {
      return;
    } else {
      this.siteMapUpdating = true;
    }

    const subscription = this.getSiteMap().subscribe(
      next => {
        this.siteMap.next(next["pages"]);
        this.siteMapUpdating = false;
        subscription.unsubscribe();
      },
      error => {
        this.siteMap.error(error);
        this.siteMapUpdating = false;
        subscription.unsubscribe();
      }
    );
  }

  private updateToolbarItemsOnSubscription(): void {
    this.siteMap.subscribe(
      sitemap => {
        this.toolbarItems.next(this.mapToolbarItems(sitemap));
      },
      error => {
        this.toolbarItems.error(error);
      }
    );
  }

  private mapToolbarItems(siteMap: SiteMap[]): ToolbarItem[] {
    return siteMap.map(item => {
      const route = new CmsRoute(item.pageTypeName, item.id);
      return new ToolbarItem(
        item.permalink,
        route,
        item.menuTitle,
        this.mapToolbarItems(item.subPages)
      );
    });
  }
}
