import { __decorate } from "tslib";
import { Injectable } from "@angular/core";
import { projectUrl } from "../shared/api-endpoint.constants";
let HttpProjectService = class HttpProjectService {
    constructor(http) {
        this.http = http;
        this.url = projectUrl;
    }
    getAllProjectParticipants() {
        return this.http.get(this.url);
    }
    GetProjectsByStatus(status) {
        return this.http.get(this.url + "/newstatus/" + status);
    }
    Approve(id) {
        return this.http.get(this.url + "/approve/" + id);
    }
    Reject(id) {
        return this.http.get(this.url + "/reject/" + id);
    }
};
HttpProjectService = __decorate([
    Injectable()
], HttpProjectService);
export { HttpProjectService };
//# sourceMappingURL=http-project.service.js.map