import { __awaiter, __decorate } from "tslib";
import { Component } from '@angular/core';
let ProjectTypeComponent = class ProjectTypeComponent {
    constructor(projectTypeService) {
        this.projectTypeService = projectTypeService;
        this.displayedColumns = ['name'];
    }
    ngOnInit() {
        return __awaiter(this, void 0, void 0, function* () {
            this.projectTypes = yield this.projectTypeService.getAllProjectTypes();
        });
    }
};
ProjectTypeComponent = __decorate([
    Component({
        selector: 'app-project-type',
        templateUrl: './project-type.component.html',
        styleUrls: ['./project-type.component.less']
    })
], ProjectTypeComponent);
export { ProjectTypeComponent };
//# sourceMappingURL=project-type.component.js.map