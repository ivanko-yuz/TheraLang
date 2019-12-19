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
                    "Проект успішно оновлено"
                );
            },
            error => {
                this.notificationService.warn("Не вдалося оновити проект");
            }
        );
    }

    Create(newProjectType: ProjectType): Observable<any> {
        this.http.post(newProjectType).subscribe(
            response => {
                this.notificationService.success("Проект успішно створено");
            },
            error => {
                this.notificationService.warn("Не вдалося створити проект");
            }
        );
        return;
    }

    Delete(projectTypeId: number) {
        this.http.delete(projectTypeId).subscribe(
            response => {
                this.notificationService.success(
                    "Проект видалено"
                );
            },
            error => {
                this.notificationService.warn("Не вдалося видалити проект");
            }
        );
    }

}
