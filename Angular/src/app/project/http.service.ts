import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable()
export class HttpService {

    constructor(private http: HttpClient) { }

     private url = 'https://localhost:44353/api/';

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
}
