import { Injectable } from '@angular/core';
import { Resource } from './resource';
import { HttpService } from '../project/http.service';

@Injectable()
export class ResourceService {

    allProjectResources: Resource[] = [];

    constructor(private http: HttpService) { }

    getAllResourcesByProjId(projid: number): Promise<Resource[]> {
        const allData = this.http.getAllResourcesById(projid).toPromise().then((data: Resource[]) => {
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
            if (!sortedArray[resuorce.resourceCategory]) {
                sortedArray[resuorce.resourceCategory] = [];
            }
            sortedArray[resuorce.resourceCategory].push(resuorce);
        });
        return sortedArray;
    }
    // setViewTeble(res: Resource[][], name: string) {
    //     this.allProjectResources = res[name];
    // }
}
