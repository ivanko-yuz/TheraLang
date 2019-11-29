import { __decorate } from "tslib";
import { Component, Input } from '@angular/core';
import { MatTableDataSource } from '@angular/material';
let ResourcesTableComponent = class ResourcesTableComponent {
    constructor(resourceService) {
        this.resourceService = resourceService;
    }
    ngOnInit() {
        for (const resCategoty in this.sortedResourcesByCategory) {
            this.selectResourcesArrayByCategotyName(resCategoty);
            return;
        }
    }
    convertMatTabChangeEventLabelToString(event) {
        const category = event.tab.textLabel;
        this.selectResourcesArrayByCategotyName(category);
    }
    selectResourcesArrayByCategotyName(category) {
        this.setDataSourceToInternalResourcesTable(this.sortedResourcesByCategory[category]);
    }
    setDataSourceToInternalResourcesTable(res) {
        this.lengthDataArrForDataSource = res.length;
        this.dataSource = new MatTableDataSource(res);
    }
};
__decorate([
    Input()
], ResourcesTableComponent.prototype, "sortedResourcesByCategory", void 0);
ResourcesTableComponent = __decorate([
    Component({
        selector: 'app-resources-table',
        templateUrl: './resources-table.component.html',
        styleUrls: ['./resources-table.component.less']
    })
], ResourcesTableComponent);
export { ResourcesTableComponent };
//# sourceMappingURL=resources-table.component.js.map