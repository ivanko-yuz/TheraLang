import { __decorate } from "tslib";
import { Component, ViewChild } from '@angular/core';
import { MatTableDataSource, MatPaginator } from '@angular/material';
import { ProjectParticipationRequestStatus } from '../shared/enums/project-participation-request-status';
let ProjectParticipantsComponent = class ProjectParticipantsComponent {
    constructor(participantService, eventService) {
        this.participantService = participantService;
        this.eventService = eventService;
        this.projectParticipationRequest = new MatTableDataSource();
        this.showActionButtons = true;
        this.displayedColumns = ['createdById', 'role', 'projectId', 'status', 'actions'];
    }
    ngOnInit() {
        this.participantService.getAllProjectParticipants().subscribe((projectParticipants) => {
            this.projectParticipationRequest.data = projectParticipants;
            this.projectParticipationRequest.filterPredicate = (projectParticipant, filter) => projectParticipant.status.toString() === filter;
            this.projectParticipationRequest.paginator = this.paginator;
            this.projectParticipationRequest.filter = ProjectParticipationRequestStatus.New.toString();
        });
    }
    loadPatricipants() {
        this.participantService.getAllProjectParticipants().subscribe((projectParticipants) => {
            this.projectParticipationRequest.data = projectParticipants;
            this.removeNotificationIcon();
        });
    }
    changeTab(tabPosition) {
        this.projectParticipationRequest.filter = this.changeFilter(tabPosition);
        this.showActionButtons = (tabPosition === ProjectParticipationRequestStatus.New) ? true : false;
    }
    changeFilter(tabPosition) {
        if (tabPosition === 1) {
            return ProjectParticipationRequestStatus.Approved.toString();
        }
        else if (tabPosition === 2) {
            return ProjectParticipationRequestStatus.Rejected.toString();
        }
        else {
            return ProjectParticipationRequestStatus.New.toString();
        }
    }
    changeStatus(status, projectParticipant) {
        projectParticipant.status = (status === 'approved') ? ProjectParticipationRequestStatus.Approved : ProjectParticipationRequestStatus.Rejected;
        this.participantService.changeParticipationStatus(projectParticipant.id, projectParticipant.status).subscribe(data => {
            this.loadPatricipants();
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