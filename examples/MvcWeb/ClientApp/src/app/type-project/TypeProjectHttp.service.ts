import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TypeProject } from './TypeProject';
import { Observable } from 'rxjs';
import { typeProjectUrl } from '../shared/api-endpoint.constants';

@Injectable()
export class TypeProjectHttp {
  constructor(private http: HttpClient) { }

  put(data: TypeProject): Observable<any> {
    return this.http.put(typeProjectUrl + '/' + data.id, data);
  }

  delete(projectTypeId: number): Observable<any> {
    return this.http.delete(typeProjectUrl + '/' + projectTypeId, { observe: "response" });
  }

  post(newTypeProject: TypeProject): Observable<any> {
    return this.http.post(typeProjectUrl, newTypeProject);
  }
}
