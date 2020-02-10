import { ProjectStatusRequest } from "src/app/configs/project-status-request";
export class Project {
  constructor(
    public id?: number,
    public name?: string,
    public createdbyid?:any,
    public description?: string,
    public details?: string,
    public projectStart?: Date,
    public projectEnd?: Date,
    public typeId?: number,
    public isActive?: boolean,
    public donationsSum?: number,
    public donationTargetSum?: number,
    public sumLeftToCollect?: number,
    public statusId?: ProjectStatusRequest,
  ) {}
}
