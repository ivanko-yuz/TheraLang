import { Injectable } from '@angular/core';
import { ProjectType } from './project-type.model';
import { ProjectTypeNewHttp } from './project-type-newHttp.service';
// import { HttpService } from 'src/app/project/http.service';


@Injectable()
export class ProjectTypeService {
    allProjectTypes: ProjectType[];
    constructor(
        // private http: HttpService
        private http: ProjectTypeNewHttp
    ) { }

    getAllProjectTypes() {
        const alldata = this.http.getAllProjectTypes().toPromise().then((data: ProjectType[]) => {
            this.allProjectTypes = data;
            return data;
        });
        return alldata;
    }
}
