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

    delProject(id:number){      
        return this.http.delete(this.url + '/' + id);
    }
}