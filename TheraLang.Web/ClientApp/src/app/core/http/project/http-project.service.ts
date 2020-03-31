import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { projectUrl } from "src/app/configs/api-endpoint.constants";

@Injectable()
export class HttpProjectService {
  constructor(private http: HttpClient) {}

  private url = projectUrl;
  getAllProjectParticipants() {
    return this.http.get(this.url);
  }

  GetProjectsByStatus(status: number) {
    return this.http.get(`${this.url}/newstatus/${status}`);
  }

  Approve(id: number) {
    return this.http.get(`${this.url}/approve/${id}`);
  }
  Reject(id: number) {
    return this.http.get(`${this.url}/reject/${id}`);
  }
}
