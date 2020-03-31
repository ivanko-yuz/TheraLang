import { Injectable } from "@angular/core";
import { ProjectType } from "../../../shared/models/project-type/project-type.model";
import { ProjectTypeHttp } from "../../http/project-type/project-type-Http.service";
import { Observable } from "rxjs";
import { TranslateService } from "@ngx-translate/core";
import { NotificationService } from "../notification/notification.service";

@Injectable()
export class ProjectTypeService {
  allProjectTypes: ProjectType[];
  public editId: number;
  public editName: string;

  constructor(
    private http: ProjectTypeHttp,
    private notificationService: NotificationService,
    private translate: TranslateService,
  ) {}

  getAllProjectTypes() {
    const alldata = this.http
      .getAllProjectTypes()
      .toPromise()
      .then((data: ProjectType[]) => {
        this.allProjectTypes = data;
        return data;
      });
    return alldata;
  }

  Update(projectType: ProjectType) {
    this.http.put(projectType).subscribe(
      async response => {
        this.notificationService.success(
          await this.getLocalization("common.updated-successfully"),
        );
        // "Project type was successfully updated"
      },
      async error => {
        this.notificationService.warn(await this.getLocalization("common.wth"));
        // "Project type was not updated"
      },
    );
  }

  Create(newProjectType: ProjectType): Observable<any> {
    this.http.post(newProjectType).subscribe(
      async response => {
        this.notificationService.success(
          await this.getLocalization("common.added-successfully"),
        );
        // "Project type was successfully added"
      },
      async error => {
        this.notificationService.warn(await this.getLocalization("common.wth"));
        // "Project type was not added"
      },
    );
    return;
  }

  Delete(projectTypeId: number) {
    this.http.delete(projectTypeId).subscribe(
      async response => {
        this.notificationService.success(
          await this.getLocalization("common.deleted-successfully"),
        );
        // "Project type was successfully deleted"
      },
      async error => {
        this.notificationService.warn(await this.getLocalization("common.wth"));
        // "Project type was not deleted"
      },
    );
  }

  getLocalization(locPath: string): Promise<string> {
    return this.translate.get(locPath).toPromise();
  }
}
