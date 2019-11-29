import { __decorate } from "tslib";
import { Component, Input, ViewChild } from '@angular/core';
let ToolbarItemComponent = class ToolbarItemComponent {
    constructor(cmsRouteHelperService) {
        this.cmsRouteHelperService = cmsRouteHelperService;
    }
    ngOnInit() {
    }
    isFinalMenu() {
        return !this.needSubMenus();
    }
    needSubMenus() {
        return this.toolbarItem.subItems.length > 0; // && this.toolbarItem.cmsRoute.pageTypeName !== 'Blog archive';
        // TODO: adjust if you need exclude
    }
    onClick() {
        this.cmsRouteHelperService.updateRoute(this.toolbarItem.cmsRoute);
    }
};
__decorate([
    Input()
], ToolbarItemComponent.prototype, "toolbarItem", void 0);
__decorate([
    ViewChild('menu', { static: false })
], ToolbarItemComponent.prototype, "menu", void 0);
ToolbarItemComponent = __decorate([
    Component({
        selector: 'app-toolbar-item',
        templateUrl: './toolbar-item.component.html',
        styleUrls: ['./toolbar-item.component.less']
    })
], ToolbarItemComponent);
export { ToolbarItemComponent };
//# sourceMappingURL=toolbar-item.component.js.map