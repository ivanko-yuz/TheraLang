import { __decorate } from "tslib";
import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { ToolbarItem } from '../../toolbar/toolbar-item/toolbar-item';
import { CmsRoute } from '../../toolbar/toolbar-item/cms-route';
import { cmsSitemapUrl } from '../../shared/api-endpoint.constants';
let SiteMapService = class SiteMapService {
    constructor(http) {
        this.http = http;
        this.siteMap = new Subject();
        this.toolbarItems = new Subject();
        this.siteMapUpdating = false;
        this.updateToolbarItemsOnSubscription();
        this.updateSiteMap();
    }
    getSiteMap() {
        return this.http.get(cmsSitemapUrl);
    }
    updateSiteMap() {
        if (this.siteMapUpdating) {
            return;
        }
        else {
            this.siteMapUpdating = true;
        }
        const subscription = this.getSiteMap().subscribe(next => {
            this.siteMap.next(next);
            this.siteMapUpdating = false;
            subscription.unsubscribe();
        }, error => {
            this.siteMap.error(error);
            this.siteMapUpdating = false;
            subscription.unsubscribe();
        });
    }
    updateToolbarItemsOnSubscription() {
        this.siteMap.subscribe(sitemap => {
            this.toolbarItems.next(this.mapToolbarItems(sitemap));
        }, error => {
            this.toolbarItems.error(error);
        });
    }
    mapToolbarItems(siteMap) {
        return siteMap.map(item => {
            const route = new CmsRoute(item.pageTypeName, item.id);
            return new ToolbarItem(item.permalink, route, item.menuTitle, this.mapToolbarItems(item.items));
        });
    }
};
SiteMapService = __decorate([
    Injectable({
        providedIn: 'root'
    })
], SiteMapService);
export { SiteMapService };
//# sourceMappingURL=site-map.service.js.map