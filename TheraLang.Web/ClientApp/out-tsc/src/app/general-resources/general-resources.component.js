import { __awaiter, __decorate } from "tslib";
import { Component, ViewEncapsulation } from '@angular/core';
let GeneralResourcesComponent = class GeneralResourcesComponent {
    constructor(resourceService) {
        this.resourceService = resourceService;
        this.sortedResourcesByCategory = [];
    }
    ngOnInit() {
        return __awaiter(this, void 0, void 0, function* () {
            const allResources = yield this.resourceService.getAllResourcesByProjId(null);
            this.sortedResourcesByCategory = this.resourceService.sortAllResourcesByCategories(allResources);
        });
    }
};
GeneralResourcesComponent = __decorate([
    Component({
        selector: 'app-general-resources',
        templateUrl: './general-resources.component.html',
        styleUrls: ['./general-resources.component.less'],
        encapsulation: ViewEncapsulation.None,
    })
], GeneralResourcesComponent);
export { GeneralResourcesComponent };
//# sourceMappingURL=general-resources.component.js.map