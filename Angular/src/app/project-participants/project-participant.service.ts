import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { participantUrl } from '../shared/api-endpoint.constants';
import { ProjectParticipationRequestStatus } from '../shared/enums/project-participation-request-status.enum';


@Injectable()
export class ProjectParticipantService {

    constructor(private http: HttpClient) { }

    getAllProjectParticipants() {
        return this.http.get(participantUrl);
    }

    changeParticipationStatus(requestId: number, requestStatus: ProjectParticipationRequestStatus) {
        return this.http.put(`${participantUrl}/${requestId}`, requestStatus);
    }
}