import { Injectable } from '@angular/core';
import { ProjectType } from './project-type.model';
import { HttpService } from '../project/http.service';

@Injectable ()
export class ProjectTypeService{
    allProjectTypes: ProjectType[];
    
    constructor(private http: HttpService){

    }
    getAllProjectTypes() {
        const alldata = this.http.getAllProjectTypes().toPromise().then((data: ProjectType[]) => {
            this.allProjectTypes = data;
            return data;
        });
        return alldata;       
    }
}