import { __decorate } from "tslib";
import { Component } from '@angular/core';
import { HttpService } from '../project/http.service';
import { RequestStatus } from '../request-status-enum';
import { Subscription } from 'rxjs';
let ToolbarComponent = class ToolbarComponent {
    constructor(httpService, evtSvc, siteMapService) {
        this.httpService = httpService;
        this.evtSvc = evtSvc;
        this.siteMapService = siteMapService;
        this.hasNotification = true;
        this.toolbarItems = [];
        this.subscription = new Subscription();
    }
    ngOnInit() {
        this.subscribeOnSiteMapService();
        const subscription = this.httpService.getAllProjectParticipants().subscribe((data) => {
            this.projectParticipation = data;
            if ((this.projectParticipation.filter(x => x.status === RequestStatus.New)).length === 0) {
                this.hasNotification = false;
            }
        });
        this.subscription.add(subscription);
    }
    ngAfterViewInit() {
        this.evtSvc.childEventListner().subscribe(info => {
            this.hasNotification = false;
        });
    }
    subscribeOnSiteMapService() {
        const toolbarItemsSubscription = this.siteMapService.toolbarItems.subscribe(next => this.toolbarItems = next, error => 'do nothing for now');
        this.subscription.add(toolbarItemsSubscription);
    }
    ngOnDestroy() {
        this.subscription.unsubscribe();
    }
};
ToolbarComponent = __decorate([
    Component({
        selector: 'app-toolbar',
        templateUrl: './toolbar.component.html',
        styleUrls: ['./toolbar.component.less'],
        providers: [HttpService]
    })
], ToolbarComponent);
export { ToolbarComponent };
//# sourceMappingURL=toolbar.component.js.map