import { __decorate } from "tslib";
import { Injectable } from '@angular/core';
let ResourceService = class ResourceService {
    constructor(http) {
        this.http = http;
        this.allProjectResources = [];
        this.allResources = [];
    }
    getAllResourcesByProjId(projid) {
        const allData = this.http.getAllResourcesById(projid).toPromise().then((data) => {
            this.allProjectResources = data;
            return data;
        });
        return allData;
    }
    getAllResourceCategories(arr) {
        const allResourceCategories = [];
        for (const cat in arr) {
            allResourceCategories.push(cat);
        }
        return allResourceCategories;
    }
    sortAllResourcesByCategories(res) {
        const sortedArray = [];
        res.forEach((resuorce) => {
            if (!sortedArray[resuorce.resourceCategory.type]) {
                sortedArray[resuorce.resourceCategory.type] = [];
            }
            sortedArray[resuorce.resourceCategory.type].push(resuorce);
        });
        return sortedArray;
    }
    getResourcesByCategoryId(categoryId, pageNumber, recordsPerPage) {
        const allData = this.http.getResourcesByCategoryId(categoryId, pageNumber, recordsPerPage).toPromise()
            .then((data) => {
            this.allResources = data;
            return data;
        });
        return allData;
    }
    getResourcesCountByCategoryId(categoryId) {
        const allData = this.http.getResourcesCountByCategoryId(categoryId).toPromise().then((data) => {
            this.countAllResourcesByCategoryId = data;
            return data;
        });
        return allData;
    }
};
ResourceService = __decorate([
    Injectable()
], ResourceService);
export { ResourceService };
//# sourceMappingURL=resource.service.js.map