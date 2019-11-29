import { __decorate } from "tslib";
import { Component } from '@angular/core';
let ErrorComponent = class ErrorComponent {
    constructor(router) {
        this.router = router;
    }
    ngOnInit() {
    }
    goHome() {
        this.router.navigate(['']);
    }
};
ErrorComponent = __decorate([
    Component({
        selector: 'app-error',
        templateUrl: './error.component.html',
        styleUrls: ['./error.component.less']
    })
], ErrorComponent);
export { ErrorComponent };
//# sourceMappingURL=error.component.js.map