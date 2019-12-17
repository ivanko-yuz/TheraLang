import { ProjectParticipationRequestStatus } from "../shared/enums/project-participation-request-status";

export class ProjectParticipationRequest {
  constructor(
    public id: number,
    public createdById: number,
    public role: number,
    public projectId: number,
    public status: ProjectParticipationRequestStatus
  ) {}
}
