import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { participationUrl } from '../shared/api-endpoint.constants';
import { ProjectParticipationRequestStatus } from '../shared/enums/project-participation-request-status';

@Injectable({
  providedIn: 'root'
})
export class ProjectParticipationService {

  constructor(private http: HttpClient) { }

  private url = participationUrl;

  getAllProjectParticipants() {
    return this.http.get(this.url);
  }

  changeParticipationStatus(requestId: number, requestStatus: ProjectParticipationRequestStatus) {
    return this.http.put(this.url + '/' + requestId, requestStatus);
  }

  createParticipRequest(projectId) {
    return this.http.post(this.url + '/create', projectId);
  }
}
