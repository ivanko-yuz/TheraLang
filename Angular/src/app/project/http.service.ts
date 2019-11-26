import { Injectable, OnDestroy } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Project } from './project';
import { baseUrl, projectUrl } from '../shared/api-endpoint.constants';


@Injectable()
export class HttpService {

    constructor(private http: HttpClient) { }

    private url = baseUrl;

    getAllProjects() {
        return this.http.get(`${projectUrl}`);
    }

    getProjectInfo(id: number) {
        return this.http.get(this.url + 'projects' + '/' + id);
    }

    getAllResourcesByProjectId(projectId: number) {
        return this.http.get(this.url + 'resource/all/' + projectId);
    }

    getResourcesByCategoryId(categoryId: number, pageNumber: number, recordsPerPage: number) {
        return this.http.get(this.url + 'resource/all/' + categoryId + '/' + pageNumber
            + '/' + recordsPerPage);
    }

    getResourceCategories(withAssignedResources: boolean) {
        return this.http.get(this.url + 'resource/categories' + '/' + withAssignedResources);
    }

    getResourcesCountByCategoryId(categoryId: number) {
        return this.http.get(this.url + 'resource/count' + '/' + categoryId);
    }


    createProject(project: Project) {
        return this.http.post(this.url, project);
    }

    updateProject(project: Project) {
        return this.http.put(this.url + '/' + project.id, project);
    }

}
