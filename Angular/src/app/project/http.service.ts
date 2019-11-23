import { Injectable, OnDestroy } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Page } from '../cms-api/models/root-object.model';

@Injectable()
export class HttpService {

    constructor(private http: HttpClient) { }

    private url = "https://localhost:44353/api/";

    private piranhaApiUrl = "http://localhost:5000/api/"

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

    getAllResourcesById(projectId: number) {
        return this.http.get(this.url + 'project' + '/' + projectId + '/' + 'resources');
    }

    async getPiranhaPageById(pageId: string): Promise<Page> {
        const dataaa = await this.http.get(this.piranhaApiUrl + "page/" + pageId).toPromise().then((data: Page) => data)
        return dataaa;
    }

}
