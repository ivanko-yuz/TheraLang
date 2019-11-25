import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { RequestStatus } from '../request-status.enum';
import { participantUrl } from '../shared/api-endpoint.constants';


@Injectable()
export class ProjectParticipantService {

    constructor(private http: HttpClient) { }

    getAllProjectParticipants() {
        return this.http.get(participantUrl);
    }

    changeParticipationStatus(requestId: number, requestStatus: RequestStatus) {
        return this.http.put(`${participantUrl}/${requestId}`, requestStatus);
    }
}