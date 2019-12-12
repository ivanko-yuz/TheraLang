import { Component, OnInit } from "@angular/core";
import { Project } from "../project/project";
import { HttpService } from "src/app/project/http.service";
import { projectType } from "../shared/api-endpoint.constants";
import { ProjectStatusRequest } from "../shared/enums/project-status-request";
import { ProjectRequestService } from "./project-request.service";

@Component({
  selector: "app-project-request",
  templateUrl: "./project-request.component.html",
  styleUrls: ["./project-request.component.less"]
})
export class ProjectRequestComponent implements OnInit {
  projects: Project[];
  projectService: ProjectRequestService;
  //   projectRequest = new MatTableDataSource<ProjectRequest>();
  //   showActionButtons: boolean = true;
  //   @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  //   displayedColumns: string[] = [
  //     "createdById",
  //     "role",
  //     "projectId",
  //     "status",
  //     "actions"
  //   ];
  constructor(
    private http: HttpService,
    private projectRequestService: ProjectRequestService
  ) {}

  changeStatus(status: string, project: Project) {
    status === "approved"
      ? this.projectRequestService.StatusApprove(project.id)
      : this.projectRequestService.StatusReject(project.id);
  }

  ngOnInit() {
    return this.http
      .getAllNewProjects()
      .subscribe((projects: Project[]) => (this.projects = projects));
  }
}
