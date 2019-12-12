import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { ProjectType } from './project-type.model';
import { Observable } from 'rxjs';
import { projectTypeUrl } from 'src/app/shared/api-endpoint.constants';

@Injectable()
export class ProjectTypeHttp {
    constructor(private http: HttpClient) { }

    getAllProjectTypes() {
        return this.http.get(projectTypeUrl + '/');
    }

    put(data: ProjectType): Observable<any> {
        const urlParams = new HttpParams().set("id", data.id.toString());
        return this.http.put(projectTypeUrl, data, { params: urlParams });
    }

    delete(projectTypeId: number): Observable<any> {
        return this.http.delete(projectTypeUrl + '/' + projectTypeId, { observe: "response" });
    }

    post(newProjectType: ProjectType): Observable<any> {
        return this.http.post(projectTypeUrl, newProjectType);
    }
}
