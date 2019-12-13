import { __decorate } from "tslib";
import { Component } from '@angular/core';
let LoginComponent = class LoginComponent {
    constructor(notificationService, dialog, userService) {
        this.notificationService = notificationService;
        this.dialog = dialog;
        this.userService = userService;
        this.hide = true;
    }
    ngOnInit() {
    }
    onSubmit() {
        debugger;
        this.userService.login(this.userService.loginForm.value).subscribe((msg) => {
            msg = 'Вхід успішний';
            this.notificationService.success(msg);
            this.onClose();
        }, (error) => {
            console.log(error);
            this.notificationService.warn('Помилка входу');
            this.userService.loginForm.reset;
        });
    }
    onClose() {
        this.userService.loginForm.reset();
        this.dialog.closeDialogs();
    }
};
LoginComponent = __decorate([
    Component({
        selector: 'app-login',
        templateUrl: './login.component.html',
        styleUrls: ['./login.component.less']
    })
], LoginComponent);
export { LoginComponent };
//# sourceMappingURL=login.component.js.map