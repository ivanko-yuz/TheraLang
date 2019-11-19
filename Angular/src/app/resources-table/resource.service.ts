import { Injectable } from '@angular/core';
import { Resource } from '../general-resources/resource-models/resource';
import { HttpService } from '../project/http.service';

@Injectable()
export class ResourceService {

    allProjectResources: Resource[] = [];
    allResources: Resource[] = [];
    countAllResources: number;

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
        // tslint:disable-next-line:forin
        for (const category in arr) {
            allResourceCategories.push(category);
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

    getAllResources(pageNumber: number, recordsPerPage: number): Promise<Resource[]> {
        const allData = this.http.getAllResources(pageNumber, recordsPerPage).toPromise().then((data: Resource[]) => {
            this.allResources = data;
            return data;
        });
        return allData;
    }
    async getCountAllResources(category: string): Promise<number>{
        const allData = await this.http.getCountAllResources(category).toPromise().then((data: number) => {
            this.countAllResources = data;
            return data;
        });
        return allData;
        //  const data =  this.http.getCountAllResources(category).subscribe((data: number) => data);
        //  return data;
    }
}
