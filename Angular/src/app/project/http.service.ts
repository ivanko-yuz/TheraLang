import {Injectable, OnDestroy} from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable()
export class HttpService {
    private url = 'https://localhost:44353/api/';
    constructor(private http: HttpClient) { }

    getAllProjects() {
        return this.http.get(this.url + 'project');
    }
    getProjectInfo(id: number) {
        return this.http.get(this.url + 'project' + '/' + id);
    }
    getAllResourcesById(projectId: number) {
        return this.http.get(this.url + 'project' + '/' + projectId + '/' + 'resources');
    }
}
