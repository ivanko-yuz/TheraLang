import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ProjectType } from './ProjectType';
import { Observable } from 'rxjs';
import { projectTypeUrl } from '../shared/api-endpoint.constants';

@Injectable()
export class ProjectTypeHttp {
  constructor(private http: HttpClient) { }

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
