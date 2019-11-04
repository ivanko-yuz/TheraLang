import { isNullOrUndefined } from 'util';
import { ResourceCategory } from './resourceCategory';
import { Injectable, OnDestroy} from '@angular/core';
import { Resource } from './resource';
import { HttpService } from '../project/http.service';
import { Subscription } from 'rxjs/internal/Subscription';

@Injectable()
export class ResourceService implements OnDestroy{

    allProjectResources: Resource[]=[];
    //allResourcesByCategories: Resource[][]=[];

    //allResourceCategories: string[];
    //uniqueResCategories: string[];
    //subscription: Subscription;
    constructor(private http: HttpService) { }

    ngOnDestroy(){    
        //this.subscription.unsubscribe();   
    }
    getAllResourcesByProjId(projid: number):Promise<Resource[]> {
        /*if (!(isNullOrUndefined(this.allProjectResources))) {
            //this.allProjectResources.length = 0;
        }//*/
        let t = this.http.getAllResourcesById(projid).toPromise().then((data: Resource[]) => {
            this.allProjectResources = data;
            return data;
        });
        return t;
    }
    /*getAllUniqueResourceCategories() {
        this.allProjectResources.forEach((resuorce) => {
            if(!(this.uniqueResCategories.includes(resuorce.resourceCategory))){
                console.log(resuorce.resourceCategory);
                this.uniqueResCategories.push(resuorce.resourceCategory);
            };
        });
    };//*/
    getAllResourceCategories(arr:Resource[][]):string[] {
        let allResourceCategories:string[] = [];
        for(const cat in arr){
            allResourceCategories.push(cat);
        }
        return allResourceCategories;
    }
    sort(res: Resource[]):Resource[][]{
        const sortedRess:Resource[][]=[];
        res.forEach((resuorce) => {
            if(resuorce.resourceCategory){
                if (!sortedRess[resuorce.resourceCategory])sortedRess[resuorce.resourceCategory]=[];
                sortedRess[resuorce.resourceCategory].push(resuorce);
            }
        });
        return sortedRess;
    }
    
    setViewTeble(res: Resource[][], name:string){
        this.allProjectResources=res[name];
    }


    // getAallUniqueResourceCategories(){
    //     this.allProjectResources.forEach(resource => {
    //         this.allResourceCategories.forEach(function (category){
    //             if(resource.resourceCategoryId == category.id)
    //             {
    //                 this.uniqueResCategories.add(category)
    //             }
    //         })
    //     })
    // }

}
