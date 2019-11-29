import { __decorate } from "tslib";
import { Injectable } from '@angular/core';
import { HttpErrorResponse } from '@angular/common/http';
import { Router } from '@angular/router';
let ErrorHandlerService = class ErrorHandlerService {
    constructor(injector) {
        this.injector = injector;
    }
    handleError(error) {
        const router = this.injector.get(Router);
        console.log('Request URL: ${router.url}');
        if (error instanceof HttpErrorResponse) {
            console.error('Backend returned status code:', error.status);
            console.error('Response body:', error.message);
        }
        else {
            console.log('An error occurred', error.message);
        }
        router.navigate(['error']);
    }
};
ErrorHandlerService = __decorate([
    Injectable({
        providedIn: 'root'
    })
], ErrorHandlerService);
export { ErrorHandlerService };
//# sourceMappingURL=error-handler.service.js.map