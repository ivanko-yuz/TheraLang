import {Injectable, OnDestroy} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Project } from './project';
import { baseUrl } from '../shared/api-endpoint.constants';
import { RequestStatus } from '../request-status-enum';

@Injectable()
export class HttpService{
  
    constructor(private http: HttpClient){ }
      
     private url = baseUrl;
     
    getAllProjects(){
        return this.http.get(this.url + 'projects');
    }

    getProjectInfo(id: number) {
        return this.http.get(this.url + 'project' + '/' + id);
    }

    getAllProjectParticipants(){
        return this.http.get(this.url + 'participants');
      }

    changeParticipationStatus (requestId: number, requestStatus: RequestStatus){
        return this.http.put(this.url + 'participants' + '/' + requestId, requestStatus);
    } 

    getAllResourcesByProjectId(projectId: number) {
        return this.http.get(this.url + 'resource/all/' + projectId);
    }

    getResourcesByCategoryId(categoryId: number, pageNumber: number, recordsPerPage: number) {
        return this.http.get(this.url + 'resource/all/' + categoryId + '/' + pageNumber 
        + '/' + recordsPerPage);
    }

    getResourceCategories(withAssignedResources: boolean) {
        return this.http.get(this.url + 'resource/categories' + '/' + withAssignedResources);
    }

    getResourcesCountByCategoryId(categoryId: number)
    {
        return this.http.get(this.url + 'resource/count' + '/' + categoryId);
    }


    createProject(project:Project) {
        return this.http.post(this.url, project);
    }

    updateProject(project: Project) {
        return this.http.put(this.url + '/' + project.id, project);
    }  

}
