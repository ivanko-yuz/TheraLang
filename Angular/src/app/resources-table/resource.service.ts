import { Injectable, OnDestroy} from '@angular/core';
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
    sort(res: Resource[]): Resource[][] {
        const sortedRess: Resource[][] = [];
        res.forEach((resuorce) => {
            if (resuorce.resourceCategory) {
                if (!sortedRess[resuorce.resourceCategory]) {sortedRess[resuorce.resourceCategory] = []; }
                sortedRess[resuorce.resourceCategory].push(resuorce);
            }
        });
        return sortedRess;
    }
    setViewTeble(res: Resource[][], name: string) {
        this.allProjectResources = res[name];
    }
}
