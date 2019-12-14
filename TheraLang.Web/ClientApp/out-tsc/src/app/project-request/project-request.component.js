import { __decorate } from "tslib";
import { Component } from "@angular/core";
let ProjectRequestComponent = class ProjectRequestComponent {
    //   projectRequest = new MatTableDataSource<ProjectRequest>();
    //   showActionButtons: boolean = true;
    //   @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
    //   displayedColumns: string[] = [
    //     "createdById",
    //     "role",
    //     "projectId",
    //     "status",
    //     "actions"
    //   ];
    constructor(http, projectRequestService) {
        this.http = http;
        this.projectRequestService = projectRequestService;
    }
    changeStatus(status, project) {
        status === "approved"
            ? this.projectRequestService.StatusApprove(project.id)
            : this.projectRequestService.StatusReject(project.id);
    }
    ngOnInit() {
        return this.http
            .getAllNewProjects()
            .subscribe((projects) => (this.projects = projects));
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