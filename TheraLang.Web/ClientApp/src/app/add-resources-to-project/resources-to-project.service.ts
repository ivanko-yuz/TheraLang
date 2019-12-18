import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { resourсeUrl } from '../shared/api-endpoint.constants';
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
    return this.http.post(resourсeUrl + '/' + 'resourceToProject', newResourceToProject);
  }

  delete(resourceToProject: ResourceToProject): Observable<any> {
    const urlParams = new HttpParams().set("resId", resourceToProject.resourceId.toString());
    urlParams.set("projId", resourceToProject.projectId.toString());
    return this.http.delete(resourсeUrl + '/' + 'resourceToProject' + '/' + resourceToProject.resourceId, { params: urlParams });
  }

  getAllResourcess() {
    const alldata = this.getAllResources().toPromise().then((data: Resource[]) => {
      return data;
    });
    return alldata;
  }

  getAllResources() {
    return this.http.get(resourсeUrl + '/' + 'all');
  }
}
