export class ProjectParticipationRequest {
    constructor(
        public id:number,
        public name: string,
        public projectId: number,
        public userId: number,
        public status: number
        ) { }
}

const enum Requests{
    New,
    Aproved,
    Rejected
}