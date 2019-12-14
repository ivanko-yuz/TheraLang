import { Injectable } from "@angular/core";
import { ProjectStatusRequest } from "../shared/enums/project-status-request";
import { HttpClient } from "@angular/common/http";
import { projectUrl } from "../shared/api-endpoint.constants";

@Injectable({
  providedIn: "root"
})
export class ProjectRequestService {
  constructor(private http: HttpClient) {}

  private url = projectUrl;
  getAllProjectParticipants() {
    return this.http.get(this.url);
  }

  Approved(id: number) {
    return this.http.get(this.url + "/approve/" + id).subscribe();
  }
  Rejected(id: number) {
    return this.http.get(this.url + "/reject/" + id).subscribe();
  }
}
