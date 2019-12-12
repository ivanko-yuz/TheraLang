import { __decorate } from "tslib";
import { Component } from '@angular/core';
import { Subscription } from 'rxjs';
import { ProjectParticipationRequestStatus } from '../shared/enums/project-participation-request-status';
let ToolbarComponent = class ToolbarComponent {
    constructor(participantService, eventService, siteMapService) {
        this.participantService = participantService;
        this.eventService = eventService;
        this.siteMapService = siteMapService;
        this.hasNotification = false;
        this.toolbarItems = [];
        this.subscription = new Subscription();
    }
    ngOnInit() {
        this.subscribeOnSiteMapService();
        const subscription = this.participantService.getAllProjectParticipants().subscribe((projectParticipation) => {
            this.projectParticipation = projectParticipation;
            if ((this.projectParticipation.filter(x => x.status === ProjectParticipationRequestStatus.New)).length > 0) {
                this.hasNotification = true;
            }
        });
        this.subscription.add(subscription);
    }
    ngAfterViewInit() {
        this.eventService.childEventListner().subscribe(click => {
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
        styleUrls: ['./toolbar.component.less']
    })
], ToolbarComponent);
export { ToolbarComponent };
//# sourceMappingURL=toolbar.component.js.map