import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ProjectType } from './project-type.model';
import { Observable } from 'rxjs';
import { projectTypeUrl } from 'src/app/shared/api-endpoint.constants';

@Injectable()
export class ProjectTypeNewHttp {
    constructor(private http: HttpClient) { }

    getAllProjectTypes() {
        return this.http.get(projectTypeUrl + '/');
    }

    put(data: ProjectType): Observable<any> {
        return this.http.put(projectTypeUrl + '/' + data.id, data);
    }

    delete(projectTypeId: number): Observable<any> {
        return this.http.delete(projectTypeUrl + '/' + projectTypeId, { observe: "response" });
    }

    post(newProjectType: ProjectType): Observable<any> {
        return this.http.post(projectTypeUrl, newProjectType);
    }
}
