import { Resource } from './../resources-table/resource';
import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';

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

    getAllResourcesByIdNew(projectId: number): Observable<Resource[]> {
        return this.http.get<Resource[]>(this.url + 'project' + '/' + projectId + '/' + 'resources');
    }
    getAllResourcesById(projectId: number) {
        return this.http.get(this.url + 'project' + '/' + projectId + '/' + 'resources');
    }
    getAllResourcesWithoutId( ) {
        return this.http.get('resources');
    }
}
