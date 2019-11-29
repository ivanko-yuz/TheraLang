import { __decorate } from "tslib";
import { Injectable } from '@angular/core';
let ResourceCategoriesService = class ResourceCategoriesService {
    constructor(http) {
        this.http = http;
    }
    getResourceCategories(withAssignedResources) {
        const categories = this.http.getResourceCategories(withAssignedResources).toPromise()
            .then((category) => {
            this.resourceCategories = category;
            return category;
        });
        return categories;
    }
};
ResourceCategoriesService = __decorate([
    Injectable()
], ResourceCategoriesService);
export { ResourceCategoriesService };
//# sourceMappingURL=resource-categories.service.js.map