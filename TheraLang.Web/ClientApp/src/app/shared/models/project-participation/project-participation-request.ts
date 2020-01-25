import { ProjectParticipationRequestStatus } from "src/app/configs/project-participation-request-status";
export class ProjectParticipationRequest {
  constructor(
    public id: number,
    public role: number,
    public status: ProjectParticipationRequestStatus,
    public projectId: number,
    public requstedGuidUserId: string,
    public projectName: string,
    public requestedUserName: string,
    public requestedUserEmail: string
  ) {}
}
