import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Project } from './project';


@Injectable({
  providedIn: 'root'
})
export class HttpProjectService {

  constructor(private http: HttpClient) { }

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
    createProject(project:Project) {
        return this.http.post(this.url, project);
    }

    updateProject(project: Project) {
  
        return this.http.put(this.url + '/' + project.id, project);
    }
}
