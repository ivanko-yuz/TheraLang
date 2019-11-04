import { Resource } from './../resources-table/resource';
import {Injectable, OnDestroy} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { Subscription } from 'rxjs';

@Injectable()
export class HttpService{   

    constructor(private http: HttpClient) { }

     private url = 'https://localhost:44353/api/';
    getAllProjects() {
        return this.http.get(this.url + 'project');        
    }
    getProjectInfo(id: number) {
        return this.http.get(this.url + 'project' + '/' + id);
    }
    getAllResourcesById(projectId: number) {
        return this.http.get(this.url + 'project' + '/' + projectId + '/' + 'resources');
    }
    getAllResourcesWithoutId( ) {
        return this.http.get('resources');
    }
    getAllResourceCategories(){
        return this.http.get(this.url + 'project' + '/' + "resources" + "/" + "categories");
    }
}
