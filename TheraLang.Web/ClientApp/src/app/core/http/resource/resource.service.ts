import { Injectable } from "@angular/core";
import { Resource } from "../../../shared/models/resource/resource";
import { HttpService } from "../http/http.service";
import {HttpClient, HttpParams} from '@angular/common/http';
import { baseUrl, resourceUrl } from 'src/app/configs/api-endpoint.constants';
import { Observable } from 'rxjs';
import { ResourceCategory } from 'src/app/shared/models/resource/resource-category';
import {share} from "rxjs/operators";

@Injectable()
export class ResourceService {

  constructor(private http: HttpClient) { }

  getResource(id:number): Observable<Resource>{
    return this.http.get(`${resourceUrl}/${id}`) as Observable<Resource>;
  }

  getResourceCategories(projectId: number,includeEmpty: Boolean = false): Observable<ResourceCategory[]> {
    const params = new HttpParams()
      .set("includeEmpty",includeEmpty.toString());
    return this.http.get(`${resourceUrl}/categories/${projectId || ""}`,{params}) as Observable<ResourceCategory[]>
  }

  getRosourcesByCategory(categoryId: number, projectId: number, pageNumber: number, pageSize: number): Observable<Resource[]> {
    const params = new HttpParams()
      .set("pageNumber", pageNumber.toString())
      .set("pageSize", pageSize.toString());
    return this.http.get(`${resourceUrl}/category/${categoryId}/${projectId || ""}`, {params}) as Observable<Resource[]>
  }

  countTotalResources(categoryId: number = null, projectId: number = null): Observable<number> {
    let params = new HttpParams();
    if(categoryId !== null)
      params = params.set("categoryId", categoryId && categoryId.toString() || null);
    if(projectId !== null)
      params = params.set("projectId", projectId && projectId.toString() || null);
    return this.http.get(`${resourceUrl}/count/`, {params}) as Observable<number>;
  }

  postResource(resource: Resource) {
    const formData = new FormData();
    formData.append("name", resource.name);
    formData.append("description", resource.description);
    formData.append("categoryId", resource.categoryId.toString());
    if (resource.file) {
      formData.append("File", resource.file as File);
    } else {
      formData.append("url", resource.url);
    }
    return this.http.post(`${resourceUrl}/create`, formData);
  }

  updateResource(resource:Resource){
    return this.http.put(`${resourceUrl}/update/${resource.id}`,resource)
  }

  deleteResource(resourceId: number){
    return this.http.delete(`${resourceUrl}/delete/${resourceId}`)
  }
}
