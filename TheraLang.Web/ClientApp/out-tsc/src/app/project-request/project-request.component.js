import { __decorate } from "tslib";
import { Component } from "@angular/core";
import { ProjectStatusRequest } from "../shared/enums/project-status-request";
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
    changeStatus(status) {
        debugger;
        status === "approved"
            ? this.projectRequestService.StatusApprove(projectRequest.id, ProjectStatusRequest.Approved //todo: remove
            )
            : this.projectRequestService.StatusReject(projectRequest.id, ProjectStatusRequest.Rejected //todo: remove
            );
    }
    ngOnInit() {
        return this.http
            .getAllProjects()
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