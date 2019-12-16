import { __decorate } from "tslib";
import { Injectable } from "@angular/core";
import { participationUrl } from "../shared/api-endpoint.constants";
let ProjectParticipationService = class ProjectParticipationService {
    constructor(http) {
        this.http = http;
        this.url = participationUrl;
    }
    getAllProjectParticipants() {
        return this.http.get(this.url);
    }
    changeParticipationStatus(requestId, requestStatus) {
        return this.http.put(this.url + "/" + requestId, requestStatus);
    }
    createParticipRequest(projectId) {
        return this.http.post(this.url + "/" + "create", projectId, {
            observe: "response"
        });
    }
};
ProjectParticipationService = __decorate([
    Injectable({
        providedIn: "root"
    })
], ProjectParticipationService);
export { ProjectParticipationService };
//# sourceMappingURL=project-participation.service.js.map