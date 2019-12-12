import { __decorate } from "tslib";
import { Injectable } from '@angular/core';
import { baseUrl } from '../shared/api-endpoint.constants';
let HttpService = class HttpService {
    constructor(http) {
        this.http = http;
        this.url = baseUrl;
    }
    getAllProjects() {
        return this.http.get(this.url + 'projects');
    }
    getProjectInfo(id) {
        return this.http.get(this.url + 'projects' + '/' + id);
    }
    getResourcesByCategoryId(categoryId, pageNumber, recordsPerPage) {
        return this.http.get(this.url + 'resource/all/' + categoryId + '/' + pageNumber
            + '/' + recordsPerPage);
    }
    getResourceCategories(withAssignedResources) {
        return this.http.get(this.url + 'resource/categories' + '/' + withAssignedResources);
    }
    getResourcesCountByCategoryId(categoryId) {
        return this.http.get(this.url + 'resource/count' + '/' + categoryId);
    }
    getAllResourcesById(projectId) {
        return this.http.get(this.url + 'resource/all/' + projectId);
    }
    getPiranhaPageById(pageId) {
        return this.http.get(this.url + 'page/' + pageId);
    }
    createProject(project) {
        return this.http.post(this.url + 'projects' + '/' + 'create', project, { observe: 'response' });
    }
    updateProject(project) {
        return this.http.put(this.url + '/' + project.id, project, { observe: 'response' });
    }
    getAllProjectTypes() {
        return this.http.get(this.url + '/' + 'projectTypes');
    }
};
HttpService = __decorate([
    Injectable()
], HttpService);
export { HttpService };
//# sourceMappingURL=http.service.js.map