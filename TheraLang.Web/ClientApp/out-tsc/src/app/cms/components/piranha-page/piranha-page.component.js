import { __awaiter, __decorate } from "tslib";
import { Component, Input } from '@angular/core';
let PiranhaPageComponent = class PiranhaPageComponent {
    constructor(cmsPageService) {
        this.cmsPageService = cmsPageService;
        this.ifGenerate = false;
    }
    ngOnInit() {
        return __awaiter(this, void 0, void 0, function* () {
            this.page = yield this.cmsPageService.getPiranhaPageById(this.cmsRoute.id);
            this.ifGenerate = true;
        });
    }
};
__decorate([
    Input()
], PiranhaPageComponent.prototype, "cmsRoute", void 0);
PiranhaPageComponent = __decorate([
    Component({
        selector: 'app-piranha-page',
        templateUrl: './piranha-page.component.html',
        styleUrls: ['./piranha-page.component.less']
    })
], PiranhaPageComponent);
export { PiranhaPageComponent };
//# sourceMappingURL=piranha-page.component.js.map