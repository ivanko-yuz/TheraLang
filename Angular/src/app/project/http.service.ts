import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Project } from './project';


@Injectable()
export class HttpService{
  
    constructor(private http: HttpClient){ }
      
     private url = "./back-endDbMocks/projects.json";
     private resourcesUrl = "./back-end_DbMocks/resources.json";
    getAllProjects(){
        return this.http.get(this.url);
    }
    getProjectInfo(id:number){      
        return this.http.get(this.url + '/' + id);
    }
    getAllResources(project : Project){
        return this.http.get(this.resourcesUrl + project.id + project.name + project.type);
    }
}