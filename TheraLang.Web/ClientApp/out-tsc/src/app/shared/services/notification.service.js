import { __decorate } from "tslib";
import { Injectable } from '@angular/core';
let NotificationService = class NotificationService {
    constructor(snackBar) {
        this.snackBar = snackBar;
        this.config = {
            duration: 3000,
            horizontalPosition: 'center',
            verticalPosition: 'top',
        };
    }
    success(msg) {
        this.config['panelClass'] = ['notification', 'success'];
        this.snackBar.open(msg, '', this.config);
    }
    warn(msg) {
        this.config['panelClass'] = ['notification', 'warn'];
        this.snackBar.open(msg, '', this.config);
    }
};
NotificationService = __decorate([
    Injectable({
        providedIn: 'root'
    })
], NotificationService);
export { NotificationService };
//# sourceMappingURL=notification.service.js.map