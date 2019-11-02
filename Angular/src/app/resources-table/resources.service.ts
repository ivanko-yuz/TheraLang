import { Injectable } from '@angular/core';
import { Resource } from './resource';
import { HttpService } from '../project/http.service';
import { isNullOrUndefined } from 'util';

@Injectable()
export class ResourceService {

    constructor(private http : HttpService) { }
    allProjectResources: Resource[];
    getAllResourcesByProjId(projid: number){
        if(!isNullOrUndefined(this.allProjectResources)){
            this.allProjectResources.length = 0;
        }
        this.http.getAllResourcesById(projid).subscribe((data: Resource[]) => this.allProjectResources = data);
    }
    getAllResourceCategoriesByProjId(projId: number){

    }
    getAllResourcesByCategoryId(categoryId: number){

    }

        
       
}
