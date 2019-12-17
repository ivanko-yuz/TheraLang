import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { resourсeUrl } from '../shared/api-endpoint.constants';
import { ResourceToProject } from './resource-to-project';

@Injectable({
  providedIn: 'root'
})
export class AddResourcesToProjectService {
  constructor(
    private http: HttpClient,
  ) { }

  post(newResourceToProject: ResourceToProject): Observable<any> {
    return this.http.post(resourсeUrl + '/' + 'resourceToProject', newResourceToProject);
  }

  delete(newResourceToProjectId: number): Observable<any> {
    return this.http.delete(resourсeUrl + '/' + 'resourceToProject' + '/' + newResourceToProjectId, { observe: "response" });
  }
}
