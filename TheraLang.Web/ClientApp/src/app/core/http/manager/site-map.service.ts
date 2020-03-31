import {Injectable} from "@angular/core";
import {HttpClient} from "@angular/common/http";
import {SiteMap} from "../../../shared/models/site-map/site-map";
import {EMPTY, Observable, Subject} from "rxjs";
import {ToolbarItem} from "../../../modules/main/toolbar/cms-pages-toolbar-item/toolbar-item";
import {CmsRoute} from "../../../modules/main/toolbar/toolbar-item/cms-route";
import {cmsSitemapUrl} from "src/app/configs/api-endpoint.constants";
import {ChangedSiteMap} from "src/app/shared/models/site-map/changed-site-map";
import {TranslateService} from "@ngx-translate/core";
import {Language} from "../../../shared/models/language/languages.enum";

@Injectable({
  providedIn: "root",
})
export class SiteMapService {
  siteMap = new Subject<SiteMap[]>();
  toolbarItems = new Subject<ToolbarItem[]>();
  siteMapUpdating = false;
  changesToMake: Map<number, ChangedSiteMap>;

  constructor(private http: HttpClient,
              private translateService: TranslateService,
  ) {
    this.updateToolbarItemsOnSubscription();
    this.updateSiteMap();
    this.changesToMake = new Map<number, ChangedSiteMap>();
  }

  public addSiteMapChange(changed: ChangedSiteMap[]) {
    changed.forEach(val => {
      if (this.changesToMake.has(val.id)) {
        this.combineChanges(this.changesToMake.get(val.id), val);
      } else {
        this.changesToMake.set(val.id, val);
      }
    });
  }

  public getSiteMap(lang: Language = null): Observable<SiteMap[]> {
    return this.http.get<SiteMap[]>(`${cmsSitemapUrl}/${ lang || ""}`);
  }

  public updateSiteMapStructure(): Observable<any> {
    if (this.changesToMake.size > 0) {
      const data = [...this.changesToMake.values()];
      return this.http.put(cmsSitemapUrl, { siteMaps: data });
    }
    return EMPTY;
  }

  public tryRemoveFromChanges(pageId: number) {
    if (this.changesToMake.has(pageId)) {
      this.changesToMake.delete(pageId);
    }
  }

  updateSiteMap(): void {
    if (this.siteMapUpdating) {
      return;
    } else {
      this.siteMapUpdating = true;
    }

    const subscription = this.getSiteMap().subscribe(
      next => {
        this.siteMap.next(next.pages);
        this.siteMapUpdating = false;
        subscription.unsubscribe();
      },
      error => {
        this.siteMap.error(error);
        this.siteMapUpdating = false;
        subscription.unsubscribe();
      },
    );
  }

  private updateToolbarItemsOnSubscription(): void {
    this.siteMap.subscribe(
      sitemap => {
        this.toolbarItems.next(this.mapToolbarItems(sitemap));
      },
      error => {
        this.toolbarItems.error(error);
      },
    );
  }

  private mapToolbarItems(siteMap: SiteMap[]): ToolbarItem[] {
    return siteMap.map(item => {
      const route = new CmsRoute(item.route, item.id.toString());
      return new ToolbarItem(
        item.route,
        route,
        item.menuTitle,
        this.mapToolbarItems(item.subPages),
      );
    });
  }

  private combineChanges(oldEntry: ChangedSiteMap, newEntry: ChangedSiteMap) {
    oldEntry.newIndex = newEntry.newIndex || oldEntry.newIndex;
    oldEntry.newParentId = newEntry.newParentId || oldEntry.newParentId;
    oldEntry.prevParentId = newEntry.prevParentId || oldEntry.prevParentId;
  }
}
