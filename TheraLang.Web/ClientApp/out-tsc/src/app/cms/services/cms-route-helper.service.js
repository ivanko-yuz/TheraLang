import { __decorate } from "tslib";
import { Injectable } from '@angular/core';
import { Subject, Subscription } from 'rxjs';
let CmsRouteHelperService = class CmsRouteHelperService {
    constructor(siteMapService) {
        this.siteMapService = siteMapService;
        this.currentRouteSubject = new Subject();
        this.siteSlugMapSubject = new Subject();
        this.subscription = new Subscription();
        this.subscribeOnToolbarItems();
        this.subscribeRoute();
        this.subscribeSiteSlugMap();
    }
    subscribeOnToolbarItems() {
        const subscription = this.siteMapService.toolbarItems.subscribe(next => {
            this.siteSlugMapSubject.next(this.createSiteSlugMap(next));
        });
        this.subscription.add(subscription);
    }
    subscribeRoute() {
        const subscription = this.currentRouteSubject.subscribe(next => {
            this.currentRoute = next;
        });
        this.subscription.add(subscription);
    }
    subscribeSiteSlugMap() {
        const subscription = this.siteSlugMapSubject.subscribe(next => {
            this.siteSlugMap = next;
        });
        this.subscription.add(subscription);
    }
    getRouteByPathAndUpdate(siteSlugMap, path) {
        const nextRoute = siteSlugMap.get(path);
        if (nextRoute) {
            this.currentRouteSubject.next(nextRoute);
        }
        else {
            this.currentRouteSubject.error('no routes found');
        }
    }
    updateRouteByPath(path) {
        if (this.siteMapService.siteMapUpdating || !this.siteSlugMap) {
            this.siteSlugMapSubject.subscribe(next => this.getRouteByPathAndUpdate(next, path));
        }
        else {
            this.getRouteByPathAndUpdate(this.siteSlugMap, path);
        }
    }
    updateRoute(cmsRoute) {
        this.currentRouteSubject.next(cmsRoute);
    }
    createSiteSlugMap(toolbarItems) {
        const map = new Map();
        toolbarItems.forEach(item => {
            this.createSiteSlugMap(item.subItems)
                .forEach((value, key) => map.set(key, value));
            map.set(item.permalink, item.cmsRoute);
        });
        return map;
    }
};
CmsRouteHelperService = __decorate([
    Injectable({
        providedIn: 'root'
    })
], CmsRouteHelperService);
export { CmsRouteHelperService };
//# sourceMappingURL=cms-route-helper.service.js.map