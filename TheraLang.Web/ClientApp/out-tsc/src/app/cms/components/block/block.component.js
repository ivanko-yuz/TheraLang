import { __decorate } from "tslib";
import { Component, Input } from '@angular/core';
let BlockComponent = class BlockComponent {
    constructor() { }
    cutLink() {
        return this.model.body.media.publicUrl.substr(1);
    }
};
__decorate([
    Input()
], BlockComponent.prototype, "model", void 0);
BlockComponent = __decorate([
    Component({
        selector: 'app-block',
        templateUrl: './block.component.html',
        styleUrls: ['./block.component.less']
    })
], BlockComponent);
export { BlockComponent };
//# sourceMappingURL=block.component.js.map