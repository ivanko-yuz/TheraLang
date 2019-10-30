import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable()
export class HttpService{
  
    constructor(private http: HttpClient){ }
      
     private url = "https://localhost:44353/api/project";
    getAllProjects(){
        return this.http.get(this.url);
    }
    getProjectInfo(id:number){      
        return this.http.get(this.url + '/' + id);       
    }

    getAllResourcesById(projectId : number){
        return this.http.get(this.url + '/' + projectId + '/' + 'resources');
    }
    getAllResourcesWithoutId( ){
        return this.http.get('resources');
    }
}