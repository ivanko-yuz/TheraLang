import { __decorate } from "tslib";
import { Component } from '@angular/core';
import { Subscription } from 'rxjs';
let CmsGenericPageComponent = class CmsGenericPageComponent {
    constructor(cmsRouteHelperService, router) {
        this.cmsRouteHelperService = cmsRouteHelperService;
        this.router = router;
        this.subscription = new Subscription();
    }
    ngOnInit() {
        this.subscribeOnCmsRouteChange();
        if (!this.cmsRoute) {
            this.cmsRouteHelperService.updateRouteByPath(this.router.url);
        }
    }
    ngOnDestroy() {
        this.subscription.unsubscribe();
    }
    subscribeOnCmsRouteChange() {
        const subscription = this.cmsRouteHelperService.currentRouteSubject.subscribe(next => {
            this.cmsRoute = next;
        });
        this.subscription.add(subscription);
    }
};
CmsGenericPageComponent = __decorate([
    Component({
        selector: 'app-cms-generic-page',
        templateUrl: './cms-generic-page.component.html',
        styleUrls: ['./cms-generic-page.component.less']
    })
], CmsGenericPageComponent);
export { CmsGenericPageComponent };
//# sourceMappingURL=cms-generic-page.component.js.map