import { __decorate } from "tslib";
import { Component, ViewChild } from '@angular/core';
let ProfileMenuComponent = class ProfileMenuComponent {
    constructor(userService, notification) {
        this.userService = userService;
        this.notification = notification;
    }
    ngOnInit() {
    }
    onLogout() {
        this.userService.logout().subscribe((msg) => {
            msg = 'Ви вийшли з облікового запису';
            this.notification.success(msg);
        }, (error) => {
            console.log(error);
            this.notification.warn('Помилка входу');
        });
    }
};
__decorate([
    ViewChild('menu', { static: true })
], ProfileMenuComponent.prototype, "menu", void 0);
ProfileMenuComponent = __decorate([
    Component({
        selector: 'app-profile-menu',
        templateUrl: './profile-menu.component.html',
        styleUrls: ['./profile-menu.component.less']
    })
], ProfileMenuComponent);
export { ProfileMenuComponent };
//# sourceMappingURL=profile-menu.component.js.map