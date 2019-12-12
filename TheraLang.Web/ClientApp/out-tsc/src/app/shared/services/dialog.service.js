import { __decorate } from "tslib";
import { Injectable } from '@angular/core';
import { MatDialogConfig } from '@angular/material';
import { ConfirmDialogComponent } from '../components/confirm-dialog/confirm-dialog.component';
let DialogService = class DialogService {
    constructor(dialog) {
        this.dialog = dialog;
    }
    openConfirmDialog(msg) {
        return this.dialog.open(ConfirmDialogComponent, {
            width: '390px',
            panelClass: 'confirm-dialog-container',
            disableClose: true,
            position: { top: "10px" },
            data: {
                message: msg
            }
        });
    }
    openFormDialog(formComponent) {
        const dialogConfig = new MatDialogConfig();
        dialogConfig.disableClose = true;
        dialogConfig.autoFocus = true;
        dialogConfig.width = '60%';
        dialogConfig.panelClass = 'form';
        this.dialog.open(formComponent, dialogConfig);
    }
};
DialogService = __decorate([
    Injectable({
        providedIn: 'root'
    })
], DialogService);
export { DialogService };
//# sourceMappingURL=dialog.service.js.map