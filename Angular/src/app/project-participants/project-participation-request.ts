export class ProjectParticipationRequest {
    constructor(
        public id:number,
        public name: string,
        public projectId: number,
        public userId: number,
        public status: number
        ) { }
}

export const enum Request{
    New,
    Aproved,
    Rejected
}