import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';


@Injectable()
export class HttpService{
  
    constructor(private http: HttpClient){ }
      
     private url = "/api/project";
    getAllProjects(){
        return this.http.get(this.url);
    }
    getProjectInfo(id:number){      
        return this.http.get(this.url + '/' + id);
    }
}