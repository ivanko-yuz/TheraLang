import { __decorate } from "tslib";
import { Injectable } from "@angular/core";
import { projectUrl } from "../shared/api-endpoint.constants";
let ProjectRequestService = class ProjectRequestService {
    constructor(http) {
        this.http = http;
        this.url = projectUrl;
    }
    getAllProjectParticipants() {
        return this.http.get(this.url);
    }
    StatusApprove(id) {
        return this.http.get(this.url + "/approve/" + id).subscribe();
    }
    StatusReject(id) {
        return this.http.get(this.url + "/reject/" + id).subscribe();
    }
};
ProjectRequestService = __decorate([
    Injectable({
        providedIn: "root"
    })
], ProjectRequestService);
export { ProjectRequestService };
//# sourceMappingURL=project-request.service.js.map