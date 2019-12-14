import { Component, OnInit } from "@angular/core";
import { Project } from "../project/project";
import { HttpService } from "src/app/project/http.service";
import { ProjectRequestService } from "./project-request.service";

@Component({
  selector: "app-project-request",
  templateUrl: "./project-request.component.html",
  styleUrls: ["./project-request.component.less"]
})
export class ProjectRequestComponent implements OnInit {
  projects: Project[];
  projectService: ProjectRequestService;

  constructor(
    private http: HttpService,
    private projectRequestService: ProjectRequestService
  ) {}

  changeStatus(status: string, project: Project) {
    status === "approved"
      ? this.projectRequestService.Approved(project.id)
      : this.projectRequestService.Rejected(project.id);

    this.http.getAllNewProjects().subscribe(data => {
      this.loadRequest();
    });
  }

  ngOnInit() {
    return this.http
      .getAllNewProjects()
      .subscribe((projects: Project[]) => (this.projects = projects));
  }

  loadRequest() {
    this.http.getAllNewProjects().subscribe((projects: Project[]) => {
      this.projects = projects;
    });
  }
}
