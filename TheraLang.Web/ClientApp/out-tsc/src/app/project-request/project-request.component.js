import { __decorate } from "tslib";
import { Component } from "@angular/core";
import { ProjectStatusRequest } from "../shared/enums/project-status-request";
let ProjectRequestComponent = class ProjectRequestComponent {
    constructor(http, projectRequestService) {
        this.http = http;
        this.projectRequestService = projectRequestService;
    }
    changeStatus(status, project) {
        status === "approved"
            ? this.projectRequestService.Approve(project.id).subscribe(data => this.loadNewProjects())
            : this.projectRequestService.Reject(project.id).subscribe(data => this.loadNewProjects());
    }
    ngOnInit() {
        return this.http
            .getAllNewProjects()
            .subscribe((projects) => (this.projects = projects));
    }
    loadNewProjects() {
        this.http.getAllNewProjects().subscribe((projects) => {
            this.projects = projects;
        });
    }
    changeTab(tabPosition) {
        if (tabPosition === 1) {
            return this.projectRequestService
                .GetProjectsByStatus(ProjectStatusRequest.Approved)
                .subscribe((projects) => (this.projects = projects));
        }
        else if (tabPosition === 2) {
            return this.projectRequestService
                .GetProjectsByStatus(ProjectStatusRequest.Rejected)
                .subscribe((projects) => (this.projects = projects));
        }
        else {
            return this.http
                .getAllNewProjects()
                .subscribe((projects) => (this.projects = projects));
        }
    }
};
ProjectRequestComponent = __decorate([
    Component({
        selector: "app-project-request",
        templateUrl: "./project-request.component.html",
        styleUrls: ["./project-request.component.less"]
    })
], ProjectRequestComponent);
export { ProjectRequestComponent };
//# sourceMappingURL=project-request.component.js.map