import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { participationUrl } from '../shared/api-endpoint.constants';

@Injectable({
  providedIn: 'root'
})
export class ProjectParticipationService {

  constructor(private http: HttpClient) { }

  private url = participationUrl; 

  createParticipRequest(projectId) {
    return this.http.post(this.url + '/' + 'create', projectId, {observe: 'response'});
}
}
