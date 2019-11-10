import * as tslib_1 from "tslib";
import { Injectable } from '@angular/core';
let HttpProjectService = class HttpProjectService {
    constructor(http) {
        this.http = http;
        this.url = "https://localhost:44353/api/project";
    }
    getAllProjects() {
        return this.http.get(this.url);
    }
    getProjectInfo(id) {
        return this.http.get(this.url + '/' + id);
    }
    getAllResourcesById(projectId) {
        return this.http.get(this.url + '/' + projectId + '/' + 'resources');
    }
    getAllResourcesWithoutId() {
        return this.http.get('resources');
    }
    createProject(project) {
        return this.http.post(this.url, project);
    }
    updateProject(project) {
        return this.http.put(this.url + '/' + project.id, project);
    }
};
HttpProjectService = tslib_1.__decorate([
    Injectable({
        providedIn: 'root'
    })
], HttpProjectService);
export { HttpProjectService };
//# sourceMappingURL=http-project.service.js.map