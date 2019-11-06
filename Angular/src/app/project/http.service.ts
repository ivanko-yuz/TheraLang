import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable()
export class HttpService{
  
    constructor(private http: HttpClient){ }
      
     private url = "https://localhost:44353/api/";
     

     getAllProjectParticipants(){
        return this.http.get(this.url + 'projectParticipants');
      }

    getAllProjects(){
        return this.http.get(this.url + 'project');
    }

    changeParticipationStatus (requestId: number, requestStatus: number){
        return this.http.put(this.url + 'projectParticipants' + '/' + requestId, requestStatus);
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