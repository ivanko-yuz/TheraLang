import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {SiteMap} from '../models/site-map';
import {Observable, Subject} from 'rxjs';
import {ToolbarItem} from '../../toolbar/toolbar-item/toolbar-item';
import {environment} from '../../../environments/environment';
import {CmsRoute} from '../../toolbar/toolbar-item/cms-route';
import {cmsSitemapUrl} from '../../shared/api-endpoint.constants';

@Injectable({
  providedIn: 'root'
})
export class SiteMapService {

  siteMap = new Subject<SiteMap[]>();
  toolbarItems = new Subject<ToolbarItem[]>();

  constructor(private http: HttpClient) {
    this.updateToolbarItemsOnSubscription();
    this.updateSiteMap();
  }

  private getSiteMap(): Observable<SiteMap[]> {
    return this.http.get<SiteMap[]>(cmsSitemapUrl);
  }

  updateSiteMap(): void {
    const subscription = this.getSiteMap().subscribe(next => {
      this.siteMap.next(next);
      subscription.unsubscribe();
    }, error => {
      if (!environment.production) {
        console.log(error);
      }
      this.siteMap.error(error);
      subscription.unsubscribe();
    });
  }

  private updateToolbarItemsOnSubscription(): void {
    this.siteMap.subscribe(sitemap => {
      this.toolbarItems.next(this.mapToolbarItems(sitemap));
    }, error => {
      if (!environment.production) {
        console.log(error);
      }
      this.toolbarItems.error(error);
    });
  }

  private mapToolbarItems(siteMap: SiteMap[]): ToolbarItem[] {
    return siteMap.map(item => {
      const route = new CmsRoute(item.pageTypeName, item.id);
      return new ToolbarItem(item.permalink, route, item.menuTitle, this.mapToolbarItems(item.items));
    });
  }
}
