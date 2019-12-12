import { Injectable } from '@angular/core';
import { ProjectType } from './project-type.model';
import { ProjectTypeHttp } from './project-type-Http.service';
import { NotificationService } from 'src/app/shared/services/notification.service';
import { Observable } from 'rxjs';

@Injectable()
export class ProjectTypeService {

    allProjectTypes: ProjectType[];
    public editId: number;
    public editName: string;

    constructor(
        private http: ProjectTypeHttp,
        private notificationService: NotificationService,
    ) { }

    getAllProjectTypes() {
        const alldata = this.http.getAllProjectTypes().toPromise().then((data: ProjectType[]) => {
            this.allProjectTypes = data;
            return data;
        });
        return alldata;
    }

    Update(projectType: ProjectType) {
        this.http.put(projectType).subscribe(
            response => {
                this.notificationService.success(
                    "Project type was successfully updated"
                );
            },
            error => {
                this.notificationService.warn("Project type was not updated");
            }
        );
    }

    Create(newProjectType: ProjectType): Observable<any> {
        this.http.post(newProjectType).subscribe(
            response => {
                this.notificationService.success("Project type was successfully added");
            },
            error => {
                this.notificationService.warn("Project type was not added");
            }
        );
        return;
    }

    Delete(projectTypeId: number) {
        this.http.delete(projectTypeId).subscribe(
            response => {
                this.notificationService.success(
                    "Project type was successfully deleted"
                );
            },
            error => {
                this.notificationService.warn("Project type was not deleted");
            }
        );
    }

}
