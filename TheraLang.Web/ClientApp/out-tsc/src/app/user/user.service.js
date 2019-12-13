import { __decorate } from "tslib";
import { Injectable } from '@angular/core';
import { accountUrl } from '../shared/api-endpoint.constants';
import { Validators } from '@angular/forms';
let UserService = class UserService {
    constructor(http, fb) {
        this.http = http;
        this.fb = fb;
        this.loginForm = this.fb.group({
            username: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(50)]],
            password: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(50)]],
        });
        this.baseUrl = accountUrl;
    }
    login(loginData) {
        return this.http.post(this.baseUrl + '/login', loginData);
    }
    logout() {
        debugger;
        return this.http.get(this.baseUrl + '/logout');
    }
};
UserService = __decorate([
    Injectable({
        providedIn: 'root'
    })
], UserService);
export { UserService };
//# sourceMappingURL=user.service.js.map