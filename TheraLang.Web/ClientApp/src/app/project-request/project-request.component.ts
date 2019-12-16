import { Component, OnInit } from "@angular/core";
import { Project } from "../project/project";
import { HttpService } from "src/app/project/http.service";
import { HttpProjectService } from "./http-project.service";
import { ProjectStatusRequest } from "../shared/enums/project-status-request";

@Component({
  selector: "app-project-request",
  templateUrl: "./project-request.component.html",
  styleUrls: ["./project-request.component.less"]
})
export class ProjectRequestComponent implements OnInit {
  projects: Project[];
  projectService: HttpProjectService;

  constructor(
    private http: HttpService,
    private projectRequestService: HttpProjectService
  ) {}

  changeStatus(status: string, project: Project) {
    status === "approved"
      ? this.projectRequestService.Approve(project.id).subscribe(data => this.loadNewProjects())
      : this.projectRequestService.Reject(project.id).subscribe(data => this.loadNewProjects());
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
      return this.projectRequestService
        .GetProjectsByStatus(ProjectStatusRequest.Approved)
        .subscribe((projects: Project[]) => (this.projects = projects));
    } else if (tabPosition === 2) {
      return this.projectRequestService
        .GetProjectsByStatus(ProjectStatusRequest.Rejected)
        .subscribe((projects: Project[]) => (this.projects = projects));
    } else {
      return this.http
        .getAllNewProjects()
        .subscribe((projects: Project[]) => (this.projects = projects));
    }
  }
}
