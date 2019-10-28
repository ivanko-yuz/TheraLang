import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';

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
    getAllResourcesById(projectId : number){
        return this.http.get(this.resourcesUrl );
    }
}