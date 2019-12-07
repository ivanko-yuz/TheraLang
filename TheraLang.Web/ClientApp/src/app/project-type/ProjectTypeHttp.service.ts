import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ProjectType } from './ProjectType';
import { Observable } from 'rxjs';
import { projectType } from '../shared/api-endpoint.constants';

@Injectable()
export class ProjectTypeHttp {
  constructor(private http: HttpClient) { }

  put(data: ProjectType): Observable<any> {
    return this.http.put(projectType + '/' + data.id, data);
  }

  delete(projectTypeId: number): Observable<any> {
    return this.http.delete(projectType + '/' + projectTypeId, { observe: "response" });
  }

  post(newProjectType: ProjectType): Observable<any> {
    return this.http.post(projectType, newProjectType);
  }
}
