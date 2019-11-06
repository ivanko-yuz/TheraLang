export class ProjectParticipationRequest {
    constructor(
        public id:number,
        public projectId: number,
        public userId: number,
        public status: number
        ) { }
}