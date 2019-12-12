import { __decorate } from "tslib";
import { Component, Input, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material';
import * as Constants from '../../../shared/constants/resources-table';
let ResourcesInternalTableComponent = class ResourcesInternalTableComponent {
    constructor() {
        this.displayedColumns = ['id', 'name', 'date', 'description'];
    }
    ngAfterViewInit() {
        this.pageSize = Constants.ResourcesTableConstants.COLUMNS_PER_PAGE;
        this.pageSizeOptions = Constants.ResourcesTableConstants.PAGE_SIZE_OPTIONS;
        this.dataSource.paginator = this.paginator;
    }
};
__decorate([
    Input()
], ResourcesInternalTableComponent.prototype, "dataSource", void 0);
__decorate([
    Input()
], ResourcesInternalTableComponent.prototype, "lengthDataArrForDataSource", void 0);
__decorate([
    ViewChild(MatPaginator, { static: true })
], ResourcesInternalTableComponent.prototype, "paginator", void 0);
ResourcesInternalTableComponent = __decorate([
    Component({
        selector: 'app-resources-internal-table',
        templateUrl: './resources-internal-table.component.html',
        styleUrls: ['./resources-internal-table.component.less'],
    })
], ResourcesInternalTableComponent);
export { ResourcesInternalTableComponent };
//# sourceMappingURL=resources-internal-table.component.js.map