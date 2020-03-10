import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { baseUrl } from "src/app/configs/api-endpoint.constants";

@Injectable()
export class HttpService {
  constructor(private http: HttpClient) {}

  private url = baseUrl;

  getAllProjects() {
    return this.http.get(this.url + "projects");
  }
  getAllProjectsFiltered(query:string) {
    return this.http.get(this.url + "projects" + query);
  }

  getProjectInfo(id: number) {
    return this.http.get(this.url + "projects" + "/" + id);
  }

  getResourcesByCategoryId(
    categoryId: number,
    pageNumber: number,
    recordsPerPage: number
  ) {
    return this.http.get(
      this.url +
        "resources/all/" +
        categoryId +
        "/" +
        pageNumber +
        "/" +
        recordsPerPage
    );
  }

  getResourceCategories(withAssignedResources: boolean) {
    return this.http.get(
      this.url + "resources/categories" + "/" + withAssignedResources
    );
  }

  getResourcesCountByCategoryId(categoryId: number) {
    return this.http.get(this.url + "resources/count" + "/" + categoryId);
  }

  getAllResourcesById(projectId: number) {
    return this.http.get(this.url + "resources/all/" + projectId);
  }

  getAllProjectTypes() {
    return this.http.get(this.url + "projectTypes");
  }

  deleteProject(id: number) {
    return this.http.delete(this.url + "projects" + "/" + id);
  }

  getAllNewProjects() {
    return this.http.get(this.url + "projects/new");
  }
}
