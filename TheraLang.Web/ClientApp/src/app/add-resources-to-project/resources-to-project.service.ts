import { Injectable } from '@angular/core';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { resourceUrl } from '../shared/api-endpoint.constants';
import { ResourceToProject } from './resource-to-project';
import { Resource } from '../general-resources/resource-models/resource';

@Injectable({
  providedIn: 'root'
})
export class ResourcesToProjectService {
  constructor(
    private http: HttpClient,
  ) { }

  post(newResourceToProject: ResourceToProject): Observable<any> {
    return this.http.post(resourceUrl + '/' + 'resourceToProject', newResourceToProject);
  }

  delete(resourceToProject: ResourceToProject): Observable<any> {
    const options = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
      }),
      body: {
        projectId: resourceToProject.projectId,
        resourceId: resourceToProject.resourceId,
      },
    };
    return this.http.delete(resourceUrl + '/' + 'resourceToProject' + '/' + resourceToProject.projectId, options);
  }

  getAllResourcesNotAttached(id: number) {
    const alldata = this.getAllResources(id).toPromise().then((data: Resource[]) => {
      return data;
    });
    return alldata;
  }

  getAllResources(id: number) {
    debugger
    return this.http.get(resourceUrl + '/' + 'allNotAttached' + '/' + id);
  }
}