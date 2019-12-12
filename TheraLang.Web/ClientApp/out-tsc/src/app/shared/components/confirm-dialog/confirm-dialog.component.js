import { __decorate, __param } from "tslib";
import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material';
let ConfirmDialogComponent = class ConfirmDialogComponent {
    constructor(dialogRef, data) {
        this.dialogRef = dialogRef;
        this.data = data;
    }
    ngOnInit() {
    }
    closeDialog() {
        this.dialogRef.close(false);
    }
};
ConfirmDialogComponent = __decorate([
    Component({
        selector: 'app-confirm-dialog',
        templateUrl: './confirm-dialog.component.html',
        styleUrls: ['./confirm-dialog.component.less']
    }),
    __param(1, Inject(MAT_DIALOG_DATA))
], ConfirmDialogComponent);
export { ConfirmDialogComponent };
//# sourceMappingURL=confirm-dialog.component.js.map