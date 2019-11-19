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
        return this.http.get(this.url + 'project' + '/' + projectId + '/' + 'resources');
    }

    getAllResources(pageNumber: number, recordsPerPage: number) {
        return this.http.get(this.piranhaApiUrl + 'resource/all/' + pageNumber + '/' + recordsPerPage);
    }

    getCountAllResources(category: string) {
        return this.http.get<number>(this.piranhaApiUrl + 'resource/all/count' + '/' + category);
    }
}
