import { __decorate } from "tslib";
import { Injectable } from '@angular/core';
let ProjectTypeService = class ProjectTypeService {
    constructor(http) {
        this.http = http;
    }
    getAllProjectTypes() {
        const alldata = this.http.getAllProjectTypes().toPromise().then((data) => {
            this.allProjectTypes = data;
            return data;
        });
        return alldata;
    }
};
ProjectTypeService = __decorate([
    Injectable()
], ProjectTypeService);
export { ProjectTypeService };
//# sourceMappingURL=project-type.service.js.map