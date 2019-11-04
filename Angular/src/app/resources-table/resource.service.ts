import { isNullOrUndefined } from 'util';
import { ResourceCategory } from './resourceCategory';
import { Injectable, OnDestroy} from '@angular/core';
import { Resource } from './resource';
import { HttpService } from '../project/http.service';
import { Subscription } from 'rxjs/internal/Subscription';

@Injectable()
export class ResourceService implements OnDestroy{

    allProjectResources: Resource[];
    allResourceCategories: ResourceCategory[];
    subscription: Subscription;
    uniqueResCategories = new Set<ResourceCategory>();

    constructor(private http: HttpService) { }

    ngOnDestroy(){    
        this.subscription.unsubscribe();   
    }
    getAllResourcesByProjId(projid: number) {
        if (!(isNullOrUndefined(this.allProjectResources))) {
            this.allProjectResources.length = 0;
        }
        this.subscription = this.http.getAllResourcesById(projid).subscribe((data: Resource[]) => 
        this.allProjectResources = data);        
    }
    getAllResourceCategories() {
        this.subscription = this.http.getAllResourceCategories().subscribe((data: ResourceCategory[]) =>
        this.allResourceCategories = data);
    }
    getAallUniqueResourceCategories(){
        this.allProjectResources.forEach(resource => {
            this.allResourceCategories.forEach(function (category){
                if(resource.resourceCategoryId == category.id)
                {
                    this.uniqueResCategories.add(category)
                }
            })
        })
    }

}
