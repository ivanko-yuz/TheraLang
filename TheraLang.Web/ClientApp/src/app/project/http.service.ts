import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Project } from './project';
import { baseUrl } from '../shared/api-endpoint.constants';
import { Page } from '../cms/models/page.model';

@Injectable()
export class HttpService {

    constructor(private http: HttpClient) { }

     private url = baseUrl;

    getAllProjects() {
        return this.http.get(this.url + 'projects');
    }

    getProjectInfo(id: number) {
        return this.http.get(this.url + 'projects' + '/' + id);
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

    getAllResourcesById(projectId: number) {
        return this.http.get(this.url + 'projects' + '/' + projectId + '/' + 'resources');
    }

    getPiranhaPageById(pageId: string) {
        return this.http.get(this.url + 'page/' + pageId);
    }

    createProject(project:Project) {
        return this.http.post(this.url + 'projects' + '/' + 'create', project, {observe: 'response'});
    }

    updateProject(project: Project) {
        return this.http.put(this.url + '/' + project.id, project, {observe: 'response'});
    }

    getAllProjectTypes(){
        return this.http.get(this.url + '/' + 'projectTypes');
       }

}
