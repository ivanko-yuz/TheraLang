import { Component, OnInit } from "@angular/core";
import { Project } from "../../../../../shared/models/project/project";
import { HttpProjectService } from "../../../../../core/http/project/http-project.service";
import { ProjectStatusRequest } from "../../../../../configs/project-status-request";
import { HttpService } from "src/app/core/http/http/http.service";

@Component({
  selector: "app-project-request",
  templateUrl: "./project-request.component.html",
  styleUrls: ["./project-request.component.less"]
})
export class ProjectRequestComponent implements OnInit {
  projects: Project[];
  projectService: HttpProjectService;
  showActionButtons: boolean = true;

  constructor(
    private http: HttpService,
    private projectRequestService: HttpProjectService
  ) {}

  changeStatus(status: string, project: Project) {
    status === "approved"
      ? this.projectRequestService
          .Approve(project.id)
          .subscribe(data => this.loadNewProjects())
      : this.projectRequestService
          .Reject(project.id)
          .subscribe(data => this.loadNewProjects());
  }

  ngOnInit() {
    return this.http
      .getAllNewProjects()
      .subscribe((projects: Project[]) => (this.projects = projects));
  }

  loadNewProjects() {
    this.http.getAllNewProjects().subscribe((projects: Project[]) => {
      this.projects = projects;
    });
  }

  changeTab(tabPosition: number) {
    if (tabPosition === 1) {
      this.showActionButtons = false;
      return this.projectRequestService
        .GetProjectsByStatus(ProjectStatusRequest.Approved)
        .subscribe((projects: Project[]) => (this.projects = projects));
    } else if (tabPosition === 2) {
      this.showActionButtons = false;
      return this.projectRequestService
        .GetProjectsByStatus(ProjectStatusRequest.Rejected)
        .subscribe((projects: Project[]) => (this.projects = projects));
    } else {
      this.showActionButtons = true;
      return this.http
        .getAllNewProjects()
        .subscribe((projects: Project[]) => (this.projects = projects));
    }
  }
}
