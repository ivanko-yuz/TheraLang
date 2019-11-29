import { __awaiter, __decorate } from "tslib";
import { Component, ViewChild, Input } from '@angular/core';
import { MatTableDataSource, MatPaginator } from '@angular/material';
import * as Constants from '../../../shared/constants/resources-table';
let GeneralResourcesInnerTableComponent = class GeneralResourcesInnerTableComponent {
    constructor(resourceService) {
        this.resourceService = resourceService;
        this.showTable = false;
        this.columnsPerPage = Constants.ResourcesTableConstants.COLUMNS_PER_PAGE;
        this.pageSizeOptions = Constants.ResourcesTableConstants.PAGE_SIZE_OPTIONS;
        this.displayedColumns = ['id', 'name', 'date', 'description'];
    }
    ngOnInit() {
        return __awaiter(this, void 0, void 0, function* () {
            this.resources = yield this.resourceService.getResourcesByCategoryId(this.resourcesCategoryId, Constants.ResourcesTableConstants.PAGE_NUMBER, Constants.ResourcesTableConstants.COLUMNS_PER_PAGE);
            this.allResourcesCount = yield this.resourceService.getResourcesCountByCategoryId(this.resourcesCategoryId);
            this.dataSource = new MatTableDataSource(this.resources);
            this.dataSource.paginator = this.paginator;
            this.showTable = true;
        });
    }
    pageChanged(event) {
        return __awaiter(this, void 0, void 0, function* () {
            this.resources = yield this.resourceService.getResourcesByCategoryId(this.resourcesCategoryId, event.pageIndex + 1, event.pageSize);
            this.allResourcesCount = yield this.resourceService.getResourcesCountByCategoryId(this.resourcesCategoryId);
            this.dataSource = new MatTableDataSource(this.resources);
            this.dataSource.paginator = this.paginator;
        });
    }
};
__decorate([
    Input()
], GeneralResourcesInnerTableComponent.prototype, "resourcesCategoryId", void 0);
__decorate([
    ViewChild(MatPaginator, { static: true })
], GeneralResourcesInnerTableComponent.prototype, "paginator", void 0);
GeneralResourcesInnerTableComponent = __decorate([
    Component({
        selector: 'app-general-resources-inner-table',
        templateUrl: './general-resources-inner-table.component.html',
        styleUrls: ['./general-resources-inner-table.component.less']
    })
], GeneralResourcesInnerTableComponent);
export { GeneralResourcesInnerTableComponent };
//# sourceMappingURL=general-resources-inner-table.component.js.map