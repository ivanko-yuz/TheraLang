import { Injectable } from '@angular/core';
import { Resource } from './resource';
import { HttpService } from '../project/http.service';
import { Observable } from 'rxjs';

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
            if (!sortedArray[resuorce.resourceCategory]) {
                sortedArray[resuorce.resourceCategory] = [];
            }
            sortedArray[resuorce.resourceCategory].push(resuorce);
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
    getCountAllResources(): Promise<number> {
        const allData = this.http.getCountAllResources().toPromise().then((data: number) => {
            this.countAllResources = data;
            return data;
        });
        return allData;
    }
}
