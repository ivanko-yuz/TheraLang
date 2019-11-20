import { Injectable } from '@angular/core';
import { Resource } from '../../../general-resources/resource-models/resource';
import { HttpService } from '../../../project/http.service';

@Injectable()
export class ResourceService {

    allProjectResources: Resource[] = [];
    allResources: Resource[] = [];
    countAllResourcesByCategoryId: number;

    constructor(private http: HttpService) { }

    getAllResourcesByProjId(projid: number): Promise<Resource[]> {
        const allData = this.http.getAllResourcesByProjectId(projid).toPromise().then((data: Resource[]) => {
            this.allProjectResources = data;
            return data;
        });
        return allData;
    }
    
    getAllResourceCategories(arr: Resource[][]): string[] {
        const allResourceCategories: string[] = [];
        for (const cat in arr) {
            allResourceCategories.push(cat);
        }
        return allResourceCategories;
    }
    
    sortAllResourcesByCategories(res: Resource[]): Resource[][] {
        const sortedArray: Resource[][] = [];
        res.forEach((resuorce) => {
            if (!sortedArray[resuorce.resourceCategory.type]) {
                sortedArray[resuorce.resourceCategory.type] = [];
            }
            sortedArray[resuorce.resourceCategory.type].push(resuorce);
        });
        return sortedArray;
    }

    getResourcesByCategoryId(categoryId: number, pageNumber: number, recordsPerPage: number): Promise<Resource[]> {
        const allData = this.http.getResourcesByCategoryId(categoryId, pageNumber, recordsPerPage).toPromise()
        .then((data: Resource[]) => { 
            this.allResources = data;
            return data;
        });
        return allData;
    }

    getResourcesCountByCategoryId(categoryId: number) {
        const allData = this.http.getResourcesCountByCategoryId(categoryId).toPromise().then((data: number) => {
            this.countAllResourcesByCategoryId = data;
            return data;
        });
        return allData;
    }
    // async getCountAllResources(category: string): Promise<number>{
    //     const allData = await this.http.getCountAllResources(category).toPromise().then((data: number) => {
    //         this.countAllResources = data;
    //         return data;
    //     });
    //     return allData;
    //     //  const data =  this.http.getCountAllResources(category).subscribe((data: number) => data);
    //     //  return data;
    // }
}
