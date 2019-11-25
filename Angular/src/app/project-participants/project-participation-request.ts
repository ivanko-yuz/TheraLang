import { RequestStatus } from '../request-status.enum';

export class ProjectParticipationRequest {
    constructor(
        public id:number,
        public createdById: number,
        public role: number,
        public projectId: number,
        public status: RequestStatus
        ) { }
}

