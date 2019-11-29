import { __decorate } from "tslib";
import { Component, ViewChild } from '@angular/core';
import { MatTableDataSource, MatPaginator } from '@angular/material';
import { RequestStatus } from '../request-status-enum';
let ProjectParticipantsComponent = class ProjectParticipantsComponent {
    constructor(httpService, eventService) {
        this.httpService = httpService;
        this.eventService = eventService;
        this.projectParticipationRequest = new MatTableDataSource();
        this.showActionButtons = true;
        this.displayedColumns = ['createdById', 'role', 'projectId', 'status', 'actions'];
    }
    ngOnInit() {
        this.httpService.getAllProjectParticipants().subscribe((projectParticipants) => {
            this.projectParticipationRequest.data = projectParticipants;
            this.projectParticipationRequest.filterPredicate = (projectParticipant, filter) => projectParticipant.status.toString() == filter;
            this.projectParticipationRequest.paginator = this.paginator;
            this.projectParticipationRequest.filter = RequestStatus.New.toString();
        });
    }
    load() {
        this.httpService.getAllProjectParticipants().subscribe((projectParticipants) => {
            this.projectParticipationRequest.data = projectParticipants;
            this.removeNotificationIcon();
        });
    }
    changeTab(tabPosition) {
        this.projectParticipationRequest.filter = this.changeFilter(tabPosition);
        this.showActionButtons = (tabPosition === RequestStatus.New) ? true : false;
    }
    changeFilter(tabPosition) {
        if (tabPosition === 1) {
            return RequestStatus.Aproved.toString();
        }
        else if (tabPosition === 2) {
            return RequestStatus.Rejected.toString();
        }
        else {
            return RequestStatus.New.toString();
        }
    }
    changeStatus(status, projectParticipant) {
        projectParticipant.status = (status === 'aproved') ? RequestStatus.Aproved : RequestStatus.Rejected;
        this.httpService.changeParticipationStatus(projectParticipant.id, projectParticipant.status).subscribe(data => {
            this.load();
        });
    }
    removeNotificationIcon() {
        if (this.projectParticipationRequest.filteredData.length === 0) {
            this.eventService.emitChildEvent();
        }
    }
};
__decorate([
    ViewChild(MatPaginator, { static: true })
], ProjectParticipantsComponent.prototype, "paginator", void 0);
ProjectParticipantsComponent = __decorate([
    Component({
        selector: 'app-project-participants',
        templateUrl: './project-participants.component.html',
        styleUrls: ['./project-participants.component.less']
    })
], ProjectParticipantsComponent);
export { ProjectParticipantsComponent };
//# sourceMappingURL=project-participants.component.js.map