import { ProjectStatusRequest } from "../shared/enums/project-status-request";
export class Project {
  constructor(
    public id?: number,
    public name?: string,
    public description?: string,
    public details?: string,
    public projectStart?: Date,
    public projectEnd?: Date,
    public type?: string,
    public isActive?: boolean,
    public statusId?: ProjectStatusRequest
  ) {}
}
