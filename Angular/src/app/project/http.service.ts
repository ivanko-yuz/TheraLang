import { Injectable, OnDestroy } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class HttpService {

    constructor(private http: HttpClient) { }

    private url = 'https://localhost:44353/api/';
    private piranhaApiUrl = 'http://localhost:5000/api/';

    getAllProjects() {
        return this.http.get(this.url + 'project');
    }

    getProjectInfo(id: number) {
        return this.http.get(this.url + 'project' + '/' + id);
    }

    getAllProjectParticipants() {
        return this.http.get(this.url + 'projectParticipants');
    }

    changeParticipationStatus(requestId: number, requestStatus: number) {
        return this.http.put(this.url + 'projectParticipants' + '/' + requestId, requestStatus);
    }

    getAllResourcesByProjectId(projectId: number) {
        return this.http.get(this.piranhaApiUrl + 'resource/all/' + projectId);
    }

    getResourcesByCategoryId(categoryId: number, pageNumber: number, recordsPerPage: number) {
        return this.http.get(this.piranhaApiUrl + 'resource/all/' + categoryId + '/' + pageNumber 
        + '/' + recordsPerPage);
    }

    getResourceCategories(withAssignedResources: boolean) {
        return this.http.get(this.piranhaApiUrl + 'resource/categories' + '/' + withAssignedResources);
    }

    getResourcesCountByCategoryId(categoryId: number)
    {
        return this.http.get(this.piranhaApiUrl + 'resource/count' + '/' + categoryId);
    }
}
