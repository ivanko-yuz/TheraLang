import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { baseUrl,projectUrl,resourceUrl,projectTypeUrl } from "src/app/configs/api-endpoint.constants";
@Injectable()
export class HttpService {
  constructor(private http: HttpClient) {}

  private url = baseUrl;

  getAllProjects() {
    return this.http.get(`${projectUrl}`);
  }
  getAllProjectsFiltered(query:string) {
    return this.http.get(`${projectUrl}${query}`);
  }

  getProjectInfo(id: number) {
    return this.http.get(`${projectUrl}/${id}`);
  }

  getResourcesByCategoryId(categoryId: number, pageNumber: number, recordsPerPage: number) {
    return this.http.get(`${resourceUrl}/all/${categoryId}/${pageNumber}/${recordsPerPage}`);
  }

  getResourceCategories(withAssignedResources: boolean) {
    return this.http.get(`${resourceUrl}/categories/${withAssignedResources}`);
  }

  getResourcesCountByCategoryId(categoryId: number) {
    return this.http.get(`${resourceUrl}/count/${categoryId}`);
  }

  getAllResourcesById(projectId: number) {
    return this.http.get(`${resourceUrl}/all/${projectId}`);
  }

  getAllProjectTypes() {
    return this.http.get(`${projectTypeUrl}`);
  }

  deleteProject(id: number) {
    return this.http.delete(`${projectUrl}/${id}`);
  }

  getAllNewProjects() {
    return this.http.get(`${projectUrl}/new`);
  }
}
