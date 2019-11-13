import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {SiteMap} from '../cms/models/site-map';
import {Observable} from 'rxjs';
import {Subscription} from 'rxjs/src/internal/Subscription';

@Injectable()
export class HttpService {

    constructor(private http: HttpClient) { }

     private url = 'https://localhost:5001/api/';

    getAllProjects() {
        return this.http.get(`${this.url}project`);
    }

    getProjectInfo(id: number) {
        return this.http.get(`${this.url}project/${id}`);
    }

    getAllProjectParticipants() {
        return this.http.get(`${this.url}projectParticipants`);
      }

    changeParticipationStatus(requestId: number, requestStatus: number) {
        return this.http.put(`${this.url}projectParticipants/requestId`, requestStatus);
    }

    getAllResourcesById(projectId: number) {
        return this.http.get(`${this.url}project/${projectId}/resources`);
    }

    getSiteMap(): Observable<SiteMap[]> {
        return this.http.get<SiteMap[]>(`${this.url}sitemap`);
    }
}
