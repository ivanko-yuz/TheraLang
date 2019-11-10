import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
import { HttpProjectService } from '../project/shared/http-project.service';
let ResourcesComponent = class ResourcesComponent {
    constructor(route, http) {
        this.route = route;
        this.http = http;
    }
    ;
    ngOnInit() {
        this.http.getAllResourcesWithoutId().subscribe((_data) => this.projectResources = _data);
    }
};
ResourcesComponent = tslib_1.__decorate([
    Component({
        selector: 'app-resources',
        templateUrl: './resources.component.html',
        styleUrls: ['./resources.component.less'],
        providers: [HttpProjectService]
    })
], ResourcesComponent);
export { ResourcesComponent };
//# sourceMappingURL=resources.component.js.map