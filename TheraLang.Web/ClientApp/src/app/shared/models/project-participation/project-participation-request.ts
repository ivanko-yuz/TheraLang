import { ProjectParticipationRequestStatus } from "src/app/configs/project-participation-request-status";
export class ProjectParticipationRequest {
  constructor(
    public id: number,
    public createdById: number,
    public role: number,
    public projectId: number,
    public status: ProjectParticipationRequestStatus
  ) {}
}
