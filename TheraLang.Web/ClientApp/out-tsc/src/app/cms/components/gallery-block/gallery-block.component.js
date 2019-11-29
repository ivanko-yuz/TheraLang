import { __decorate } from "tslib";
import { Component, Input } from '@angular/core';
let GalleryBlockComponent = class GalleryBlockComponent {
    constructor() { }
    cutLink(url) {
        return url.substr(1);
    }
};
__decorate([
    Input()
], GalleryBlockComponent.prototype, "block", void 0);
GalleryBlockComponent = __decorate([
    Component({
        selector: 'app-gallery-block',
        templateUrl: './gallery-block.component.html',
        styleUrls: ['./gallery-block.component.less']
    })
], GalleryBlockComponent);
export { GalleryBlockComponent };
//# sourceMappingURL=gallery-block.component.js.map