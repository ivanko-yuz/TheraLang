import { __awaiter, __decorate } from "tslib";
import { Component, ViewEncapsulation } from '@angular/core';
import * as Constants from '../../../shared/constants/resources-table';
let GeneralResourcesTableComponent = class GeneralResourcesTableComponent {
    constructor(resourceService, resourceCategoriesService) {
        this.resourceService = resourceService;
        this.resourceCategoriesService = resourceCategoriesService;
        this.showCategories = false;
    }
    ngOnInit() {
        return __awaiter(this, void 0, void 0, function* () {
            this.resourcesCategories = yield this.resourceCategoriesService
                .getResourceCategories(Constants.ResourcesTableConstants.WITH_ASSIGNED_RESOURCES);
            this.showCategories = true;
        });
    }
};
GeneralResourcesTableComponent = __decorate([
    Component({
        selector: 'app-general-resources-table',
        templateUrl: './general-resources-table.component.html',
        styleUrls: ['./general-resources-table.component.less'],
        encapsulation: ViewEncapsulation.None
    })
], GeneralResourcesTableComponent);
export { GeneralResourcesTableComponent };
//# sourceMappingURL=general-resources-table.component.js.map