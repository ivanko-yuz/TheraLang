var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var __generator = (this && this.__generator) || function (thisArg, body) {
    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;
    return g = { next: verb(0), "throw": verb(1), "return": verb(2) }, typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
    function verb(n) { return function (v) { return step([n, v]); }; }
    function step(op) {
        if (f) throw new TypeError("Generator is already executing.");
        while (_) try {
            if (f = 1, y && (t = op[0] & 2 ? y["return"] : op[0] ? y["throw"] || ((t = y["return"]) && t.call(y), 0) : y.next) && !(t = t.call(y, op[1])).done) return t;
            if (y = 0, t) op = [op[0] & 2, t.value];
            switch (op[0]) {
                case 0: case 1: t = op; break;
                case 4: _.label++; return { value: op[1], done: false };
                case 5: _.label++; y = op[1]; op = [0]; continue;
                case 7: op = _.ops.pop(); _.trys.pop(); continue;
                default:
                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                    if (t[2]) _.ops.pop();
                    _.trys.pop(); continue;
            }
            op = body.call(thisArg, _);
        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }
        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };
    }
};
(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["main"], {
        /***/ "./$$_lazy_route_resource lazy recursive": 
        /*!******************************************************!*\
          !*** ./$$_lazy_route_resource lazy namespace object ***!
          \******************************************************/
        /*! no static exports found */
        /***/ (function (module, exports) {
            function webpackEmptyAsyncContext(req) {
                // Here Promise.resolve().then() is used instead of new Promise() to prevent
                // uncaught exception popping up in devtools
                return Promise.resolve().then(function () {
                    var e = new Error("Cannot find module '" + req + "'");
                    e.code = 'MODULE_NOT_FOUND';
                    throw e;
                });
            }
            webpackEmptyAsyncContext.keys = function () { return []; };
            webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
            module.exports = webpackEmptyAsyncContext;
            webpackEmptyAsyncContext.id = "./$$_lazy_route_resource lazy recursive";
            /***/ 
        }),
        /***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/app.component.html": 
        /*!**************************************************************************!*\
          !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/app.component.html ***!
          \**************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("<div class=\"header\">\r\n    <a href=\"\"><img src=\"assets/img/uttmm2.png\" alt=\"\" class=\"main-icon\"></a>\r\n    <h6 class=\"title\">+38 (069) 33 123 11) {{title}}</h6>\r\n    <h6 class=\"title\">+38 (069) 47 654 64) {{title}}</h6>\r\n    \r\n</div>\r\n<app-toolbar></app-toolbar> \r\n<router-outlet></router-outlet>\r\n<!-- <app-footer></app-footer> -->");
            /***/ 
        }),
        /***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/footer/footer.component.html": 
        /*!************************************************************************************!*\
          !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/footer/footer.component.html ***!
          \************************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("<div class=\"footerBlock\">\r\n    <div class=\"fixedMainBlock\">\r\n    </div>\r\n</div>\r\n");
            /***/ 
        }),
        /***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/general-resources/general-resources-tables/general-resources-inner-table/general-resources-inner-table.component.html": 
        /*!*****************************************************************************************************************************************************************************!*\
          !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/general-resources/general-resources-tables/general-resources-inner-table/general-resources-inner-table.component.html ***!
          \*****************************************************************************************************************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("<div class=\"mat-elevation-z8\" *ngIf=\"showTable\">\r\n  <table mat-table [dataSource]=\"dataSource\">\r\n\r\n    <ng-container matColumnDef=\"id\">\r\n      <th mat-header-cell *matHeaderCellDef> ID </th>\r\n      <td mat-cell *matCellDef=\"let i = index\"> {{i+1}} </td>\r\n    </ng-container>\r\n\r\n    <ng-container matColumnDef=\"name\">\r\n      <th mat-header-cell *matHeaderCellDef> Назва </th>\r\n      <td mat-cell *matCellDef=\"let element\"> {{element.name}} </td>\r\n    </ng-container>\r\n\r\n    <ng-container matColumnDef=\"date\">\r\n      <th mat-header-cell *matHeaderCellDef> Дата створення </th>\r\n      <td mat-cell *matCellDef=\"let element\"> {{element.createdDateUtc | customDate}} </td>\r\n    </ng-container>\r\n\r\n    <ng-container matColumnDef=\"description\">\r\n      <th mat-header-cell *matHeaderCellDef> Опис </th>\r\n      <td mat-cell *matCellDef=\"let element\"> {{element.description}} </td>\r\n    </ng-container>\r\n\r\n    <tr mat-header-row *matHeaderRowDef=\"displayedColumns; sticky: true\"></tr>\r\n    <tr mat-row *matRowDef=\"let row; columns: displayedColumns;\"></tr>\r\n  </table>\r\n  <mat-paginator [length]=\"this.allResourcesCount\" [pageSize]=\"this.columnsPerPage\"\r\n    [pageSizeOptions]=\"this.pageSizeOptions\" showFirstLastButtons (page)=\"pageChanged($event)\">\r\n  </mat-paginator>\r\n</div>");
            /***/ 
        }),
        /***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/general-resources/general-resources-tables/general-resources-table/general-resources-table.component.html": 
        /*!*****************************************************************************************************************************************************************!*\
          !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/general-resources/general-resources-tables/general-resources-table/general-resources-table.component.html ***!
          \*****************************************************************************************************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("<mat-tab-group mat-stretch-tabs class=\"resTab example-stretched-tabs mat-elevation-z4\" *ngIf=\"showCategories\">\r\n    <mat-tab  *ngFor=\"let category of this.resourcesCategories\" label=\"{{category.type}}\">\r\n        <app-general-resources-inner-table [resourcesCategoryId]=\"category.id\">            \r\n        </app-general-resources-inner-table>\r\n    </mat-tab>\r\n</mat-tab-group>");
            /***/ 
        }),
        /***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/home/home.component.html": 
        /*!********************************************************************************!*\
          !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/home/home.component.html ***!
          \********************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("<h1>Main page</h1>\r\n\r\n<img  src=\"/assets/img/uttmm.png\" alt=\"\" clas=\"main-image\">\r\n\r\n");
            /***/ 
        }),
        /***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/project-form/project-form.component.html": 
        /*!************************************************************************************************!*\
          !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/project-form/project-form.component.html ***!
          \************************************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("<h2 mat-dialog-title>\r\n  <span>{{this.service.form.controls['id'].value?\"РЕДАГУВАННЯ ПРОЕКТУ\":\"СТВОРЕННЯ ПРОЕКТУ\"}}</span>\r\n</h2>\r\n<form [formGroup]=\"this.service.form\">\r\n  <mat-dialog-content>\r\n    <mat-form-field>\r\n      <input type=\"hidden\" formControlName=\"id\">\r\n      <input formControlName=\"name\" autofocus required matInput placeholder=\"Назва проекту\">\r\n    </mat-form-field>\r\n    <mat-form-field>\r\n      <input formControlName=\"description\" required matInput placeholder=\"Опис\">\r\n    </mat-form-field>\r\n    <mat-form-field>\r\n      <input formControlName=\"type\" required matInput placeholder=\"Тип\">\r\n    </mat-form-field>\r\n  </mat-dialog-content>\r\n  <mat-dialog-actions>\r\n    <button mat-raised-button color=\"primary\" type=\"submit\" [disabled]=\"this.service.form.invalid\"\r\n      (click)='onSubmit()'>Підтвердити</button>\r\n    <button mat-raised-button color=\"warn\" type=\"reset\" (click)=\"onClose()\">Відмінити</button>\r\n  </mat-dialog-actions>\r\n</form>\r\n");
            /***/ 
        }),
        /***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/project-info/project-info.component.html": 
        /*!************************************************************************************************!*\
          !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/project-info/project-info.component.html ***!
          \************************************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("<div class=\"mainDiv\" >\r\n  <mat-card class=\"example-card\">\r\n    <mat-card-header>\r\n      <div mat-card-avatar class=\"example-header-image\"></div>\r\n      <mat-card-title class=\"headerUpText\">{{projectInfo.name}}</mat-card-title>\r\n      <mat-card-subtitle class=\"headerDownText\">Added by: <a class=\"ownerLink\"\r\n          href=\"http://localhost:4200/project/{{projectInfo.id}}\">Project Owner</a></mat-card-subtitle>\r\n    </mat-card-header>\r\n\r\n    <img mat-card-image class=\"ProjImg\" src=\"../../assets/img/hatiko.gif\" alt=\"Photo\">\r\n    <mat-card-content>\r\n      <p class=\"description\">{{projectInfo.description}}</p>\r\n    </mat-card-content>\r\n  </mat-card>\r\n  <div class=\"bottom-buttons\">\r\n    <button mat-raised-button class=\"resButton\" (click)=\"getResourcesData()\">Ресурси</button>\r\n    <button mat-raised-button class=\"resButton\" (click)=\"onJoin()\">Ресурси</button>\r\n  </div>\r\n  <div >\r\n    <app-resources-table [@openClose]=\"isOpen ? 'open' : 'closed'\" id=\"resTabId\" *ngIf=\"generateOnceResourcesTable\" [sortedResourcesByCategory]=\"sortedResourcesByCategory\"></app-resources-table>\r\n  </div>\r\n</div>\r\n");
            /***/ 
        }),
        /***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/project-info/resources-table-for-project/resources-internal-table/resources-internal-table.component.html": 
        /*!*****************************************************************************************************************************************************************!*\
          !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/project-info/resources-table-for-project/resources-internal-table/resources-internal-table.component.html ***!
          \*****************************************************************************************************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("<div class=\"mat-elevation-z8\">\r\n  <table mat-table [dataSource]='dataSource'>\r\n\r\n\r\n    <ng-container matColumnDef=\"id\">\r\n      <th mat-header-cell *matHeaderCellDef> ID </th>\r\n      <td mat-cell *matCellDef=\"let i = index\"> {{i+1}} </td>\r\n    </ng-container>\r\n\r\n\r\n    <ng-container matColumnDef=\"name\">\r\n      <th mat-header-cell *matHeaderCellDef> Назва </th>\r\n      <td mat-cell *matCellDef=\"let element\"> {{element.name}} </td>\r\n    </ng-container>\r\n\r\n\r\n    <ng-container matColumnDef=\"date\">\r\n      <th mat-header-cell *matHeaderCellDef> Дата створення </th>\r\n      <td mat-cell *matCellDef=\"let element\"> {{element.createdDateUtc | customDate}} </td>\r\n    </ng-container>\r\n\r\n\r\n    <ng-container matColumnDef=\"description\">\r\n      <th mat-header-cell *matHeaderCellDef> Опис </th>\r\n      <td mat-cell *matCellDef=\"let element\"> {{element.description}} </td>\r\n    </ng-container>\r\n\r\n    <tr mat-header-row *matHeaderRowDef=\"displayedColumns; sticky: true\"></tr>\r\n    <tr mat-row *matRowDef=\"let row; columns: displayedColumns;\"></tr>\r\n  </table>\r\n  <mat-paginator [length]=\"lengthDataArrForDataSource\" [pageSize]=\"this.pageSize\"\r\n    [pageSizeOptions]=\"this.pageSizeOptions\" showFirstLastButtons></mat-paginator>\r\n</div>");
            /***/ 
        }),
        /***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/project-info/resources-table-for-project/resources-table/resources-table.component.html": 
        /*!***********************************************************************************************************************************************!*\
          !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/project-info/resources-table-for-project/resources-table/resources-table.component.html ***!
          \***********************************************************************************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("<mat-tab-group mat-stretch-tabs class=\"resTab example-stretched-tabs mat-elevation-z4\" (selectedTabChange)=\"convertMatTabChangeEventLabelToString($event)\">\r\n    <mat-tab  *ngFor=\"let category of this.resourceService.getAllResourceCategories(sortedResourcesByCategory)\" label=\"{{category}}\"  >\r\n        <app-resources-internal-table [dataSource]=\"dataSource\" [lengthDataArrForDataSource]=\"lengthDataArrForDataSource\"></app-resources-internal-table>\r\n    </mat-tab>\r\n</mat-tab-group>");
            /***/ 
        }),
        /***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/project-participants/project-participants.component.html": 
        /*!****************************************************************************************************************!*\
          !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/project-participants/project-participants.component.html ***!
          \****************************************************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("<mat-tab-group animationDuration=\"0ms\" #tabPosition (selectedTabChange)=\"changeTab(tabPosition.selectedIndex)\">\r\n        <mat-tab label=\"Нові\"></mat-tab>\r\n        <mat-tab label=\"Підтверджені\" ></mat-tab>\r\n        <mat-tab label=\"Відхилені\"> </mat-tab>\r\n</mat-tab-group>\r\n<div *ngIf=\"projectParticipationRequest.filteredData.length > 0\">\r\n        <div class=\"mat-elevation-z8\">\r\n                <table mat-table [dataSource]=\"projectParticipationRequest\">\r\n\r\n                        <ng-container matColumnDef=\"createdById\">\r\n                                <th mat-header-cell *matHeaderCellDef> Ім’я/Id</th>\r\n                                <td mat-cell *matCellDef=\"let element\"> {{element.createdById}} </td>\r\n                        </ng-container>\r\n\r\n                        <ng-container matColumnDef=\"role\">\r\n                                <th mat-header-cell *matHeaderCellDef> Роль користувача </th>\r\n                                <td mat-cell *matCellDef=\"let element\"> {{element.role}} </td>\r\n                        </ng-container>\r\n\r\n                        <ng-container matColumnDef=\"projectId\">\r\n                                <th mat-header-cell *matHeaderCellDef> Id проекту </th>\r\n                                <td mat-cell *matCellDef=\"let element\"> {{element.projectId}} </td>\r\n                        </ng-container>\r\n\r\n                        <ng-container matColumnDef=\"status\">\r\n                                <th mat-header-cell *matHeaderCellDef> Статус </th>\r\n                                <td mat-cell *matCellDef=\"let element\"> {{element.status}} </td>\r\n                        </ng-container>\r\n\r\n                        <ng-container matColumnDef=\"actions\">\r\n                                <mat-header-cell *matHeaderCellDef></mat-header-cell>\r\n                                <mat-cell *matCellDef=\"let participationRequest\">\r\n                                        <div *ngIf=\"showActionButtons\">\r\n                                                <span class=\"aproveButton\" >\r\n                                                        <button mat-raised-button \r\n                                                                (click)=\"changeStatus('aproved', participationRequest)\">Прийняти</button>\r\n                                                </span>\r\n                                                <span class=\"rejectButton\">\r\n                                                        <button mat-raised-button\r\n                                                                (click)=\"changeStatus('rejected', participationRequest)\">Відхилити</button>\r\n                                                </span>\r\n                                        </div>\r\n                                </mat-cell>\r\n                        </ng-container>\r\n\r\n                        <tr mat-header-row *matHeaderRowDef=\"displayedColumns\"></tr>\r\n                        <tr mat-row *matRowDef=\"let row; columns: displayedColumns;\"></tr>\r\n                </table>\r\n                <mat-paginator [pageSizeOptions]=\"[5, 10, 20]\" showFirstLastButtons></mat-paginator>\r\n        </div>\r\n</div>\r\n<div *ngIf=\"projectParticipationRequest.filteredData.length === 0\">\r\n        <h1>Немає нових запитів</h1>\r\n</div>\r\n");
            /***/ 
        }),
        /***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/project/project.component.html": 
        /*!**************************************************************************************!*\
          !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/project/project.component.html ***!
          \**************************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("<button mat-stroked-button (click)=\"onCreate()\">\r\n  <mat-icon>add</mat-icon>Створити проект\r\n</button>\r\n<div *ngFor=\"let project of projects\">\r\n  <mat-card class=\"project-card\">\r\n    <mat-card-header class=\"header\">\r\n      <mat-card-title>\r\n        <a mat-button class=\"donate-button\" [routerLink]=\"['/project', project.id]\">Підтримати</a>\r\n      </mat-card-title>\r\n    </mat-card-header>\r\n    <mat-card-title>{{project.name}}</mat-card-title>\r\n    <mat-card-subtitle>Ukraine, id - {{project.id}}</mat-card-subtitle>\r\n    <img class=\"project-image\" mat-card-image\r\n      src=\"http://r.ddmcdn.com/s_f/o_1/cx_462/cy_245/cw_1349/ch_1349/w_720/APL/uploads/2015/06/caturday-shutterstock_149320799.jpg\"\r\n      alt=\"\">\r\n    <mat-card-content>\r\n      <div class=\"project-info\">\r\n        {{project.description}}\r\n        <p>Проект починається: {{project.projectBegin}}</p>\r\n        <p>Проект закінчується: {{project.projectEnd}}</p>\r\n      </div>\r\n    </mat-card-content>\r\n    <div class=\"clear\"></div>\r\n    <mat-card-actions class=\"get-details-button\">\r\n      <a mat-stroked-button [routerLink]=\"['/project', project.id]\">Деталі</a>\r\n      <button mat-stroked-button (click)=\"onEdit()\" >Змінити</button>\r\n    </mat-card-actions>\r\n  </mat-card>\r\n</div>\r\n");
            /***/ 
        }),
        /***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/shared/components/confirm-dialog/confirm-dialog.component.html": 
        /*!**********************************************************************************************************************!*\
          !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/shared/components/confirm-dialog/confirm-dialog.component.html ***!
          \**********************************************************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("<h2 mat-dialog-title >{{data.message}}</h2>\r\n<mat-dialog-actions>\r\n<button mat-flat-button id=\"yes-button\" [mat-dialog-close]=\"true\">ТАК</button>\r\n<button mat-dialog- id=\"no-button\" [mat-dialog-close]=\"false\">НІ</button>\r\n</mat-dialog-actions>\r\n");
            /***/ 
        }),
        /***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/shared/components/error/error.component.html": 
        /*!****************************************************************************************************!*\
          !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/shared/components/error/error.component.html ***!
          \****************************************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("<h2>Error</h2>\r\n<p class=\"text-error\">Упс, трапилася помилка при обробці Вашого запиту =(</p>\r\n<button mat-stroked-buttom (click)=\"goHome()\">Повернутися на головну сторінку</button>");
            /***/ 
        }),
        /***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/toolbar/toolbar.component.html": 
        /*!**************************************************************************************!*\
          !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/toolbar/toolbar.component.html ***!
          \**************************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("<mat-toolbar color=\"primary\">\r\n    <mat-toolbar-row  class=\"toolbar\">\r\n         <a mat-button class=\"toolbar-button\" routerLink=\"\" >Головна</a>\r\n         <a mat-button class=\"toolbar-button\" routerLink=\"/project\" >Проекти</a>  \r\n         <a mat-button class=\"toolbar-button\" routerLink=\"\" >Новини</a> \r\n         <a mat-button class=\"toolbar-button\" routerLink=\"\" >Контакти</a>\r\n         <a mat-button class=\"toolbar-button\" routerLink=\"/resources\" >Ресурси</a>\r\n         <a mat-button class=\"toolbar-button\" routerLink=\"/projectParticipants\" >Запити \r\n         <span ><mat-icon *ngIf=\"hasNotification\">notifications</mat-icon></span></a>         \r\n         <span class=\"fill-space\"></span>      \r\n         <a mat-button class=\"toolbar-button\" routerLink=\"\" >Реєстрація</a>\r\n         <a mat-button class=\"toolbar-button\" routerLink=\"\" >Вхід</a>     \r\n    </mat-toolbar-row >                \r\n  </mat-toolbar>");
            /***/ 
        }),
        /***/ "./node_modules/tslib/tslib.es6.js": 
        /*!*****************************************!*\
          !*** ./node_modules/tslib/tslib.es6.js ***!
          \*****************************************/
        /*! exports provided: __extends, __assign, __rest, __decorate, __param, __metadata, __awaiter, __generator, __exportStar, __values, __read, __spread, __spreadArrays, __await, __asyncGenerator, __asyncDelegator, __asyncValues, __makeTemplateObject, __importStar, __importDefault */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__extends", function () { return __extends; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__assign", function () { return __assign; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__rest", function () { return __rest; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__decorate", function () { return __decorate; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__param", function () { return __param; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__metadata", function () { return __metadata; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__awaiter", function () { return __awaiter; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__generator", function () { return __generator; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__exportStar", function () { return __exportStar; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__values", function () { return __values; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__read", function () { return __read; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__spread", function () { return __spread; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__spreadArrays", function () { return __spreadArrays; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__await", function () { return __await; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__asyncGenerator", function () { return __asyncGenerator; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__asyncDelegator", function () { return __asyncDelegator; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__asyncValues", function () { return __asyncValues; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__makeTemplateObject", function () { return __makeTemplateObject; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__importStar", function () { return __importStar; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__importDefault", function () { return __importDefault; });
            /*! *****************************************************************************
            Copyright (c) Microsoft Corporation. All rights reserved.
            Licensed under the Apache License, Version 2.0 (the "License"); you may not use
            this file except in compliance with the License. You may obtain a copy of the
            License at http://www.apache.org/licenses/LICENSE-2.0
            
            THIS CODE IS PROVIDED ON AN *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
            KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED
            WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE,
            MERCHANTABLITY OR NON-INFRINGEMENT.
            
            See the Apache Version 2.0 License for specific language governing permissions
            and limitations under the License.
            ***************************************************************************** */
            /* global Reflect, Promise */
            var extendStatics = function (d, b) {
                extendStatics = Object.setPrototypeOf ||
                    ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
                    function (d, b) { for (var p in b)
                        if (b.hasOwnProperty(p))
                            d[p] = b[p]; };
                return extendStatics(d, b);
            };
            function __extends(d, b) {
                extendStatics(d, b);
                function __() { this.constructor = d; }
                d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
            }
            var __assign = function () {
                __assign = Object.assign || function __assign(t) {
                    for (var s, i = 1, n = arguments.length; i < n; i++) {
                        s = arguments[i];
                        for (var p in s)
                            if (Object.prototype.hasOwnProperty.call(s, p))
                                t[p] = s[p];
                    }
                    return t;
                };
                return __assign.apply(this, arguments);
            };
            function __rest(s, e) {
                var t = {};
                for (var p in s)
                    if (Object.prototype.hasOwnProperty.call(s, p) && e.indexOf(p) < 0)
                        t[p] = s[p];
                if (s != null && typeof Object.getOwnPropertySymbols === "function")
                    for (var i = 0, p = Object.getOwnPropertySymbols(s); i < p.length; i++) {
                        if (e.indexOf(p[i]) < 0 && Object.prototype.propertyIsEnumerable.call(s, p[i]))
                            t[p[i]] = s[p[i]];
                    }
                return t;
            }
            function __decorate(decorators, target, key, desc) {
                var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
                if (typeof Reflect === "object" && typeof Reflect.decorate === "function")
                    r = Reflect.decorate(decorators, target, key, desc);
                else
                    for (var i = decorators.length - 1; i >= 0; i--)
                        if (d = decorators[i])
                            r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
                return c > 3 && r && Object.defineProperty(target, key, r), r;
            }
            function __param(paramIndex, decorator) {
                return function (target, key) { decorator(target, key, paramIndex); };
            }
            function __metadata(metadataKey, metadataValue) {
                if (typeof Reflect === "object" && typeof Reflect.metadata === "function")
                    return Reflect.metadata(metadataKey, metadataValue);
            }
            function __awaiter(thisArg, _arguments, P, generator) {
                return new (P || (P = Promise))(function (resolve, reject) {
                    function fulfilled(value) { try {
                        step(generator.next(value));
                    }
                    catch (e) {
                        reject(e);
                    } }
                    function rejected(value) { try {
                        step(generator["throw"](value));
                    }
                    catch (e) {
                        reject(e);
                    } }
                    function step(result) { result.done ? resolve(result.value) : new P(function (resolve) { resolve(result.value); }).then(fulfilled, rejected); }
                    step((generator = generator.apply(thisArg, _arguments || [])).next());
                });
            }
            function __generator(thisArg, body) {
                var _ = { label: 0, sent: function () { if (t[0] & 1)
                        throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;
                return g = { next: verb(0), "throw": verb(1), "return": verb(2) }, typeof Symbol === "function" && (g[Symbol.iterator] = function () { return this; }), g;
                function verb(n) { return function (v) { return step([n, v]); }; }
                function step(op) {
                    if (f)
                        throw new TypeError("Generator is already executing.");
                    while (_)
                        try {
                            if (f = 1, y && (t = op[0] & 2 ? y["return"] : op[0] ? y["throw"] || ((t = y["return"]) && t.call(y), 0) : y.next) && !(t = t.call(y, op[1])).done)
                                return t;
                            if (y = 0, t)
                                op = [op[0] & 2, t.value];
                            switch (op[0]) {
                                case 0:
                                case 1:
                                    t = op;
                                    break;
                                case 4:
                                    _.label++;
                                    return { value: op[1], done: false };
                                case 5:
                                    _.label++;
                                    y = op[1];
                                    op = [0];
                                    continue;
                                case 7:
                                    op = _.ops.pop();
                                    _.trys.pop();
                                    continue;
                                default:
                                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) {
                                        _ = 0;
                                        continue;
                                    }
                                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) {
                                        _.label = op[1];
                                        break;
                                    }
                                    if (op[0] === 6 && _.label < t[1]) {
                                        _.label = t[1];
                                        t = op;
                                        break;
                                    }
                                    if (t && _.label < t[2]) {
                                        _.label = t[2];
                                        _.ops.push(op);
                                        break;
                                    }
                                    if (t[2])
                                        _.ops.pop();
                                    _.trys.pop();
                                    continue;
                            }
                            op = body.call(thisArg, _);
                        }
                        catch (e) {
                            op = [6, e];
                            y = 0;
                        }
                        finally {
                            f = t = 0;
                        }
                    if (op[0] & 5)
                        throw op[1];
                    return { value: op[0] ? op[1] : void 0, done: true };
                }
            }
            function __exportStar(m, exports) {
                for (var p in m)
                    if (!exports.hasOwnProperty(p))
                        exports[p] = m[p];
            }
            function __values(o) {
                var m = typeof Symbol === "function" && o[Symbol.iterator], i = 0;
                if (m)
                    return m.call(o);
                return {
                    next: function () {
                        if (o && i >= o.length)
                            o = void 0;
                        return { value: o && o[i++], done: !o };
                    }
                };
            }
            function __read(o, n) {
                var m = typeof Symbol === "function" && o[Symbol.iterator];
                if (!m)
                    return o;
                var i = m.call(o), r, ar = [], e;
                try {
                    while ((n === void 0 || n-- > 0) && !(r = i.next()).done)
                        ar.push(r.value);
                }
                catch (error) {
                    e = { error: error };
                }
                finally {
                    try {
                        if (r && !r.done && (m = i["return"]))
                            m.call(i);
                    }
                    finally {
                        if (e)
                            throw e.error;
                    }
                }
                return ar;
            }
            function __spread() {
                for (var ar = [], i = 0; i < arguments.length; i++)
                    ar = ar.concat(__read(arguments[i]));
                return ar;
            }
            function __spreadArrays() {
                for (var s = 0, i = 0, il = arguments.length; i < il; i++)
                    s += arguments[i].length;
                for (var r = Array(s), k = 0, i = 0; i < il; i++)
                    for (var a = arguments[i], j = 0, jl = a.length; j < jl; j++, k++)
                        r[k] = a[j];
                return r;
            }
            ;
            function __await(v) {
                return this instanceof __await ? (this.v = v, this) : new __await(v);
            }
            function __asyncGenerator(thisArg, _arguments, generator) {
                if (!Symbol.asyncIterator)
                    throw new TypeError("Symbol.asyncIterator is not defined.");
                var g = generator.apply(thisArg, _arguments || []), i, q = [];
                return i = {}, verb("next"), verb("throw"), verb("return"), i[Symbol.asyncIterator] = function () { return this; }, i;
                function verb(n) { if (g[n])
                    i[n] = function (v) { return new Promise(function (a, b) { q.push([n, v, a, b]) > 1 || resume(n, v); }); }; }
                function resume(n, v) { try {
                    step(g[n](v));
                }
                catch (e) {
                    settle(q[0][3], e);
                } }
                function step(r) { r.value instanceof __await ? Promise.resolve(r.value.v).then(fulfill, reject) : settle(q[0][2], r); }
                function fulfill(value) { resume("next", value); }
                function reject(value) { resume("throw", value); }
                function settle(f, v) { if (f(v), q.shift(), q.length)
                    resume(q[0][0], q[0][1]); }
            }
            function __asyncDelegator(o) {
                var i, p;
                return i = {}, verb("next"), verb("throw", function (e) { throw e; }), verb("return"), i[Symbol.iterator] = function () { return this; }, i;
                function verb(n, f) { i[n] = o[n] ? function (v) { return (p = !p) ? { value: __await(o[n](v)), done: n === "return" } : f ? f(v) : v; } : f; }
            }
            function __asyncValues(o) {
                if (!Symbol.asyncIterator)
                    throw new TypeError("Symbol.asyncIterator is not defined.");
                var m = o[Symbol.asyncIterator], i;
                return m ? m.call(o) : (o = typeof __values === "function" ? __values(o) : o[Symbol.iterator](), i = {}, verb("next"), verb("throw"), verb("return"), i[Symbol.asyncIterator] = function () { return this; }, i);
                function verb(n) { i[n] = o[n] && function (v) { return new Promise(function (resolve, reject) { v = o[n](v), settle(resolve, reject, v.done, v.value); }); }; }
                function settle(resolve, reject, d, v) { Promise.resolve(v).then(function (v) { resolve({ value: v, done: d }); }, reject); }
            }
            function __makeTemplateObject(cooked, raw) {
                if (Object.defineProperty) {
                    Object.defineProperty(cooked, "raw", { value: raw });
                }
                else {
                    cooked.raw = raw;
                }
                return cooked;
            }
            ;
            function __importStar(mod) {
                if (mod && mod.__esModule)
                    return mod;
                var result = {};
                if (mod != null)
                    for (var k in mod)
                        if (Object.hasOwnProperty.call(mod, k))
                            result[k] = mod[k];
                result.default = mod;
                return result;
            }
            function __importDefault(mod) {
                return (mod && mod.__esModule) ? mod : { default: mod };
            }
            /***/ 
        }),
        /***/ "./src/app/app-routing.module.ts": 
        /*!***************************************!*\
          !*** ./src/app/app-routing.module.ts ***!
          \***************************************/
        /*! exports provided: AppRoutingModule, routingComponents */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppRoutingModule", function () { return AppRoutingModule; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "routingComponents", function () { return routingComponents; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
            /* harmony import */ var _project_project_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./project/project.component */ "./src/app/project/project.component.ts");
            /* harmony import */ var _home_home_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./home/home.component */ "./src/app/home/home.component.ts");
            /* harmony import */ var _project_info_project_info_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./project-info/project-info.component */ "./src/app/project-info/project-info.component.ts");
            /* harmony import */ var _project_participants_project_participants_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./project-participants/project-participants.component */ "./src/app/project-participants/project-participants.component.ts");
            /* harmony import */ var _general_resources_general_resources_tables_general_resources_table_general_resources_table_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./general-resources/general-resources-tables/general-resources-table/general-resources-table.component */ "./src/app/general-resources/general-resources-tables/general-resources-table/general-resources-table.component.ts");
            /* harmony import */ var _shared_components_error_error_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./shared/components/error/error.component */ "./src/app/shared/components/error/error.component.ts");
            var routes = [
                { path: '', component: _home_home_component__WEBPACK_IMPORTED_MODULE_4__["HomeComponent"] },
                { path: 'projectParticipants', component: _project_participants_project_participants_component__WEBPACK_IMPORTED_MODULE_6__["ProjectParticipantsComponent"] },
                { path: 'project/:id', component: _project_info_project_info_component__WEBPACK_IMPORTED_MODULE_5__["ProjectInfoComponent"] },
                { path: 'project', component: _project_project_component__WEBPACK_IMPORTED_MODULE_3__["ProjectComponent"] },
                { path: 'resources', component: _general_resources_general_resources_tables_general_resources_table_general_resources_table_component__WEBPACK_IMPORTED_MODULE_7__["GeneralResourcesTableComponent"] },
                { path: 'error', component: _shared_components_error_error_component__WEBPACK_IMPORTED_MODULE_8__["ErrorComponent"] },
            ];
            var AppRoutingModule = /** @class */ (function () {
                function AppRoutingModule() {
                }
                return AppRoutingModule;
            }());
            AppRoutingModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
                    imports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"].forRoot(routes)],
                    exports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"]],
                })
            ], AppRoutingModule);
            var routingComponents = [
                _project_participants_project_participants_component__WEBPACK_IMPORTED_MODULE_6__["ProjectParticipantsComponent"], _project_project_component__WEBPACK_IMPORTED_MODULE_3__["ProjectComponent"], _home_home_component__WEBPACK_IMPORTED_MODULE_4__["HomeComponent"], _project_info_project_info_component__WEBPACK_IMPORTED_MODULE_5__["ProjectInfoComponent"],
                _shared_components_error_error_component__WEBPACK_IMPORTED_MODULE_8__["ErrorComponent"]
            ];
            /***/ 
        }),
        /***/ "./src/app/app.component.less": 
        /*!************************************!*\
          !*** ./src/app/app.component.less ***!
          \************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = (".title {\n  text-align: right;\n}\n.main-icon {\n  float: left;\n  width: 20%;\n  height: 100px;\n  text-align: left;\n}\n.header {\n  float: left;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvRDovR0lUL1RoZXJhTGFuZy9UaGVyYUxhbmcvZXhhbXBsZXMvTXZjV2ViL0NsaWVudEFwcC9zcmMvYXBwL2FwcC5jb21wb25lbnQubGVzcyIsInNyYy9hcHAvYXBwLmNvbXBvbmVudC5sZXNzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0ksaUJBQUE7QUNDSjtBRENBO0VBQ0ksV0FBQTtFQUNBLFVBQUE7RUFDQSxhQUFBO0VBQ0EsZ0JBQUE7QUNDSjtBREVBO0VBQ0ksV0FBQTtBQ0FKIiwiZmlsZSI6InNyYy9hcHAvYXBwLmNvbXBvbmVudC5sZXNzIiwic291cmNlc0NvbnRlbnQiOlsiLnRpdGxle1xuICAgIHRleHQtYWxpZ246IHJpZ2h0O1xufVxuLm1haW4taWNvbntcbiAgICBmbG9hdDogbGVmdDtcbiAgICB3aWR0aDogMjAlO1xuICAgIGhlaWdodDogMTAwcHg7XG4gICAgdGV4dC1hbGlnbjogbGVmdDtcbn1cblxuLmhlYWRlcntcbiAgICBmbG9hdDogbGVmdDtcbn0iLCIudGl0bGUge1xuICB0ZXh0LWFsaWduOiByaWdodDtcbn1cbi5tYWluLWljb24ge1xuICBmbG9hdDogbGVmdDtcbiAgd2lkdGg6IDIwJTtcbiAgaGVpZ2h0OiAxMDBweDtcbiAgdGV4dC1hbGlnbjogbGVmdDtcbn1cbi5oZWFkZXIge1xuICBmbG9hdDogbGVmdDtcbn1cbiJdfQ== */");
            /***/ 
        }),
        /***/ "./src/app/app.component.ts": 
        /*!**********************************!*\
          !*** ./src/app/app.component.ts ***!
          \**********************************/
        /*! exports provided: AppComponent */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppComponent", function () { return AppComponent; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            var AppComponent = /** @class */ (function () {
                function AppComponent() {
                    this.title = 'UTTMM';
                }
                return AppComponent;
            }());
            AppComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
                    selector: 'app-root',
                    template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./app.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/app.component.html")).default,
                    styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./app.component.less */ "./src/app/app.component.less")).default]
                })
            ], AppComponent);
            /***/ 
        }),
        /***/ "./src/app/app.module.ts": 
        /*!*******************************!*\
          !*** ./src/app/app.module.ts ***!
          \*******************************/
        /*! exports provided: AppModule */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppModule", function () { return AppModule; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser */ "./node_modules/@angular/platform-browser/fesm2015/platform-browser.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm2015/material.js");
            /* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
            /* harmony import */ var _app_routing_module__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./app-routing.module */ "./src/app/app-routing.module.ts");
            /* harmony import */ var _app_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./app.component */ "./src/app/app.component.ts");
            /* harmony import */ var _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @angular/platform-browser/animations */ "./node_modules/@angular/platform-browser/fesm2015/animations.js");
            /* harmony import */ var _toolbar_toolbar_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./toolbar/toolbar.component */ "./src/app/toolbar/toolbar.component.ts");
            /* harmony import */ var _project_project_component__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./project/project.component */ "./src/app/project/project.component.ts");
            /* harmony import */ var _home_home_component__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ./home/home.component */ "./src/app/home/home.component.ts");
            /* harmony import */ var _project_info_project_info_component__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ./project-info/project-info.component */ "./src/app/project-info/project-info.component.ts");
            /* harmony import */ var _project_form_project_form_component__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ./project-form/project-form.component */ "./src/app/project-form/project-form.component.ts");
            /* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm2015/forms.js");
            /* harmony import */ var _angular_material_form_field__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! @angular/material/form-field */ "./node_modules/@angular/material/esm2015/form-field.js");
            /* harmony import */ var _angular_material_table__WEBPACK_IMPORTED_MODULE_15__ = __webpack_require__(/*! @angular/material/table */ "./node_modules/@angular/material/esm2015/table.js");
            /* harmony import */ var _angular_material_tabs__WEBPACK_IMPORTED_MODULE_16__ = __webpack_require__(/*! @angular/material/tabs */ "./node_modules/@angular/material/esm2015/tabs.js");
            /* harmony import */ var _angular_material_card__WEBPACK_IMPORTED_MODULE_17__ = __webpack_require__(/*! @angular/material/card */ "./node_modules/@angular/material/esm2015/card.js");
            /* harmony import */ var _angular_material_grid_list__WEBPACK_IMPORTED_MODULE_18__ = __webpack_require__(/*! @angular/material/grid-list */ "./node_modules/@angular/material/esm2015/grid-list.js");
            /* harmony import */ var _angular_material_paginator__WEBPACK_IMPORTED_MODULE_19__ = __webpack_require__(/*! @angular/material/paginator */ "./node_modules/@angular/material/esm2015/paginator.js");
            /* harmony import */ var _angular_cdk_portal__WEBPACK_IMPORTED_MODULE_20__ = __webpack_require__(/*! @angular/cdk/portal */ "./node_modules/@angular/cdk/esm2015/portal.js");
            /* harmony import */ var _angular_cdk_a11y__WEBPACK_IMPORTED_MODULE_21__ = __webpack_require__(/*! @angular/cdk/a11y */ "./node_modules/@angular/cdk/esm2015/a11y.js");
            /* harmony import */ var _angular_cdk_stepper__WEBPACK_IMPORTED_MODULE_22__ = __webpack_require__(/*! @angular/cdk/stepper */ "./node_modules/@angular/cdk/esm2015/stepper.js");
            /* harmony import */ var _angular_cdk_table__WEBPACK_IMPORTED_MODULE_23__ = __webpack_require__(/*! @angular/cdk/table */ "./node_modules/@angular/cdk/esm2015/table.js");
            /* harmony import */ var _angular_cdk_tree__WEBPACK_IMPORTED_MODULE_24__ = __webpack_require__(/*! @angular/cdk/tree */ "./node_modules/@angular/cdk/esm2015/tree.js");
            /* harmony import */ var _angular_cdk_scrolling__WEBPACK_IMPORTED_MODULE_25__ = __webpack_require__(/*! @angular/cdk/scrolling */ "./node_modules/@angular/cdk/esm2015/scrolling.js");
            /* harmony import */ var _angular_cdk_drag_drop__WEBPACK_IMPORTED_MODULE_26__ = __webpack_require__(/*! @angular/cdk/drag-drop */ "./node_modules/@angular/cdk/esm2015/drag-drop.js");
            /* harmony import */ var _footer_footer_component__WEBPACK_IMPORTED_MODULE_27__ = __webpack_require__(/*! ./footer/footer.component */ "./src/app/footer/footer.component.ts");
            /* harmony import */ var _project_participants_project_participants_component__WEBPACK_IMPORTED_MODULE_28__ = __webpack_require__(/*! ./project-participants/project-participants.component */ "./src/app/project-participants/project-participants.component.ts");
            /* harmony import */ var _project_participants_event_service__WEBPACK_IMPORTED_MODULE_29__ = __webpack_require__(/*! ./project-participants/event-service */ "./src/app/project-participants/event-service.ts");
            /* harmony import */ var _project_http_service__WEBPACK_IMPORTED_MODULE_30__ = __webpack_require__(/*! ./project/http.service */ "./src/app/project/http.service.ts");
            /* harmony import */ var _shared_pipes_custom_datepipe__WEBPACK_IMPORTED_MODULE_31__ = __webpack_require__(/*! ./shared/pipes/custom.datepipe */ "./src/app/shared/pipes/custom.datepipe.ts");
            /* harmony import */ var _project_info_resources_table_for_project_resources_internal_table_resources_internal_table_component__WEBPACK_IMPORTED_MODULE_32__ = __webpack_require__(/*! ./project-info/resources-table-for-project/resources-internal-table/resources-internal-table.component */ "./src/app/project-info/resources-table-for-project/resources-internal-table/resources-internal-table.component.ts");
            /* harmony import */ var _project_info_resources_table_for_project_resources_table_resource_service__WEBPACK_IMPORTED_MODULE_33__ = __webpack_require__(/*! ./project-info/resources-table-for-project/resources-table/resource.service */ "./src/app/project-info/resources-table-for-project/resources-table/resource.service.ts");
            /* harmony import */ var _general_resources_general_resources_tables_general_resources_table_general_resources_table_component__WEBPACK_IMPORTED_MODULE_34__ = __webpack_require__(/*! ./general-resources/general-resources-tables/general-resources-table/general-resources-table.component */ "./src/app/general-resources/general-resources-tables/general-resources-table/general-resources-table.component.ts");
            /* harmony import */ var _general_resources_general_resources_tables_general_resources_inner_table_general_resources_inner_table_component__WEBPACK_IMPORTED_MODULE_35__ = __webpack_require__(/*! ./general-resources/general-resources-tables/general-resources-inner-table/general-resources-inner-table.component */ "./src/app/general-resources/general-resources-tables/general-resources-inner-table/general-resources-inner-table.component.ts");
            /* harmony import */ var _project_info_resources_table_for_project_resources_table_resource_categories_service__WEBPACK_IMPORTED_MODULE_36__ = __webpack_require__(/*! ./project-info/resources-table-for-project/resources-table/resource-categories.service */ "./src/app/project-info/resources-table-for-project/resources-table/resource-categories.service.ts");
            /* harmony import */ var _shared_components_confirm_dialog_confirm_dialog_component__WEBPACK_IMPORTED_MODULE_37__ = __webpack_require__(/*! ./shared/components/confirm-dialog/confirm-dialog.component */ "./src/app/shared/components/confirm-dialog/confirm-dialog.component.ts");
            /* harmony import */ var _shared_components_error_error_component__WEBPACK_IMPORTED_MODULE_38__ = __webpack_require__(/*! ./shared/components/error/error.component */ "./src/app/shared/components/error/error.component.ts");
            /* harmony import */ var _shared_services_error_handler_service__WEBPACK_IMPORTED_MODULE_39__ = __webpack_require__(/*! ./shared/services/error-handler.service */ "./src/app/shared/services/error-handler.service.ts");
            /* harmony import */ var _shared_services_notification_service__WEBPACK_IMPORTED_MODULE_40__ = __webpack_require__(/*! ./shared/services/notification.service */ "./src/app/shared/services/notification.service.ts");
            /* harmony import */ var _shared_services_dialog_service__WEBPACK_IMPORTED_MODULE_41__ = __webpack_require__(/*! ./shared/services/dialog.service */ "./src/app/shared/services/dialog.service.ts");
            /* harmony import */ var _project_info_resources_table_for_project_resources_table_resources_table_component__WEBPACK_IMPORTED_MODULE_42__ = __webpack_require__(/*! ./project-info/resources-table-for-project/resources-table/resources-table.component */ "./src/app/project-info/resources-table-for-project/resources-table/resources-table.component.ts");
            var AppModule = /** @class */ (function () {
                function AppModule() {
                }
                return AppModule;
            }());
            AppModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["NgModule"])({
                    declarations: [
                        _app_component__WEBPACK_IMPORTED_MODULE_6__["AppComponent"],
                        _app_routing_module__WEBPACK_IMPORTED_MODULE_5__["routingComponents"],
                        _toolbar_toolbar_component__WEBPACK_IMPORTED_MODULE_8__["ToolbarComponent"],
                        _project_project_component__WEBPACK_IMPORTED_MODULE_9__["ProjectComponent"],
                        _project_form_project_form_component__WEBPACK_IMPORTED_MODULE_12__["ProjectFormComponent"],
                        _project_info_project_info_component__WEBPACK_IMPORTED_MODULE_11__["ProjectInfoComponent"],
                        _project_form_project_form_component__WEBPACK_IMPORTED_MODULE_12__["ProjectFormComponent"],
                        _footer_footer_component__WEBPACK_IMPORTED_MODULE_27__["FooterComponent"],
                        _project_participants_project_participants_component__WEBPACK_IMPORTED_MODULE_28__["ProjectParticipantsComponent"],
                        _shared_pipes_custom_datepipe__WEBPACK_IMPORTED_MODULE_31__["CustomDatePipe"],
                        _project_info_resources_table_for_project_resources_internal_table_resources_internal_table_component__WEBPACK_IMPORTED_MODULE_32__["ResourcesInternalTableComponent"],
                        _general_resources_general_resources_tables_general_resources_table_general_resources_table_component__WEBPACK_IMPORTED_MODULE_34__["GeneralResourcesTableComponent"],
                        _general_resources_general_resources_tables_general_resources_inner_table_general_resources_inner_table_component__WEBPACK_IMPORTED_MODULE_35__["GeneralResourcesInnerTableComponent"],
                        _shared_components_confirm_dialog_confirm_dialog_component__WEBPACK_IMPORTED_MODULE_37__["ConfirmDialogComponent"],
                        _shared_components_error_error_component__WEBPACK_IMPORTED_MODULE_38__["ErrorComponent"],
                        _home_home_component__WEBPACK_IMPORTED_MODULE_10__["HomeComponent"],
                        _project_info_resources_table_for_project_resources_table_resources_table_component__WEBPACK_IMPORTED_MODULE_42__["ResourcesTableComponent"]
                    ],
                    entryComponents: [_project_form_project_form_component__WEBPACK_IMPORTED_MODULE_12__["ProjectFormComponent"], _project_info_resources_table_for_project_resources_internal_table_resources_internal_table_component__WEBPACK_IMPORTED_MODULE_32__["ResourcesInternalTableComponent"], _shared_components_confirm_dialog_confirm_dialog_component__WEBPACK_IMPORTED_MODULE_37__["ConfirmDialogComponent"]],
                    imports: [
                        _angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__["BrowserModule"],
                        _app_routing_module__WEBPACK_IMPORTED_MODULE_5__["AppRoutingModule"],
                        _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_7__["BrowserAnimationsModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatToolbarModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatButtonModule"],
                        _angular_common_http__WEBPACK_IMPORTED_MODULE_4__["HttpClientModule"],
                        _angular_material_card__WEBPACK_IMPORTED_MODULE_17__["MatCardModule"],
                        _angular_forms__WEBPACK_IMPORTED_MODULE_13__["FormsModule"],
                        _angular_forms__WEBPACK_IMPORTED_MODULE_13__["ReactiveFormsModule"],
                        _angular_material_grid_list__WEBPACK_IMPORTED_MODULE_18__["MatGridListModule"],
                        _angular_material_form_field__WEBPACK_IMPORTED_MODULE_14__["MatFormFieldModule"],
                        _angular_material_tabs__WEBPACK_IMPORTED_MODULE_16__["MatTabsModule"],
                        _angular_material_table__WEBPACK_IMPORTED_MODULE_15__["MatTableModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatProgressSpinnerModule"],
                        _angular_material_paginator__WEBPACK_IMPORTED_MODULE_19__["MatPaginatorModule"],
                        _angular_cdk_a11y__WEBPACK_IMPORTED_MODULE_21__["A11yModule"],
                        _angular_cdk_stepper__WEBPACK_IMPORTED_MODULE_22__["CdkStepperModule"],
                        _angular_cdk_table__WEBPACK_IMPORTED_MODULE_23__["CdkTableModule"],
                        _angular_cdk_tree__WEBPACK_IMPORTED_MODULE_24__["CdkTreeModule"],
                        _angular_cdk_drag_drop__WEBPACK_IMPORTED_MODULE_26__["DragDropModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatAutocompleteModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatBadgeModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatBottomSheetModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatButtonModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatButtonToggleModule"],
                        _angular_material_card__WEBPACK_IMPORTED_MODULE_17__["MatCardModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatCheckboxModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatChipsModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatStepperModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatDatepickerModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatDialogModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatDividerModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatExpansionModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatIconModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatInputModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatListModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatMenuModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatNativeDateModule"],
                        _angular_material_paginator__WEBPACK_IMPORTED_MODULE_19__["MatPaginatorModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatProgressBarModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatProgressSpinnerModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatRadioModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatRippleModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatSelectModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatSidenavModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatSliderModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatSlideToggleModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatSnackBarModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatSortModule"],
                        _angular_material_table__WEBPACK_IMPORTED_MODULE_15__["MatTableModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatToolbarModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatTooltipModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatTreeModule"],
                        _angular_cdk_portal__WEBPACK_IMPORTED_MODULE_20__["PortalModule"],
                        _angular_cdk_scrolling__WEBPACK_IMPORTED_MODULE_25__["ScrollingModule"],
                    ],
                    exports: [_project_info_resources_table_for_project_resources_internal_table_resources_internal_table_component__WEBPACK_IMPORTED_MODULE_32__["ResourcesInternalTableComponent"], _general_resources_general_resources_tables_general_resources_table_general_resources_table_component__WEBPACK_IMPORTED_MODULE_34__["GeneralResourcesTableComponent"]],
                    providers: [_project_info_resources_table_for_project_resources_table_resource_service__WEBPACK_IMPORTED_MODULE_33__["ResourceService"],
                        _project_http_service__WEBPACK_IMPORTED_MODULE_30__["HttpService"],
                        _project_participants_event_service__WEBPACK_IMPORTED_MODULE_29__["EventService"],
                        { provide: _angular_core__WEBPACK_IMPORTED_MODULE_2__["ErrorHandler"], useClass: _shared_services_error_handler_service__WEBPACK_IMPORTED_MODULE_39__["ErrorHandlerService"] },
                        _shared_services_notification_service__WEBPACK_IMPORTED_MODULE_40__["NotificationService"],
                        _shared_services_dialog_service__WEBPACK_IMPORTED_MODULE_41__["DialogService"],
                        _project_info_resources_table_for_project_resources_table_resource_categories_service__WEBPACK_IMPORTED_MODULE_36__["ResourceCategoriesService"]
                    ],
                    bootstrap: [_app_component__WEBPACK_IMPORTED_MODULE_6__["AppComponent"]]
                })
            ], AppModule);
            /***/ 
        }),
        /***/ "./src/app/footer/footer.component.less": 
        /*!**********************************************!*\
          !*** ./src/app/footer/footer.component.less ***!
          \**********************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = (".footerBlock {\n  min-height: 64px;\n  background-color: purple;\n  padding: 10px;\n  margin-top: 4rem;\n  box-shadow: 0 2px 4px 5px rgba(0, 0, 0, 0.2), 0 4px 5px 0 rgba(0, 0, 0, 0.14), 0 1px 10px 0 rgba(0, 0, 0, 0.12);\n}\n.fixedMainBlock {\n  display: block;\n  margin-left: auto;\n  margin-right: auto;\n  max-width: 1200px;\n  min-height: 54px;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvZm9vdGVyL0Q6L0dJVC9UaGVyYUxhbmcvVGhlcmFMYW5nL2V4YW1wbGVzL012Y1dlYi9DbGllbnRBcHAvc3JjL2FwcC9mb290ZXIvZm9vdGVyLmNvbXBvbmVudC5sZXNzIiwic3JjL2FwcC9mb290ZXIvZm9vdGVyLmNvbXBvbmVudC5sZXNzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0EsZ0JBQUE7RUFDQSx3QkFBQTtFQUNBLGFBQUE7RUFDQSxnQkFBQTtFQUVBLCtHQUFBO0FDQUE7QURHQTtFQUNJLGNBQUE7RUFDQSxpQkFBQTtFQUNBLGtCQUFBO0VBQ0EsaUJBQUE7RUFDQSxnQkFBQTtBQ0RKIiwiZmlsZSI6InNyYy9hcHAvZm9vdGVyL2Zvb3Rlci5jb21wb25lbnQubGVzcyIsInNvdXJjZXNDb250ZW50IjpbIi5mb290ZXJCbG9ja3tcbm1pbi1oZWlnaHQ6IDY0cHg7XG5iYWNrZ3JvdW5kLWNvbG9yOiBwdXJwbGU7XG5wYWRkaW5nOiAxMHB4O1xubWFyZ2luLXRvcDogNHJlbTtcblxuYm94LXNoYWRvdzogMCAycHggNHB4IDVweCByZ2JhKDAsMCwwLC4yKSwwIDRweCA1cHggMCByZ2JhKDAsMCwwLC4xNCksMCAxcHggMTBweCAwXG5yZ2JhKDAsMCwwLC4xMik7XG59XG4uZml4ZWRNYWluQmxvY2t7XG4gICAgZGlzcGxheTogYmxvY2s7XG4gICAgbWFyZ2luLWxlZnQ6IGF1dG87XG4gICAgbWFyZ2luLXJpZ2h0OiBhdXRvO1xuICAgIG1heC13aWR0aDogMTIwMHB4O1xuICAgIG1pbi1oZWlnaHQ6IDU0cHg7XG59IiwiLmZvb3RlckJsb2NrIHtcbiAgbWluLWhlaWdodDogNjRweDtcbiAgYmFja2dyb3VuZC1jb2xvcjogcHVycGxlO1xuICBwYWRkaW5nOiAxMHB4O1xuICBtYXJnaW4tdG9wOiA0cmVtO1xuICBib3gtc2hhZG93OiAwIDJweCA0cHggNXB4IHJnYmEoMCwgMCwgMCwgMC4yKSwgMCA0cHggNXB4IDAgcmdiYSgwLCAwLCAwLCAwLjE0KSwgMCAxcHggMTBweCAwIHJnYmEoMCwgMCwgMCwgMC4xMik7XG59XG4uZml4ZWRNYWluQmxvY2sge1xuICBkaXNwbGF5OiBibG9jaztcbiAgbWFyZ2luLWxlZnQ6IGF1dG87XG4gIG1hcmdpbi1yaWdodDogYXV0bztcbiAgbWF4LXdpZHRoOiAxMjAwcHg7XG4gIG1pbi1oZWlnaHQ6IDU0cHg7XG59XG4iXX0= */");
            /***/ 
        }),
        /***/ "./src/app/footer/footer.component.ts": 
        /*!********************************************!*\
          !*** ./src/app/footer/footer.component.ts ***!
          \********************************************/
        /*! exports provided: FooterComponent */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "FooterComponent", function () { return FooterComponent; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            var FooterComponent = /** @class */ (function () {
                function FooterComponent() {
                }
                FooterComponent.prototype.ngOnInit = function () {
                };
                return FooterComponent;
            }());
            FooterComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
                    selector: 'app-footer',
                    template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./footer.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/footer/footer.component.html")).default,
                    styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./footer.component.less */ "./src/app/footer/footer.component.less")).default]
                })
            ], FooterComponent);
            /***/ 
        }),
        /***/ "./src/app/general-resources/general-resources-tables/general-resources-inner-table/general-resources-inner-table.component.less": 
        /*!***************************************************************************************************************************************!*\
          !*** ./src/app/general-resources/general-resources-tables/general-resources-inner-table/general-resources-inner-table.component.less ***!
          \***************************************************************************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("table {\n  width: 100%;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvZ2VuZXJhbC1yZXNvdXJjZXMvZ2VuZXJhbC1yZXNvdXJjZXMtdGFibGVzL2dlbmVyYWwtcmVzb3VyY2VzLWlubmVyLXRhYmxlL0Q6L0dJVC9UaGVyYUxhbmcvVGhlcmFMYW5nL2V4YW1wbGVzL012Y1dlYi9DbGllbnRBcHAvc3JjL2FwcC9nZW5lcmFsLXJlc291cmNlcy9nZW5lcmFsLXJlc291cmNlcy10YWJsZXMvZ2VuZXJhbC1yZXNvdXJjZXMtaW5uZXItdGFibGUvZ2VuZXJhbC1yZXNvdXJjZXMtaW5uZXItdGFibGUuY29tcG9uZW50Lmxlc3MiLCJzcmMvYXBwL2dlbmVyYWwtcmVzb3VyY2VzL2dlbmVyYWwtcmVzb3VyY2VzLXRhYmxlcy9nZW5lcmFsLXJlc291cmNlcy1pbm5lci10YWJsZS9nZW5lcmFsLXJlc291cmNlcy1pbm5lci10YWJsZS5jb21wb25lbnQubGVzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQTtFQUNJLFdBQUE7QUNDSiIsImZpbGUiOiJzcmMvYXBwL2dlbmVyYWwtcmVzb3VyY2VzL2dlbmVyYWwtcmVzb3VyY2VzLXRhYmxlcy9nZW5lcmFsLXJlc291cmNlcy1pbm5lci10YWJsZS9nZW5lcmFsLXJlc291cmNlcy1pbm5lci10YWJsZS5jb21wb25lbnQubGVzcyIsInNvdXJjZXNDb250ZW50IjpbInRhYmxle1xuICAgIHdpZHRoOiAxMDAlO1xufSIsInRhYmxlIHtcbiAgd2lkdGg6IDEwMCU7XG59XG4iXX0= */");
            /***/ 
        }),
        /***/ "./src/app/general-resources/general-resources-tables/general-resources-inner-table/general-resources-inner-table.component.ts": 
        /*!*************************************************************************************************************************************!*\
          !*** ./src/app/general-resources/general-resources-tables/general-resources-inner-table/general-resources-inner-table.component.ts ***!
          \*************************************************************************************************************************************/
        /*! exports provided: GeneralResourcesInnerTableComponent */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "GeneralResourcesInnerTableComponent", function () { return GeneralResourcesInnerTableComponent; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm2015/material.js");
            /* harmony import */ var src_app_project_info_resources_table_for_project_resources_table_resource_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! src/app/project-info/resources-table-for-project/resources-table/resource.service */ "./src/app/project-info/resources-table-for-project/resources-table/resource.service.ts");
            /* harmony import */ var _shared_constants_resources_table__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../../../shared/constants/resources-table */ "./src/app/shared/constants/resources-table.ts");
            var GeneralResourcesInnerTableComponent = /** @class */ (function () {
                function GeneralResourcesInnerTableComponent(resourceService) {
                    this.resourceService = resourceService;
                    this.showTable = false;
                    this.columnsPerPage = _shared_constants_resources_table__WEBPACK_IMPORTED_MODULE_4__["ResourcesTableConstants"].COLUMNS_PER_PAGE;
                    this.pageSizeOptions = _shared_constants_resources_table__WEBPACK_IMPORTED_MODULE_4__["ResourcesTableConstants"].PAGE_SIZE_OPTIONS;
                    this.displayedColumns = ['id', 'name', 'date', 'description'];
                }
                GeneralResourcesInnerTableComponent.prototype.ngOnInit = function () {
                    return tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function () {
                        var _a, _b;
                        return __generator(this, function (_c) {
                            switch (_c.label) {
                                case 0:
                                    _a = this;
                                    return [4 /*yield*/, this.resourceService.getResourcesByCategoryId(this.resourcesCategoryId, _shared_constants_resources_table__WEBPACK_IMPORTED_MODULE_4__["ResourcesTableConstants"].PAGE_NUMBER, _shared_constants_resources_table__WEBPACK_IMPORTED_MODULE_4__["ResourcesTableConstants"].COLUMNS_PER_PAGE)];
                                case 1:
                                    _a.resources = _c.sent();
                                    _b = this;
                                    return [4 /*yield*/, this.resourceService.getResourcesCountByCategoryId(this.resourcesCategoryId)];
                                case 2:
                                    _b.allResourcesCount = _c.sent();
                                    this.dataSource = new _angular_material__WEBPACK_IMPORTED_MODULE_2__["MatTableDataSource"](this.resources);
                                    this.dataSource.paginator = this.paginator;
                                    this.showTable = true;
                                    return [2 /*return*/];
                            }
                        });
                    });
                };
                GeneralResourcesInnerTableComponent.prototype.pageChanged = function (event) {
                    return tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function () {
                        var _a, _b;
                        return __generator(this, function (_c) {
                            switch (_c.label) {
                                case 0:
                                    _a = this;
                                    return [4 /*yield*/, this.resourceService.getResourcesByCategoryId(this.resourcesCategoryId, event.pageIndex + 1, event.pageSize)];
                                case 1:
                                    _a.resources = _c.sent();
                                    _b = this;
                                    return [4 /*yield*/, this.resourceService.getResourcesCountByCategoryId(this.resourcesCategoryId)];
                                case 2:
                                    _b.allResourcesCount = _c.sent();
                                    this.dataSource = new _angular_material__WEBPACK_IMPORTED_MODULE_2__["MatTableDataSource"](this.resources);
                                    this.dataSource.paginator = this.paginator;
                                    return [2 /*return*/];
                            }
                        });
                    });
                };
                return GeneralResourcesInnerTableComponent;
            }());
            GeneralResourcesInnerTableComponent.ctorParameters = function () { return [
                { type: src_app_project_info_resources_table_for_project_resources_table_resource_service__WEBPACK_IMPORTED_MODULE_3__["ResourceService"] }
            ]; };
            tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])()
            ], GeneralResourcesInnerTableComponent.prototype, "resourcesCategoryId", void 0);
            tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])(_angular_material__WEBPACK_IMPORTED_MODULE_2__["MatPaginator"], { static: true })
            ], GeneralResourcesInnerTableComponent.prototype, "paginator", void 0);
            GeneralResourcesInnerTableComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
                    selector: 'app-general-resources-inner-table',
                    template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./general-resources-inner-table.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/general-resources/general-resources-tables/general-resources-inner-table/general-resources-inner-table.component.html")).default,
                    styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./general-resources-inner-table.component.less */ "./src/app/general-resources/general-resources-tables/general-resources-inner-table/general-resources-inner-table.component.less")).default]
                })
            ], GeneralResourcesInnerTableComponent);
            /***/ 
        }),
        /***/ "./src/app/general-resources/general-resources-tables/general-resources-table/general-resources-table.component.less": 
        /*!***************************************************************************************************************************!*\
          !*** ./src/app/general-resources/general-resources-tables/general-resources-table/general-resources-table.component.less ***!
          \***************************************************************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = (".mat-tab-label-content {\n  color: black !important;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvZ2VuZXJhbC1yZXNvdXJjZXMvZ2VuZXJhbC1yZXNvdXJjZXMtdGFibGVzL2dlbmVyYWwtcmVzb3VyY2VzLXRhYmxlL0Q6L0dJVC9UaGVyYUxhbmcvVGhlcmFMYW5nL2V4YW1wbGVzL012Y1dlYi9DbGllbnRBcHAvc3JjL2FwcC9nZW5lcmFsLXJlc291cmNlcy9nZW5lcmFsLXJlc291cmNlcy10YWJsZXMvZ2VuZXJhbC1yZXNvdXJjZXMtdGFibGUvZ2VuZXJhbC1yZXNvdXJjZXMtdGFibGUuY29tcG9uZW50Lmxlc3MiLCJzcmMvYXBwL2dlbmVyYWwtcmVzb3VyY2VzL2dlbmVyYWwtcmVzb3VyY2VzLXRhYmxlcy9nZW5lcmFsLXJlc291cmNlcy10YWJsZS9nZW5lcmFsLXJlc291cmNlcy10YWJsZS5jb21wb25lbnQubGVzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQTtFQUNJLHVCQUFBO0FDQ0oiLCJmaWxlIjoic3JjL2FwcC9nZW5lcmFsLXJlc291cmNlcy9nZW5lcmFsLXJlc291cmNlcy10YWJsZXMvZ2VuZXJhbC1yZXNvdXJjZXMtdGFibGUvZ2VuZXJhbC1yZXNvdXJjZXMtdGFibGUuY29tcG9uZW50Lmxlc3MiLCJzb3VyY2VzQ29udGVudCI6WyIubWF0LXRhYi1sYWJlbC1jb250ZW50IHtcbiAgICBjb2xvcjogYmxhY2sgIWltcG9ydGFudDtcbiAgfSIsIi5tYXQtdGFiLWxhYmVsLWNvbnRlbnQge1xuICBjb2xvcjogYmxhY2sgIWltcG9ydGFudDtcbn1cbiJdfQ== */");
            /***/ 
        }),
        /***/ "./src/app/general-resources/general-resources-tables/general-resources-table/general-resources-table.component.ts": 
        /*!*************************************************************************************************************************!*\
          !*** ./src/app/general-resources/general-resources-tables/general-resources-table/general-resources-table.component.ts ***!
          \*************************************************************************************************************************/
        /*! exports provided: GeneralResourcesTableComponent */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "GeneralResourcesTableComponent", function () { return GeneralResourcesTableComponent; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var src_app_project_info_resources_table_for_project_resources_table_resource_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! src/app/project-info/resources-table-for-project/resources-table/resource.service */ "./src/app/project-info/resources-table-for-project/resources-table/resource.service.ts");
            /* harmony import */ var src_app_project_info_resources_table_for_project_resources_table_resource_categories_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! src/app/project-info/resources-table-for-project/resources-table/resource-categories.service */ "./src/app/project-info/resources-table-for-project/resources-table/resource-categories.service.ts");
            /* harmony import */ var _shared_constants_resources_table__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../../../shared/constants/resources-table */ "./src/app/shared/constants/resources-table.ts");
            var GeneralResourcesTableComponent = /** @class */ (function () {
                function GeneralResourcesTableComponent(resourceService, resourceCategoriesService) {
                    this.resourceService = resourceService;
                    this.resourceCategoriesService = resourceCategoriesService;
                    this.showCategories = false;
                }
                GeneralResourcesTableComponent.prototype.ngOnInit = function () {
                    return tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function () {
                        var _a;
                        return __generator(this, function (_b) {
                            switch (_b.label) {
                                case 0:
                                    _a = this;
                                    return [4 /*yield*/, this.resourceCategoriesService
                                            .getResourceCategories(_shared_constants_resources_table__WEBPACK_IMPORTED_MODULE_4__["ResourcesTableConstants"].WITH_ASSIGNED_RESOURCES)];
                                case 1:
                                    _a.resourcesCategories = _b.sent();
                                    this.showCategories = true;
                                    return [2 /*return*/];
                            }
                        });
                    });
                };
                return GeneralResourcesTableComponent;
            }());
            GeneralResourcesTableComponent.ctorParameters = function () { return [
                { type: src_app_project_info_resources_table_for_project_resources_table_resource_service__WEBPACK_IMPORTED_MODULE_2__["ResourceService"] },
                { type: src_app_project_info_resources_table_for_project_resources_table_resource_categories_service__WEBPACK_IMPORTED_MODULE_3__["ResourceCategoriesService"] }
            ]; };
            GeneralResourcesTableComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
                    selector: 'app-general-resources-table',
                    template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./general-resources-table.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/general-resources/general-resources-tables/general-resources-table/general-resources-table.component.html")).default,
                    encapsulation: _angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewEncapsulation"].None,
                    styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./general-resources-table.component.less */ "./src/app/general-resources/general-resources-tables/general-resources-table/general-resources-table.component.less")).default]
                })
            ], GeneralResourcesTableComponent);
            /***/ 
        }),
        /***/ "./src/app/home/home.component.less": 
        /*!******************************************!*\
          !*** ./src/app/home/home.component.less ***!
          \******************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2hvbWUvaG9tZS5jb21wb25lbnQubGVzcyJ9 */");
            /***/ 
        }),
        /***/ "./src/app/home/home.component.ts": 
        /*!****************************************!*\
          !*** ./src/app/home/home.component.ts ***!
          \****************************************/
        /*! exports provided: HomeComponent */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "HomeComponent", function () { return HomeComponent; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            var HomeComponent = /** @class */ (function () {
                function HomeComponent() {
                }
                HomeComponent.prototype.ngOnInit = function () {
                };
                return HomeComponent;
            }());
            HomeComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
                    selector: 'app-home',
                    template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./home.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/home/home.component.html")).default,
                    styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./home.component.less */ "./src/app/home/home.component.less")).default]
                })
            ], HomeComponent);
            /***/ 
        }),
        /***/ "./src/app/project-form/project-form.component.less": 
        /*!**********************************************************!*\
          !*** ./src/app/project-form/project-form.component.less ***!
          \**********************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3Byb2plY3QtZm9ybS9wcm9qZWN0LWZvcm0uY29tcG9uZW50Lmxlc3MifQ== */");
            /***/ 
        }),
        /***/ "./src/app/project-form/project-form.component.ts": 
        /*!********************************************************!*\
          !*** ./src/app/project-form/project-form.component.ts ***!
          \********************************************************/
        /*! exports provided: ProjectFormComponent */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectFormComponent", function () { return ProjectFormComponent; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm2015/material.js");
            /* harmony import */ var _project_project_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../project/project.service */ "./src/app/project/project.service.ts");
            var ProjectFormComponent = /** @class */ (function () {
                function ProjectFormComponent(dialog, service) {
                    this.dialog = dialog;
                    this.service = service;
                }
                ProjectFormComponent.prototype.ngOnInit = function () {
                };
                ProjectFormComponent.prototype.onClose = function () {
                    this.service.form.reset();
                    this.service.initializeFormGroup();
                    this.dialog.close();
                };
                ProjectFormComponent.prototype.onSubmit = function () {
                    if (this.service.form.invalid) {
                        var controls_1 = this.service.form.controls;
                        Object.keys(controls_1)
                            .forEach(function (controlName) { return controls_1[controlName].markAsTouched(); });
                        return;
                    }
                    else if (!this.service.form.get('id').value) {
                        this.service.addProject(this.service.form.value);
                        this.onClose();
                    }
                    else {
                        this.service.editProject(this.service.form.value);
                        this.onClose();
                    }
                };
                return ProjectFormComponent;
            }());
            ProjectFormComponent.ctorParameters = function () { return [
                { type: _angular_material__WEBPACK_IMPORTED_MODULE_2__["MatDialogRef"] },
                { type: _project_project_service__WEBPACK_IMPORTED_MODULE_3__["ProjectService"] }
            ]; };
            ProjectFormComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
                    selector: 'app-create-project',
                    template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./project-form.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/project-form/project-form.component.html")).default,
                    providers: [_project_project_service__WEBPACK_IMPORTED_MODULE_3__["ProjectService"]],
                    styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./project-form.component.less */ "./src/app/project-form/project-form.component.less")).default]
                })
            ], ProjectFormComponent);
            /***/ 
        }),
        /***/ "./src/app/project-info/project-info.component.less": 
        /*!**********************************************************!*\
          !*** ./src/app/project-info/project-info.component.less ***!
          \**********************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = (".example-card {\n  max-width: 1200px;\n  margin: 0 auto;\n  background-color: gray;\n}\n#resTabId {\n  max-width: 1230px;\n  margin: 0 auto;\n  min-height: 20rem;\n}\napp-resources-table .resTab {\n  border-radius: 25px ;\n}\n.example-header-image {\n  background-image: url('trashcat.jpg');\n  background-size: cover;\n}\n.mat-card-header .mat-card-avatar {\n  display: block;\n}\nmat-card-header .mat-card-header-text {\n  margin-top: 10px;\n}\n.description {\n  text-align: center;\n}\n.mat-tab-label {\n  color: black;\n  min-width: 0px !important;\n}\n.mat-card-avatar {\n  width: 4rem !important;\n  height: 4rem !important;\n  margin-bottom: 1rem;\n}\n.bottom-buttons {\n  max-width: 1230px;\n  text-align: right;\n  margin-left: auto;\n  margin-top: 1rem;\n  margin-bottom: 1rem;\n  margin-right: auto;\n  border-radius: 25px;\n  padding-top: 15px;\n  padding-bottom: 15px;\n  box-shadow: 0 2px 4px 0px rgba(0, 0, 0, 0.2), 0 4px 5px 0 rgba(0, 0, 0, 0.14), 0 1px 10px 0 rgba(0, 0, 0, 0.12);\n}\n.bottom-buttons .resButton {\n  margin-right: 1rem;\n  background-color: green;\n  border-radius: 10px;\n  box-shadow: 0 2px 4px -1px rgba(0, 0, 0, 0.2), 0 4px 5px 0 rgba(0, 0, 0, 0.14), 0 1px 10px 0 rgba(0, 0, 0, 0.12);\n}\n.ownerLink {\n  text-decoration: none !important;\n}\n.description {\n  text-align: justify;\n  font-size: 1.5rem;\n}\n.example-rate-limit-reached {\n  color: #980000;\n  text-align: center;\n}\n.img-title {\n  text-align: justify;\n  word-wrap: break-word;\n  margin: 0;\n}\n.mainDiv .mat-card {\n  border-radius: 25px ;\n}\n.mainDiv {\n  padding-left: 15vw;\n  padding-right: 15vw;\n}\n.mat-tab-header-pagination-disabled .mat-tab-header-pagination-chevron {\n  border-color: rgba(0, 0, 0, 0.62) !important;\n}\n.mainDiv .example-card {\n  box-shadow: 0 2px 4px 0px rgba(0, 0, 0, 0.2), 0 4px 5px 0 rgba(0, 0, 0, 0.14), 0 1px 10px 0 rgba(0, 0, 0, 0.12);\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvcHJvamVjdC1pbmZvL0Q6L0dJVC9UaGVyYUxhbmcvVGhlcmFMYW5nL2V4YW1wbGVzL012Y1dlYi9DbGllbnRBcHAvc3JjL2FwcC9wcm9qZWN0LWluZm8vcHJvamVjdC1pbmZvLmNvbXBvbmVudC5sZXNzIiwic3JjL2FwcC9wcm9qZWN0LWluZm8vcHJvamVjdC1pbmZvLmNvbXBvbmVudC5sZXNzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0UsaUJBQUE7RUFDQSxjQUFBO0VBQ0Esc0JBQUE7QUNDRjtBRENBO0VBQ0UsaUJBQUE7RUFDQSxjQUFBO0VBQ0EsaUJBQUE7QUNDRjtBRENBO0VBQ0Usb0JBQUE7QUNDRjtBRENBO0VBQ0UscUNBQUE7RUFDQSxzQkFBQTtBQ0NGO0FEQ0E7RUFDRSxjQUFBO0FDQ0Y7QURDQTtFQUNFLGdCQUFBO0FDQ0Y7QURDQTtFQUNFLGtCQUFBO0FDQ0Y7QURFQTtFQUNFLFlBQUE7RUFDQSx5QkFBQTtBQ0FGO0FERUE7RUFDRSxzQkFBQTtFQUNBLHVCQUFBO0VBQ0EsbUJBQUE7QUNBRjtBREVBO0VBQ0UsaUJBQUE7RUFDQSxpQkFBQTtFQUNBLGlCQUFBO0VBQ0EsZ0JBQUE7RUFDQSxtQkFBQTtFQUNBLGtCQUFBO0VBQ0EsbUJBQUE7RUFDQSxpQkFBQTtFQUNBLG9CQUFBO0VBQ0EsK0dBQUE7QUNBRjtBREVBO0VBQ0Usa0JBQUE7RUFDQSx1QkFBQTtFQUNBLG1CQUFBO0VBQ0EsZ0hBQUE7QUNBRjtBREdBO0VBQ0UsZ0NBQUE7QUNERjtBREdBO0VBQ0UsbUJBQUE7RUFDQSxpQkFBQTtBQ0RGO0FES0E7RUFDRSxjQUFBO0VBQ0Esa0JBQUE7QUNIRjtBRE1BO0VBQ0UsbUJBQUE7RUFDQSxxQkFBQTtFQUNBLFNBQUE7QUNKRjtBRE9BO0VBQ0Usb0JBQUE7QUNMRjtBRE9BO0VBQ0Usa0JBQUE7RUFDQSxtQkFBQTtBQ0xGO0FEUUE7RUFDRSw0Q0FBQTtBQ05GO0FEU0E7RUFDRSwrR0FBQTtBQ1BGIiwiZmlsZSI6InNyYy9hcHAvcHJvamVjdC1pbmZvL3Byb2plY3QtaW5mby5jb21wb25lbnQubGVzcyIsInNvdXJjZXNDb250ZW50IjpbIi5leGFtcGxlLWNhcmQge1xuICBtYXgtd2lkdGg6IDEyMDBweDtcbiAgbWFyZ2luOiAwIGF1dG87XG4gIGJhY2tncm91bmQtY29sb3I6IGdyYXk7XG59XG4jcmVzVGFiSWR7XG4gIG1heC13aWR0aDogMTIzMHB4O1xuICBtYXJnaW46IDAgYXV0bztcbiAgbWluLWhlaWdodDogMjByZW07XG59XG5hcHAtcmVzb3VyY2VzLXRhYmxlIC5yZXNUYWJ7XG4gIGJvcmRlci1yYWRpdXM6IDI1cHggO1xufVxuLmV4YW1wbGUtaGVhZGVyLWltYWdlIHtcbiAgYmFja2dyb3VuZC1pbWFnZTogdXJsKFwiLi4vLi4vYXNzZXRzL2ltZy90cmFzaGNhdC5qcGdcIik7XG4gIGJhY2tncm91bmQtc2l6ZTogY292ZXI7XG59XG4ubWF0LWNhcmQtaGVhZGVyIC5tYXQtY2FyZC1hdmF0YXJ7XG4gIGRpc3BsYXk6IGJsb2NrOyAgXG59XG5tYXQtY2FyZC1oZWFkZXIgLm1hdC1jYXJkLWhlYWRlci10ZXh0e1xuICBtYXJnaW4tdG9wOiAxMHB4O1xufVxuLmRlc2NyaXB0aW9uIHtcbiAgdGV4dC1hbGlnbjogY2VudGVyO1xufVxuXG4ubWF0LXRhYi1sYWJlbCB7XG4gIGNvbG9yOiBibGFjaztcbiAgbWluLXdpZHRoOiAwcHggIWltcG9ydGFudDtcbn1cbi5tYXQtY2FyZC1hdmF0YXIge1xuICB3aWR0aDogNHJlbSAhaW1wb3J0YW50O1xuICBoZWlnaHQ6IDRyZW0gIWltcG9ydGFudDtcbiAgbWFyZ2luLWJvdHRvbTogMXJlbTtcbn1cbi5ib3R0b20tYnV0dG9ucyB7XG4gIG1heC13aWR0aDogMTIzMHB4O1xuICB0ZXh0LWFsaWduOiByaWdodDtcbiAgbWFyZ2luLWxlZnQ6IGF1dG87XG4gIG1hcmdpbi10b3A6IDFyZW07XG4gIG1hcmdpbi1ib3R0b206IDFyZW07XG4gIG1hcmdpbi1yaWdodDogYXV0bztcbiAgYm9yZGVyLXJhZGl1czogMjVweDtcbiAgcGFkZGluZy10b3A6IDE1cHg7XG4gIHBhZGRpbmctYm90dG9tOiAxNXB4O1xuICBib3gtc2hhZG93OiAwIDJweCA0cHggMHB4IHJnYmEoMCwwLDAsLjIpLDAgNHB4IDVweCAwIHJnYmEoMCwwLDAsLjE0KSwwIDFweCAxMHB4IDAgcmdiYSgwLDAsMCwuMTIpO1xufVxuLmJvdHRvbS1idXR0b25zIC5yZXNCdXR0b257XG4gIG1hcmdpbi1yaWdodDogMXJlbTtcbiAgYmFja2dyb3VuZC1jb2xvcjogZ3JlZW47XG4gIGJvcmRlci1yYWRpdXM6IDEwcHg7XG4gIGJveC1zaGFkb3c6IDAgMnB4IDRweCAtMXB4IHJnYmEoMCwgMCwgMCwgMC4yKSwgMCA0cHggNXB4IDAgcmdiYSgwLCAwLCAwLCAwLjE0KSwgMCAxcHggMTBweCAwIHJnYmEoMCwgMCwgMCwgMC4xMik7XG59XG5cbi5vd25lckxpbmsge1xuICB0ZXh0LWRlY29yYXRpb246IG5vbmUgIWltcG9ydGFudDtcbn1cbi5kZXNjcmlwdGlvbiB7XG4gIHRleHQtYWxpZ246IGp1c3RpZnk7XG4gIGZvbnQtc2l6ZTogMS41cmVtO1xufVxuXG5cbi5leGFtcGxlLXJhdGUtbGltaXQtcmVhY2hlZCB7XG4gIGNvbG9yOiAjOTgwMDAwO1xuICB0ZXh0LWFsaWduOiBjZW50ZXI7XG59XG5cbi5pbWctdGl0bGV7XG4gIHRleHQtYWxpZ246IGp1c3RpZnk7XG4gIHdvcmQtd3JhcDogYnJlYWstd29yZDtcbiAgbWFyZ2luOiAwO1xufVxuXG4ubWFpbkRpdiAubWF0LWNhcmR7XG4gIGJvcmRlci1yYWRpdXM6IDI1cHggO1xufVxuLm1haW5EaXZ7XG4gIHBhZGRpbmctbGVmdDogMTV2dztcbiAgcGFkZGluZy1yaWdodDogMTV2dztcbn1cblxuLm1hdC10YWItaGVhZGVyLXBhZ2luYXRpb24tZGlzYWJsZWQgLm1hdC10YWItaGVhZGVyLXBhZ2luYXRpb24tY2hldnJvbntcbiAgYm9yZGVyLWNvbG9yOiByZ2JhKDAsIDAsIDAsIDAuNjIpICFpbXBvcnRhbnQ7XG59XG5cbi5tYWluRGl2IC5leGFtcGxlLWNhcmR7XG4gIGJveC1zaGFkb3c6IDAgMnB4IDRweCAwcHggcmdiYSgwLCAwLCAwLCAwLjIpLCAwIDRweCA1cHggMCByZ2JhKDAsIDAsIDAsIDAuMTQpLCAwIDFweCAxMHB4IDAgcmdiYSgwLCAwLCAwLCAwLjEyKTtcbn1cblxuIiwiLmV4YW1wbGUtY2FyZCB7XG4gIG1heC13aWR0aDogMTIwMHB4O1xuICBtYXJnaW46IDAgYXV0bztcbiAgYmFja2dyb3VuZC1jb2xvcjogZ3JheTtcbn1cbiNyZXNUYWJJZCB7XG4gIG1heC13aWR0aDogMTIzMHB4O1xuICBtYXJnaW46IDAgYXV0bztcbiAgbWluLWhlaWdodDogMjByZW07XG59XG5hcHAtcmVzb3VyY2VzLXRhYmxlIC5yZXNUYWIge1xuICBib3JkZXItcmFkaXVzOiAyNXB4IDtcbn1cbi5leGFtcGxlLWhlYWRlci1pbWFnZSB7XG4gIGJhY2tncm91bmQtaW1hZ2U6IHVybChcIi4uLy4uL2Fzc2V0cy9pbWcvdHJhc2hjYXQuanBnXCIpO1xuICBiYWNrZ3JvdW5kLXNpemU6IGNvdmVyO1xufVxuLm1hdC1jYXJkLWhlYWRlciAubWF0LWNhcmQtYXZhdGFyIHtcbiAgZGlzcGxheTogYmxvY2s7XG59XG5tYXQtY2FyZC1oZWFkZXIgLm1hdC1jYXJkLWhlYWRlci10ZXh0IHtcbiAgbWFyZ2luLXRvcDogMTBweDtcbn1cbi5kZXNjcmlwdGlvbiB7XG4gIHRleHQtYWxpZ246IGNlbnRlcjtcbn1cbi5tYXQtdGFiLWxhYmVsIHtcbiAgY29sb3I6IGJsYWNrO1xuICBtaW4td2lkdGg6IDBweCAhaW1wb3J0YW50O1xufVxuLm1hdC1jYXJkLWF2YXRhciB7XG4gIHdpZHRoOiA0cmVtICFpbXBvcnRhbnQ7XG4gIGhlaWdodDogNHJlbSAhaW1wb3J0YW50O1xuICBtYXJnaW4tYm90dG9tOiAxcmVtO1xufVxuLmJvdHRvbS1idXR0b25zIHtcbiAgbWF4LXdpZHRoOiAxMjMwcHg7XG4gIHRleHQtYWxpZ246IHJpZ2h0O1xuICBtYXJnaW4tbGVmdDogYXV0bztcbiAgbWFyZ2luLXRvcDogMXJlbTtcbiAgbWFyZ2luLWJvdHRvbTogMXJlbTtcbiAgbWFyZ2luLXJpZ2h0OiBhdXRvO1xuICBib3JkZXItcmFkaXVzOiAyNXB4O1xuICBwYWRkaW5nLXRvcDogMTVweDtcbiAgcGFkZGluZy1ib3R0b206IDE1cHg7XG4gIGJveC1zaGFkb3c6IDAgMnB4IDRweCAwcHggcmdiYSgwLCAwLCAwLCAwLjIpLCAwIDRweCA1cHggMCByZ2JhKDAsIDAsIDAsIDAuMTQpLCAwIDFweCAxMHB4IDAgcmdiYSgwLCAwLCAwLCAwLjEyKTtcbn1cbi5ib3R0b20tYnV0dG9ucyAucmVzQnV0dG9uIHtcbiAgbWFyZ2luLXJpZ2h0OiAxcmVtO1xuICBiYWNrZ3JvdW5kLWNvbG9yOiBncmVlbjtcbiAgYm9yZGVyLXJhZGl1czogMTBweDtcbiAgYm94LXNoYWRvdzogMCAycHggNHB4IC0xcHggcmdiYSgwLCAwLCAwLCAwLjIpLCAwIDRweCA1cHggMCByZ2JhKDAsIDAsIDAsIDAuMTQpLCAwIDFweCAxMHB4IDAgcmdiYSgwLCAwLCAwLCAwLjEyKTtcbn1cbi5vd25lckxpbmsge1xuICB0ZXh0LWRlY29yYXRpb246IG5vbmUgIWltcG9ydGFudDtcbn1cbi5kZXNjcmlwdGlvbiB7XG4gIHRleHQtYWxpZ246IGp1c3RpZnk7XG4gIGZvbnQtc2l6ZTogMS41cmVtO1xufVxuLmV4YW1wbGUtcmF0ZS1saW1pdC1yZWFjaGVkIHtcbiAgY29sb3I6ICM5ODAwMDA7XG4gIHRleHQtYWxpZ246IGNlbnRlcjtcbn1cbi5pbWctdGl0bGUge1xuICB0ZXh0LWFsaWduOiBqdXN0aWZ5O1xuICB3b3JkLXdyYXA6IGJyZWFrLXdvcmQ7XG4gIG1hcmdpbjogMDtcbn1cbi5tYWluRGl2IC5tYXQtY2FyZCB7XG4gIGJvcmRlci1yYWRpdXM6IDI1cHggO1xufVxuLm1haW5EaXYge1xuICBwYWRkaW5nLWxlZnQ6IDE1dnc7XG4gIHBhZGRpbmctcmlnaHQ6IDE1dnc7XG59XG4ubWF0LXRhYi1oZWFkZXItcGFnaW5hdGlvbi1kaXNhYmxlZCAubWF0LXRhYi1oZWFkZXItcGFnaW5hdGlvbi1jaGV2cm9uIHtcbiAgYm9yZGVyLWNvbG9yOiByZ2JhKDAsIDAsIDAsIDAuNjIpICFpbXBvcnRhbnQ7XG59XG4ubWFpbkRpdiAuZXhhbXBsZS1jYXJkIHtcbiAgYm94LXNoYWRvdzogMCAycHggNHB4IDBweCByZ2JhKDAsIDAsIDAsIDAuMiksIDAgNHB4IDVweCAwIHJnYmEoMCwgMCwgMCwgMC4xNCksIDAgMXB4IDEwcHggMCByZ2JhKDAsIDAsIDAsIDAuMTIpO1xufVxuIl19 */");
            /***/ 
        }),
        /***/ "./src/app/project-info/project-info.component.ts": 
        /*!********************************************************!*\
          !*** ./src/app/project-info/project-info.component.ts ***!
          \********************************************************/
        /*! exports provided: ProjectInfoComponent */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectInfoComponent", function () { return ProjectInfoComponent; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
            /* harmony import */ var _angular_animations__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/animations */ "./node_modules/@angular/animations/fesm2015/animations.js");
            /* harmony import */ var _project_http_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../project/http.service */ "./src/app/project/http.service.ts");
            /* harmony import */ var _project_participants_project_participation_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../project-participants/project-participation.service */ "./src/app/project-participants/project-participation.service.ts");
            /* harmony import */ var _resources_table_for_project_resources_table_resource_service__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./resources-table-for-project/resources-table/resource.service */ "./src/app/project-info/resources-table-for-project/resources-table/resource.service.ts");
            var ProjectInfoComponent = /** @class */ (function () {
                function ProjectInfoComponent(route, http, resourceService, participService) {
                    this.route = route;
                    this.http = http;
                    this.resourceService = resourceService;
                    this.participService = participService;
                    this.generateOnceResourcesTable = false;
                    this.sortedResourcesByCategory = [];
                    this.isOpen = false;
                }
                ProjectInfoComponent.prototype.ngOnInit = function () {
                    var _this = this;
                    this.route.paramMap.subscribe(function (params) {
                        _this.projectId = +params.get('id');
                        _this.http.getProjectInfo(_this.projectId).subscribe(function (data) { return _this.projectInfo = data; });
                    });
                };
                ProjectInfoComponent.prototype.getResourcesData = function () {
                    return tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function () {
                        var allResources;
                        return __generator(this, function (_a) {
                            switch (_a.label) {
                                case 0:
                                    if (!!this.generateOnceResourcesTable) return [3 /*break*/, 2];
                                    return [4 /*yield*/, this.resourceService.getAllResourcesByProjId(this.projectId)];
                                case 1:
                                    allResources = _a.sent();
                                    this.sortedResourcesByCategory = this.resourceService.sortAllResourcesByCategories(allResources);
                                    _a.label = 2;
                                case 2:
                                    this.isOpen = !this.isOpen;
                                    this.generateOnceResourcesTable = true;
                                    return [2 /*return*/];
                            }
                        });
                    });
                };
                ProjectInfoComponent.prototype.onJoin = function () {
                    this.participService.createParticipRequest(this.projectId);
                };
                return ProjectInfoComponent;
            }());
            ProjectInfoComponent.ctorParameters = function () { return [
                { type: _angular_router__WEBPACK_IMPORTED_MODULE_2__["ActivatedRoute"] },
                { type: _project_http_service__WEBPACK_IMPORTED_MODULE_4__["HttpService"] },
                { type: _resources_table_for_project_resources_table_resource_service__WEBPACK_IMPORTED_MODULE_6__["ResourceService"] },
                { type: _project_participants_project_participation_service__WEBPACK_IMPORTED_MODULE_5__["ProjectParticipationService"] }
            ]; };
            ProjectInfoComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
                    selector: 'app-project-info',
                    template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./project-info.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/project-info/project-info.component.html")).default,
                    encapsulation: _angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewEncapsulation"].None,
                    animations: [
                        Object(_angular_animations__WEBPACK_IMPORTED_MODULE_3__["trigger"])('openClose', [
                            Object(_angular_animations__WEBPACK_IMPORTED_MODULE_3__["state"])('open', Object(_angular_animations__WEBPACK_IMPORTED_MODULE_3__["style"])({
                                display: 'initial'
                            })),
                            Object(_angular_animations__WEBPACK_IMPORTED_MODULE_3__["state"])('closed', Object(_angular_animations__WEBPACK_IMPORTED_MODULE_3__["style"])({
                                display: 'none'
                            })),
                        ]),
                    ],
                    providers: [_project_http_service__WEBPACK_IMPORTED_MODULE_4__["HttpService"], _project_participants_project_participation_service__WEBPACK_IMPORTED_MODULE_5__["ProjectParticipationService"]],
                    styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./project-info.component.less */ "./src/app/project-info/project-info.component.less")).default]
                })
            ], ProjectInfoComponent);
            /***/ 
        }),
        /***/ "./src/app/project-info/resources-table-for-project/resources-internal-table/resources-internal-table.component.less": 
        /*!***************************************************************************************************************************!*\
          !*** ./src/app/project-info/resources-table-for-project/resources-internal-table/resources-internal-table.component.less ***!
          \***************************************************************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("table {\n  width: 100%;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvcHJvamVjdC1pbmZvL3Jlc291cmNlcy10YWJsZS1mb3ItcHJvamVjdC9yZXNvdXJjZXMtaW50ZXJuYWwtdGFibGUvRDovR0lUL1RoZXJhTGFuZy9UaGVyYUxhbmcvZXhhbXBsZXMvTXZjV2ViL0NsaWVudEFwcC9zcmMvYXBwL3Byb2plY3QtaW5mby9yZXNvdXJjZXMtdGFibGUtZm9yLXByb2plY3QvcmVzb3VyY2VzLWludGVybmFsLXRhYmxlL3Jlc291cmNlcy1pbnRlcm5hbC10YWJsZS5jb21wb25lbnQubGVzcyIsInNyYy9hcHAvcHJvamVjdC1pbmZvL3Jlc291cmNlcy10YWJsZS1mb3ItcHJvamVjdC9yZXNvdXJjZXMtaW50ZXJuYWwtdGFibGUvcmVzb3VyY2VzLWludGVybmFsLXRhYmxlLmNvbXBvbmVudC5sZXNzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0ksV0FBQTtBQ0NKIiwiZmlsZSI6InNyYy9hcHAvcHJvamVjdC1pbmZvL3Jlc291cmNlcy10YWJsZS1mb3ItcHJvamVjdC9yZXNvdXJjZXMtaW50ZXJuYWwtdGFibGUvcmVzb3VyY2VzLWludGVybmFsLXRhYmxlLmNvbXBvbmVudC5sZXNzIiwic291cmNlc0NvbnRlbnQiOlsidGFibGV7XG4gICAgd2lkdGg6IDEwMCU7XG59IiwidGFibGUge1xuICB3aWR0aDogMTAwJTtcbn1cbiJdfQ== */");
            /***/ 
        }),
        /***/ "./src/app/project-info/resources-table-for-project/resources-internal-table/resources-internal-table.component.ts": 
        /*!*************************************************************************************************************************!*\
          !*** ./src/app/project-info/resources-table-for-project/resources-internal-table/resources-internal-table.component.ts ***!
          \*************************************************************************************************************************/
        /*! exports provided: ResourcesInternalTableComponent */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourcesInternalTableComponent", function () { return ResourcesInternalTableComponent; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm2015/material.js");
            /* harmony import */ var _shared_constants_resources_table__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../../shared/constants/resources-table */ "./src/app/shared/constants/resources-table.ts");
            var ResourcesInternalTableComponent = /** @class */ (function () {
                function ResourcesInternalTableComponent() {
                    this.displayedColumns = ['id', 'name', 'date', 'description'];
                }
                ResourcesInternalTableComponent.prototype.ngOnInit = function () {
                };
                ResourcesInternalTableComponent.prototype.ngAfterViewInit = function () {
                    this.pageSize = _shared_constants_resources_table__WEBPACK_IMPORTED_MODULE_3__["ResourcesTableConstants"].COLUMNS_PER_PAGE;
                    this.pageSizeOptions = _shared_constants_resources_table__WEBPACK_IMPORTED_MODULE_3__["ResourcesTableConstants"].PAGE_SIZE_OPTIONS;
                    this.dataSource.paginator = this.paginator;
                };
                return ResourcesInternalTableComponent;
            }());
            tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])()
            ], ResourcesInternalTableComponent.prototype, "dataSource", void 0);
            tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])()
            ], ResourcesInternalTableComponent.prototype, "lengthDataArrForDataSource", void 0);
            tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])(_angular_material__WEBPACK_IMPORTED_MODULE_2__["MatPaginator"], { static: true })
            ], ResourcesInternalTableComponent.prototype, "paginator", void 0);
            ResourcesInternalTableComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
                    selector: 'app-resources-internal-table',
                    template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./resources-internal-table.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/project-info/resources-table-for-project/resources-internal-table/resources-internal-table.component.html")).default,
                    styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./resources-internal-table.component.less */ "./src/app/project-info/resources-table-for-project/resources-internal-table/resources-internal-table.component.less")).default]
                })
            ], ResourcesInternalTableComponent);
            /***/ 
        }),
        /***/ "./src/app/project-info/resources-table-for-project/resources-table/resource-categories.service.ts": 
        /*!*********************************************************************************************************!*\
          !*** ./src/app/project-info/resources-table-for-project/resources-table/resource-categories.service.ts ***!
          \*********************************************************************************************************/
        /*! exports provided: ResourceCategoriesService */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourceCategoriesService", function () { return ResourceCategoriesService; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _project_http_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../project/http.service */ "./src/app/project/http.service.ts");
            var ResourceCategoriesService = /** @class */ (function () {
                function ResourceCategoriesService(http) {
                    this.http = http;
                }
                ResourceCategoriesService.prototype.getResourceCategories = function (withAssignedResources) {
                    var _this = this;
                    var categories = this.http.getResourceCategories(withAssignedResources).toPromise()
                        .then(function (category) {
                        _this.resourceCategories = category;
                        return category;
                    });
                    return categories;
                };
                return ResourceCategoriesService;
            }());
            ResourceCategoriesService.ctorParameters = function () { return [
                { type: _project_http_service__WEBPACK_IMPORTED_MODULE_2__["HttpService"] }
            ]; };
            ResourceCategoriesService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])()
            ], ResourceCategoriesService);
            /***/ 
        }),
        /***/ "./src/app/project-info/resources-table-for-project/resources-table/resource.service.ts": 
        /*!**********************************************************************************************!*\
          !*** ./src/app/project-info/resources-table-for-project/resources-table/resource.service.ts ***!
          \**********************************************************************************************/
        /*! exports provided: ResourceService */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourceService", function () { return ResourceService; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _project_http_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../project/http.service */ "./src/app/project/http.service.ts");
            var ResourceService = /** @class */ (function () {
                function ResourceService(http) {
                    this.http = http;
                    this.allProjectResources = [];
                    this.allResources = [];
                }
                ResourceService.prototype.getAllResourcesByProjId = function (projid) {
                    var _this = this;
                    var allData = this.http.getAllResourcesById(projid).toPromise().then(function (data) {
                        _this.allProjectResources = data;
                        return data;
                    });
                    return allData;
                };
                ResourceService.prototype.getAllResourceCategories = function (arr) {
                    var allResourceCategories = [];
                    for (var cat in arr) {
                        allResourceCategories.push(cat);
                    }
                    return allResourceCategories;
                };
                ResourceService.prototype.sortAllResourcesByCategories = function (res) {
                    var sortedArray = [];
                    res.forEach(function (resuorce) {
                        if (!sortedArray[resuorce.resourceCategory.type]) {
                            sortedArray[resuorce.resourceCategory.type] = [];
                        }
                        sortedArray[resuorce.resourceCategory.type].push(resuorce);
                    });
                    return sortedArray;
                };
                ResourceService.prototype.getResourcesByCategoryId = function (categoryId, pageNumber, recordsPerPage) {
                    var _this = this;
                    var allData = this.http.getResourcesByCategoryId(categoryId, pageNumber, recordsPerPage).toPromise()
                        .then(function (data) {
                        _this.allResources = data;
                        return data;
                    });
                    return allData;
                };
                ResourceService.prototype.getResourcesCountByCategoryId = function (categoryId) {
                    var _this = this;
                    var allData = this.http.getResourcesCountByCategoryId(categoryId).toPromise().then(function (data) {
                        _this.countAllResourcesByCategoryId = data;
                        return data;
                    });
                    return allData;
                };
                return ResourceService;
            }());
            ResourceService.ctorParameters = function () { return [
                { type: _project_http_service__WEBPACK_IMPORTED_MODULE_2__["HttpService"] }
            ]; };
            ResourceService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])()
            ], ResourceService);
            /***/ 
        }),
        /***/ "./src/app/project-info/resources-table-for-project/resources-table/resources-table.component.less": 
        /*!*********************************************************************************************************!*\
          !*** ./src/app/project-info/resources-table-for-project/resources-table/resources-table.component.less ***!
          \*********************************************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3Byb2plY3QtaW5mby9yZXNvdXJjZXMtdGFibGUtZm9yLXByb2plY3QvcmVzb3VyY2VzLXRhYmxlL3Jlc291cmNlcy10YWJsZS5jb21wb25lbnQubGVzcyJ9 */");
            /***/ 
        }),
        /***/ "./src/app/project-info/resources-table-for-project/resources-table/resources-table.component.ts": 
        /*!*******************************************************************************************************!*\
          !*** ./src/app/project-info/resources-table-for-project/resources-table/resources-table.component.ts ***!
          \*******************************************************************************************************/
        /*! exports provided: ResourcesTableComponent */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourcesTableComponent", function () { return ResourcesTableComponent; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _resource_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./resource.service */ "./src/app/project-info/resources-table-for-project/resources-table/resource.service.ts");
            /* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm2015/material.js");
            var ResourcesTableComponent = /** @class */ (function () {
                function ResourcesTableComponent(resourceService) {
                    this.resourceService = resourceService;
                }
                ResourcesTableComponent.prototype.ngOnInit = function () {
                    for (var resCategoty in this.sortedResourcesByCategory) {
                        this.selectResourcesArrayByCategotyName(resCategoty);
                        return;
                    }
                };
                ResourcesTableComponent.prototype.convertMatTabChangeEventLabelToString = function (event) {
                    var category = event.tab.textLabel;
                    this.selectResourcesArrayByCategotyName(category);
                };
                ResourcesTableComponent.prototype.selectResourcesArrayByCategotyName = function (category) {
                    this.setDataSourceToInternalResourcesTable(this.sortedResourcesByCategory[category]);
                };
                ResourcesTableComponent.prototype.setDataSourceToInternalResourcesTable = function (res) {
                    this.lengthDataArrForDataSource = res.length;
                    this.dataSource = new _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatTableDataSource"](res);
                };
                return ResourcesTableComponent;
            }());
            ResourcesTableComponent.ctorParameters = function () { return [
                { type: _resource_service__WEBPACK_IMPORTED_MODULE_2__["ResourceService"] }
            ]; };
            tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])()
            ], ResourcesTableComponent.prototype, "sortedResourcesByCategory", void 0);
            ResourcesTableComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
                    selector: 'app-resources-table',
                    template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./resources-table.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/project-info/resources-table-for-project/resources-table/resources-table.component.html")).default,
                    styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./resources-table.component.less */ "./src/app/project-info/resources-table-for-project/resources-table/resources-table.component.less")).default]
                })
            ], ResourcesTableComponent);
            /***/ 
        }),
        /***/ "./src/app/project-participants/event-service.ts": 
        /*!*******************************************************!*\
          !*** ./src/app/project-participants/event-service.ts ***!
          \*******************************************************/
        /*! exports provided: EventService */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "EventService", function () { return EventService; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm2015/index.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            var EventService = /** @class */ (function () {
                function EventService() {
                    this.childClickedEvent = new rxjs__WEBPACK_IMPORTED_MODULE_1__["Subject"]();
                }
                EventService.prototype.emitChildEvent = function () {
                    this.childClickedEvent.next();
                };
                EventService.prototype.childEventListner = function () {
                    return this.childClickedEvent.asObservable();
                };
                return EventService;
            }());
            EventService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["Injectable"])()
            ], EventService);
            /***/ 
        }),
        /***/ "./src/app/project-participants/project-participants.component.less": 
        /*!**************************************************************************!*\
          !*** ./src/app/project-participants/project-participants.component.less ***!
          \**************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("::ng-deep .mat-tab-body-content {\n  font-size: 3rem;\n  margin-left: 10px;\n}\n::ng-deep .mat-tab-label-content {\n  font-size: 1rem;\n  color: black;\n}\n.aproveButton .mat-raised-button {\n  background-color: #07a129;\n  margin-right: 15px;\n  margin-left: 15px;\n}\n.rejectButton .mat-raised-button {\n  background-color: #e00909;\n}\ntable {\n  width: 100%;\n}\n.mat-elevation-z8 {\n  margin: 15px;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvcHJvamVjdC1wYXJ0aWNpcGFudHMvRDovR0lUL1RoZXJhTGFuZy9UaGVyYUxhbmcvZXhhbXBsZXMvTXZjV2ViL0NsaWVudEFwcC9zcmMvYXBwL3Byb2plY3QtcGFydGljaXBhbnRzL3Byb2plY3QtcGFydGljaXBhbnRzLmNvbXBvbmVudC5sZXNzIiwic3JjL2FwcC9wcm9qZWN0LXBhcnRpY2lwYW50cy9wcm9qZWN0LXBhcnRpY2lwYW50cy5jb21wb25lbnQubGVzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQTtFQUNFLGVBQUE7RUFDQSxpQkFBQTtBQ0NGO0FERUE7RUFDRSxlQUFBO0VBQ0EsWUFBQTtBQ0FGO0FER0E7RUFDRSx5QkFBQTtFQUNBLGtCQUFBO0VBQ0EsaUJBQUE7QUNERjtBRElBO0VBQ0UseUJBQUE7QUNGRjtBREtBO0VBQ0UsV0FBQTtBQ0hGO0FETUE7RUFDRSxZQUFBO0FDSkYiLCJmaWxlIjoic3JjL2FwcC9wcm9qZWN0LXBhcnRpY2lwYW50cy9wcm9qZWN0LXBhcnRpY2lwYW50cy5jb21wb25lbnQubGVzcyIsInNvdXJjZXNDb250ZW50IjpbIjo6bmctZGVlcCAubWF0LXRhYi1ib2R5LWNvbnRlbnQge1xuICBmb250LXNpemUgIDogM3JlbTtcbiAgbWFyZ2luLWxlZnQ6IDEwcHg7XG59XG5cbjo6bmctZGVlcCAubWF0LXRhYi1sYWJlbC1jb250ZW50IHtcbiAgZm9udC1zaXplOiAxcmVtO1xuICBjb2xvciAgICA6IGJsYWNrO1xufVxuXG4uYXByb3ZlQnV0dG9uIC5tYXQtcmFpc2VkLWJ1dHRvbiB7XG4gIGJhY2tncm91bmQtY29sb3I6IHJnYig3LCAxNjEsIDQxKTtcbiAgbWFyZ2luLXJpZ2h0ICAgIDogMTVweDtcbiAgbWFyZ2luLWxlZnQgICAgIDogMTVweDtcbn1cblxuLnJlamVjdEJ1dHRvbiAubWF0LXJhaXNlZC1idXR0b24ge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiByZ2IoMjI0LCA5LCA5KVxufVxuXG50YWJsZSB7XG4gIHdpZHRoOiAxMDAlO1xufVxuXG4ubWF0LWVsZXZhdGlvbi16OCB7XG4gIG1hcmdpbjogMTVweDtcbn0iLCI6Om5nLWRlZXAgLm1hdC10YWItYm9keS1jb250ZW50IHtcbiAgZm9udC1zaXplOiAzcmVtO1xuICBtYXJnaW4tbGVmdDogMTBweDtcbn1cbjo6bmctZGVlcCAubWF0LXRhYi1sYWJlbC1jb250ZW50IHtcbiAgZm9udC1zaXplOiAxcmVtO1xuICBjb2xvcjogYmxhY2s7XG59XG4uYXByb3ZlQnV0dG9uIC5tYXQtcmFpc2VkLWJ1dHRvbiB7XG4gIGJhY2tncm91bmQtY29sb3I6ICMwN2ExMjk7XG4gIG1hcmdpbi1yaWdodDogMTVweDtcbiAgbWFyZ2luLWxlZnQ6IDE1cHg7XG59XG4ucmVqZWN0QnV0dG9uIC5tYXQtcmFpc2VkLWJ1dHRvbiB7XG4gIGJhY2tncm91bmQtY29sb3I6ICNlMDA5MDk7XG59XG50YWJsZSB7XG4gIHdpZHRoOiAxMDAlO1xufVxuLm1hdC1lbGV2YXRpb24tejgge1xuICBtYXJnaW46IDE1cHg7XG59XG4iXX0= */");
            /***/ 
        }),
        /***/ "./src/app/project-participants/project-participants.component.ts": 
        /*!************************************************************************!*\
          !*** ./src/app/project-participants/project-participants.component.ts ***!
          \************************************************************************/
        /*! exports provided: ProjectParticipantsComponent */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectParticipantsComponent", function () { return ProjectParticipantsComponent; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _project_http_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../project/http.service */ "./src/app/project/http.service.ts");
            /* harmony import */ var _event_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./event-service */ "./src/app/project-participants/event-service.ts");
            /* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm2015/material.js");
            /* harmony import */ var _request_status_enum__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../request-status-enum */ "./src/app/request-status-enum.ts");
            var ProjectParticipantsComponent = /** @class */ (function () {
                function ProjectParticipantsComponent(httpService, eventService) {
                    this.httpService = httpService;
                    this.eventService = eventService;
                    this.projectParticipationRequest = new _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatTableDataSource"]();
                    this.showActionButtons = true;
                    this.displayedColumns = ['createdById', 'role', 'projectId', 'status', 'actions'];
                }
                ProjectParticipantsComponent.prototype.ngOnInit = function () {
                    var _this = this;
                    this.httpService.getAllProjectParticipants().subscribe(function (projectParticipants) {
                        _this.projectParticipationRequest.data = projectParticipants;
                        _this.projectParticipationRequest.filterPredicate = function (projectParticipant, filter) { return projectParticipant.status.toString() == filter; };
                        _this.projectParticipationRequest.paginator = _this.paginator;
                        _this.projectParticipationRequest.filter = _request_status_enum__WEBPACK_IMPORTED_MODULE_5__["RequestStatus"].New.toString();
                    });
                };
                ProjectParticipantsComponent.prototype.load = function () {
                    var _this = this;
                    this.httpService.getAllProjectParticipants().subscribe(function (projectParticipants) {
                        _this.projectParticipationRequest.data = projectParticipants;
                        _this.removeNotificationIcon();
                    });
                };
                ProjectParticipantsComponent.prototype.changeTab = function (tabPosition) {
                    this.projectParticipationRequest.filter = this.changeFilter(tabPosition);
                    this.showActionButtons = (tabPosition === _request_status_enum__WEBPACK_IMPORTED_MODULE_5__["RequestStatus"].New) ? true : false;
                };
                ProjectParticipantsComponent.prototype.changeFilter = function (tabPosition) {
                    if (tabPosition === 1) {
                        return _request_status_enum__WEBPACK_IMPORTED_MODULE_5__["RequestStatus"].Aproved.toString();
                    }
                    else if (tabPosition === 2) {
                        return _request_status_enum__WEBPACK_IMPORTED_MODULE_5__["RequestStatus"].Rejected.toString();
                    }
                    else {
                        return _request_status_enum__WEBPACK_IMPORTED_MODULE_5__["RequestStatus"].New.toString();
                    }
                };
                ProjectParticipantsComponent.prototype.changeStatus = function (status, projectParticipant) {
                    var _this = this;
                    projectParticipant.status = (status === 'aproved') ? _request_status_enum__WEBPACK_IMPORTED_MODULE_5__["RequestStatus"].Aproved : _request_status_enum__WEBPACK_IMPORTED_MODULE_5__["RequestStatus"].Rejected;
                    this.httpService.changeParticipationStatus(projectParticipant.id, projectParticipant.status).subscribe(function (data) {
                        _this.load();
                    });
                };
                ProjectParticipantsComponent.prototype.removeNotificationIcon = function () {
                    if (this.projectParticipationRequest.filteredData.length === 0) {
                        this.eventService.emitChildEvent();
                    }
                };
                return ProjectParticipantsComponent;
            }());
            ProjectParticipantsComponent.ctorParameters = function () { return [
                { type: _project_http_service__WEBPACK_IMPORTED_MODULE_2__["HttpService"] },
                { type: _event_service__WEBPACK_IMPORTED_MODULE_3__["EventService"] }
            ]; };
            tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])(_angular_material__WEBPACK_IMPORTED_MODULE_4__["MatPaginator"], { static: true })
            ], ProjectParticipantsComponent.prototype, "paginator", void 0);
            ProjectParticipantsComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
                    selector: 'app-project-participants',
                    template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./project-participants.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/project-participants/project-participants.component.html")).default,
                    styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./project-participants.component.less */ "./src/app/project-participants/project-participants.component.less")).default]
                })
            ], ProjectParticipantsComponent);
            /***/ 
        }),
        /***/ "./src/app/project-participants/project-participation.service.ts": 
        /*!***********************************************************************!*\
          !*** ./src/app/project-participants/project-participation.service.ts ***!
          \***********************************************************************/
        /*! exports provided: ProjectParticipationService */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectParticipationService", function () { return ProjectParticipationService; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
            /* harmony import */ var _shared_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../shared/api-endpoint.constants */ "./src/app/shared/api-endpoint.constants.ts");
            var ProjectParticipationService = /** @class */ (function () {
                function ProjectParticipationService(http) {
                    this.http = http;
                    this.url = _shared_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_3__["participationUrl"];
                }
                ProjectParticipationService.prototype.createParticipRequest = function (projectId) {
                    return this.http.post(this.url + '/' + 'create', projectId);
                };
                return ProjectParticipationService;
            }());
            ProjectParticipationService.ctorParameters = function () { return [
                { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"] }
            ]; };
            ProjectParticipationService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
                    providedIn: 'root'
                })
            ], ProjectParticipationService);
            /***/ 
        }),
        /***/ "./src/app/project/http.service.ts": 
        /*!*****************************************!*\
          !*** ./src/app/project/http.service.ts ***!
          \*****************************************/
        /*! exports provided: HttpService */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "HttpService", function () { return HttpService; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
            /* harmony import */ var _shared_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../shared/api-endpoint.constants */ "./src/app/shared/api-endpoint.constants.ts");
            var HttpService = /** @class */ (function () {
                function HttpService(http) {
                    this.http = http;
                    this.url = _shared_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_3__["baseUrl"];
                }
                HttpService.prototype.getAllProjects = function () {
                    return this.http.get(this.url + 'project');
                };
                HttpService.prototype.getProjectInfo = function (id) {
                    return this.http.get(this.url + 'project' + '/' + id);
                };
                HttpService.prototype.getAllProjectParticipants = function () {
                    return this.http.get(this.url + 'projectParticipants');
                };
                HttpService.prototype.changeParticipationStatus = function (requestId, requestStatus) {
                    return this.http.put(this.url + 'projectParticipants' + '/' + requestId, requestStatus);
                };
                HttpService.prototype.getAllResourcesById = function (projectId) {
                    return this.http.get(this.url + 'resource/all/' + projectId);
                };
                HttpService.prototype.getResourcesByCategoryId = function (categoryId, pageNumber, recordsPerPage) {
                    return this.http.get(this.url + 'resource/all/' + categoryId + '/' + pageNumber
                        + '/' + recordsPerPage);
                };
                HttpService.prototype.getResourceCategories = function (withAssignedResources) {
                    return this.http.get(this.url + 'resource/categories' + '/' + withAssignedResources);
                };
                HttpService.prototype.getResourcesCountByCategoryId = function (categoryId) {
                    return this.http.get(this.url + 'resource/count' + '/' + categoryId);
                };
                HttpService.prototype.createProject = function (project) {
                    return this.http.post(this.url + 'project' + '/' + 'create', project);
                };
                HttpService.prototype.updateProject = function (project) {
                    return this.http.put(this.url + '/' + project.id, project);
                };
                return HttpService;
            }());
            HttpService.ctorParameters = function () { return [
                { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"] }
            ]; };
            HttpService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])()
            ], HttpService);
            /***/ 
        }),
        /***/ "./src/app/project/project.component.less": 
        /*!************************************************!*\
          !*** ./src/app/project/project.component.less ***!
          \************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = (".mat-stroked-button {\n  background-color: #8b9396;\n}\n.mat-flat-button {\n  background-color: #56ec38;\n  position: fixed;\n  bottom: 1.5rem;\n  right: 1.5rem;\n}\n.project-info {\n  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;\n  font-size: 1.2em;\n}\n.project-card {\n  margin: 15px;\n}\n.project-image {\n  max-width: 185px;\n  float: left;\n  margin: 10px 10px 10px 0;\n}\n.clear {\n  clear: both;\n  border: 3px solid;\n  border-color: #797575;\n}\n.get-details-button {\n  text-align: right;\n}\n.header {\n  float: right;\n}\n.donate-button {\n  background-color: green;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvcHJvamVjdC9EOi9HSVQvVGhlcmFMYW5nL1RoZXJhTGFuZy9leGFtcGxlcy9NdmNXZWIvQ2xpZW50QXBwL3NyYy9hcHAvcHJvamVjdC9wcm9qZWN0LmNvbXBvbmVudC5sZXNzIiwic3JjL2FwcC9wcm9qZWN0L3Byb2plY3QuY29tcG9uZW50Lmxlc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDSSx5QkFBQTtBQ0NKO0FERUE7RUFDSSx5QkFBQTtFQUNBLGVBQUE7RUFDQSxjQUFBO0VBQ0EsYUFBQTtBQ0FKO0FER0E7RUFDSSw0REFBQTtFQUNBLGdCQUFBO0FDREo7QURJQTtFQUNJLFlBQUE7QUNGSjtBREtBO0VBQ0ksZ0JBQUE7RUFDQSxXQUFBO0VBQ0Esd0JBQUE7QUNISjtBRE1BO0VBQ0ksV0FBQTtFQUNBLGlCQUFBO0VBQ0EscUJBQUE7QUNKSjtBRFFBO0VBQ0ksaUJBQUE7QUNOSjtBRFVBO0VBQ0ksWUFBQTtBQ1JKO0FEV0E7RUFDSSx1QkFBQTtBQ1RKIiwiZmlsZSI6InNyYy9hcHAvcHJvamVjdC9wcm9qZWN0LmNvbXBvbmVudC5sZXNzIiwic291cmNlc0NvbnRlbnQiOlsiLm1hdC1zdHJva2VkLWJ1dHRvbiB7XG4gICAgYmFja2dyb3VuZC1jb2xvciAgIDogcmdiKDEzOSwgMTQ3LCAxNTApO1xufVxuXG4ubWF0LWZsYXQtYnV0dG9uIHtcbiAgICBiYWNrZ3JvdW5kLWNvbG9yOiByZ2IoODYsIDIzNiwgNTYpO1xuICAgIHBvc2l0aW9uICAgICAgICA6IGZpeGVkO1xuICAgIGJvdHRvbSAgICAgICAgICA6IDEuNXJlbTtcbiAgICByaWdodCAgICAgICAgICAgOiAxLjVyZW07XG59XG5cbi5wcm9qZWN0LWluZm8ge1xuICAgIGZvbnQtZmFtaWx5OiAnU2Vnb2UgVUknLCBUYWhvbWEsIEdlbmV2YSwgVmVyZGFuYSwgc2Fucy1zZXJpZjtcbiAgICBmb250LXNpemUgIDogMS4yZW07XG59XG5cbi5wcm9qZWN0LWNhcmQge1xuICAgIG1hcmdpbjogMTVweDtcbn1cblxuLnByb2plY3QtaW1hZ2Uge1xuICAgIG1heC13aWR0aDogMTg1cHg7XG4gICAgZmxvYXQgICAgOiBsZWZ0O1xuICAgIG1hcmdpbiAgIDogMTBweCAxMHB4IDEwcHggMDtcbn1cblxuLmNsZWFyIHtcbiAgICBjbGVhciAgICAgICA6IGJvdGg7XG4gICAgYm9yZGVyICAgICAgOiAzcHggc29saWQ7XG4gICAgYm9yZGVyLWNvbG9yOiAjNzk3NTc1O1xufVxuXG5cbi5nZXQtZGV0YWlscy1idXR0b24ge1xuICAgIHRleHQtYWxpZ246IHJpZ2h0O1xuXG59XG5cbi5oZWFkZXIge1xuICAgIGZsb2F0OiByaWdodDtcbn1cblxuLmRvbmF0ZS1idXR0b24ge1xuICAgIGJhY2tncm91bmQtY29sb3I6IGdyZWVuO1xufSIsIi5tYXQtc3Ryb2tlZC1idXR0b24ge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjOGI5Mzk2O1xufVxuLm1hdC1mbGF0LWJ1dHRvbiB7XG4gIGJhY2tncm91bmQtY29sb3I6ICM1NmVjMzg7XG4gIHBvc2l0aW9uOiBmaXhlZDtcbiAgYm90dG9tOiAxLjVyZW07XG4gIHJpZ2h0OiAxLjVyZW07XG59XG4ucHJvamVjdC1pbmZvIHtcbiAgZm9udC1mYW1pbHk6ICdTZWdvZSBVSScsIFRhaG9tYSwgR2VuZXZhLCBWZXJkYW5hLCBzYW5zLXNlcmlmO1xuICBmb250LXNpemU6IDEuMmVtO1xufVxuLnByb2plY3QtY2FyZCB7XG4gIG1hcmdpbjogMTVweDtcbn1cbi5wcm9qZWN0LWltYWdlIHtcbiAgbWF4LXdpZHRoOiAxODVweDtcbiAgZmxvYXQ6IGxlZnQ7XG4gIG1hcmdpbjogMTBweCAxMHB4IDEwcHggMDtcbn1cbi5jbGVhciB7XG4gIGNsZWFyOiBib3RoO1xuICBib3JkZXI6IDNweCBzb2xpZDtcbiAgYm9yZGVyLWNvbG9yOiAjNzk3NTc1O1xufVxuLmdldC1kZXRhaWxzLWJ1dHRvbiB7XG4gIHRleHQtYWxpZ246IHJpZ2h0O1xufVxuLmhlYWRlciB7XG4gIGZsb2F0OiByaWdodDtcbn1cbi5kb25hdGUtYnV0dG9uIHtcbiAgYmFja2dyb3VuZC1jb2xvcjogZ3JlZW47XG59XG4iXX0= */");
            /***/ 
        }),
        /***/ "./src/app/project/project.component.ts": 
        /*!**********************************************!*\
          !*** ./src/app/project/project.component.ts ***!
          \**********************************************/
        /*! exports provided: ProjectComponent */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectComponent", function () { return ProjectComponent; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _http_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./http.service */ "./src/app/project/http.service.ts");
            /* harmony import */ var _project_form_project_form_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../project-form/project-form.component */ "./src/app/project-form/project-form.component.ts");
            /* harmony import */ var _project_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./project.service */ "./src/app/project/project.service.ts");
            /* harmony import */ var _shared_services_dialog_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../shared/services/dialog.service */ "./src/app/shared/services/dialog.service.ts");
            var ProjectComponent = /** @class */ (function () {
                function ProjectComponent(httpService, dialogService, service) {
                    this.httpService = httpService;
                    this.dialogService = dialogService;
                    this.service = service;
                }
                ProjectComponent.prototype.ngOnInit = function () {
                    var _this = this;
                    this.httpService.getAllProjects().subscribe(function (projects) { return _this.projects = projects; });
                };
                ProjectComponent.prototype.onCreate = function () {
                    this.service.initializeFormGroup();
                    this.dialogService.openFormDialog(_project_form_project_form_component__WEBPACK_IMPORTED_MODULE_3__["ProjectFormComponent"]);
                };
                ProjectComponent.prototype.onEdit = function () {
                    //this.service.populateForm();
                    this.dialogService.openFormDialog(_project_form_project_form_component__WEBPACK_IMPORTED_MODULE_3__["ProjectFormComponent"]);
                };
                return ProjectComponent;
            }());
            ProjectComponent.ctorParameters = function () { return [
                { type: _http_service__WEBPACK_IMPORTED_MODULE_2__["HttpService"] },
                { type: _shared_services_dialog_service__WEBPACK_IMPORTED_MODULE_5__["DialogService"] },
                { type: _project_service__WEBPACK_IMPORTED_MODULE_4__["ProjectService"] }
            ]; };
            ProjectComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
                    selector: 'app-project',
                    template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./project.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/project/project.component.html")).default,
                    providers: [_project_service__WEBPACK_IMPORTED_MODULE_4__["ProjectService"]],
                    styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./project.component.less */ "./src/app/project/project.component.less")).default]
                })
            ], ProjectComponent);
            /***/ 
        }),
        /***/ "./src/app/project/project.service.ts": 
        /*!********************************************!*\
          !*** ./src/app/project/project.service.ts ***!
          \********************************************/
        /*! exports provided: ProjectService */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectService", function () { return ProjectService; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm2015/forms.js");
            /* harmony import */ var _http_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./http.service */ "./src/app/project/http.service.ts");
            /* harmony import */ var _shared_services_notification_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../shared/services/notification.service */ "./src/app/shared/services/notification.service.ts");
            var ProjectService = /** @class */ (function () {
                function ProjectService(fb, httpService, notificationService) {
                    this.fb = fb;
                    this.httpService = httpService;
                    this.notificationService = notificationService;
                    this.form = this.fb.group({
                        id: [null],
                        name: ['', [_angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required, _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].minLength(3), _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].maxLength(50)]],
                        description: ['', [_angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required, _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].minLength(5), _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].maxLength(8000)]],
                        type: ['', [_angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required, _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].minLength(3)]],
                    });
                }
                ProjectService.prototype.initializeFormGroup = function () {
                    this.form.setValue({
                        id: null,
                        name: '',
                        description: '',
                        type: '',
                    });
                };
                ProjectService.prototype.populateForm = function (project) {
                    this.form.setValue(project);
                };
                ProjectService.prototype.addProject = function (project) {
                    this.httpService.createProject(project);
                    this.notificationService.success("Проект створено!");
                };
                ProjectService.prototype.editProject = function (project) {
                    this.httpService.updateProject(project);
                };
                return ProjectService;
            }());
            ProjectService.ctorParameters = function () { return [
                { type: _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormBuilder"] },
                { type: _http_service__WEBPACK_IMPORTED_MODULE_3__["HttpService"] },
                { type: _shared_services_notification_service__WEBPACK_IMPORTED_MODULE_4__["NotificationService"] }
            ]; };
            ProjectService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
                    providedIn: 'root'
                })
            ], ProjectService);
            /***/ 
        }),
        /***/ "./src/app/request-status-enum.ts": 
        /*!****************************************!*\
          !*** ./src/app/request-status-enum.ts ***!
          \****************************************/
        /*! exports provided: RequestStatus */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "RequestStatus", function () { return RequestStatus; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            var RequestStatus;
            (function (RequestStatus) {
                RequestStatus[RequestStatus["New"] = 0] = "New";
                RequestStatus[RequestStatus["Aproved"] = 10] = "Aproved";
                RequestStatus[RequestStatus["Rejected"] = 20] = "Rejected";
            })(RequestStatus || (RequestStatus = {}));
            /***/ 
        }),
        /***/ "./src/app/shared/api-endpoint.constants.ts": 
        /*!**************************************************!*\
          !*** ./src/app/shared/api-endpoint.constants.ts ***!
          \**************************************************/
        /*! exports provided: baseUrl, projectUrl, resourсeUrl, requestUrl, categoryUrl, participationUrl, paymentUrl */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "baseUrl", function () { return baseUrl; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "projectUrl", function () { return projectUrl; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "resourсeUrl", function () { return resourсeUrl; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "requestUrl", function () { return requestUrl; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "categoryUrl", function () { return categoryUrl; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "participationUrl", function () { return participationUrl; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "paymentUrl", function () { return paymentUrl; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            var baseUrl = "https://localhost:5000/api/";
            var projectUrl = baseUrl + "project";
            var resourсeUrl = baseUrl + "resourсe";
            var requestUrl = baseUrl + "request";
            var categoryUrl = baseUrl + "category";
            var participationUrl = baseUrl + "participation";
            var paymentUrl = baseUrl + "payment";
            /***/ 
        }),
        /***/ "./src/app/shared/components/confirm-dialog/confirm-dialog.component.less": 
        /*!********************************************************************************!*\
          !*** ./src/app/shared/components/confirm-dialog/confirm-dialog.component.less ***!
          \********************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3NoYXJlZC9jb21wb25lbnRzL2NvbmZpcm0tZGlhbG9nL2NvbmZpcm0tZGlhbG9nLmNvbXBvbmVudC5sZXNzIn0= */");
            /***/ 
        }),
        /***/ "./src/app/shared/components/confirm-dialog/confirm-dialog.component.ts": 
        /*!******************************************************************************!*\
          !*** ./src/app/shared/components/confirm-dialog/confirm-dialog.component.ts ***!
          \******************************************************************************/
        /*! exports provided: ConfirmDialogComponent */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ConfirmDialogComponent", function () { return ConfirmDialogComponent; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm2015/material.js");
            var ConfirmDialogComponent = /** @class */ (function () {
                function ConfirmDialogComponent(dialogRef, data) {
                    this.dialogRef = dialogRef;
                    this.data = data;
                }
                ConfirmDialogComponent.prototype.ngOnInit = function () {
                };
                ConfirmDialogComponent.prototype.closeDialog = function () {
                    this.dialogRef.close(false);
                };
                return ConfirmDialogComponent;
            }());
            ConfirmDialogComponent.ctorParameters = function () { return [
                { type: _angular_material__WEBPACK_IMPORTED_MODULE_2__["MatDialogRef"] },
                { type: undefined, decorators: [{ type: _angular_core__WEBPACK_IMPORTED_MODULE_1__["Inject"], args: [_angular_material__WEBPACK_IMPORTED_MODULE_2__["MAT_DIALOG_DATA"],] }] }
            ]; };
            ConfirmDialogComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
                    selector: 'app-confirm-dialog',
                    template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./confirm-dialog.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/shared/components/confirm-dialog/confirm-dialog.component.html")).default,
                    styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./confirm-dialog.component.less */ "./src/app/shared/components/confirm-dialog/confirm-dialog.component.less")).default]
                }),
                tslib__WEBPACK_IMPORTED_MODULE_0__["__param"](1, Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Inject"])(_angular_material__WEBPACK_IMPORTED_MODULE_2__["MAT_DIALOG_DATA"]))
            ], ConfirmDialogComponent);
            /***/ 
        }),
        /***/ "./src/app/shared/components/error/error.component.less": 
        /*!**************************************************************!*\
          !*** ./src/app/shared/components/error/error.component.less ***!
          \**************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3NoYXJlZC9jb21wb25lbnRzL2Vycm9yL2Vycm9yLmNvbXBvbmVudC5sZXNzIn0= */");
            /***/ 
        }),
        /***/ "./src/app/shared/components/error/error.component.ts": 
        /*!************************************************************!*\
          !*** ./src/app/shared/components/error/error.component.ts ***!
          \************************************************************/
        /*! exports provided: ErrorComponent */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ErrorComponent", function () { return ErrorComponent; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
            var ErrorComponent = /** @class */ (function () {
                function ErrorComponent(router) {
                    this.router = router;
                }
                ErrorComponent.prototype.ngOnInit = function () {
                };
                ErrorComponent.prototype.goHome = function () {
                    this.router.navigate(['']);
                };
                return ErrorComponent;
            }());
            ErrorComponent.ctorParameters = function () { return [
                { type: _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"] }
            ]; };
            ErrorComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
                    selector: 'app-error',
                    template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./error.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/shared/components/error/error.component.html")).default,
                    styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./error.component.less */ "./src/app/shared/components/error/error.component.less")).default]
                })
            ], ErrorComponent);
            /***/ 
        }),
        /***/ "./src/app/shared/constants/date-formats.ts": 
        /*!**************************************************!*\
          !*** ./src/app/shared/constants/date-formats.ts ***!
          \**************************************************/
        /*! exports provided: DateFormatsConstants */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "DateFormatsConstants", function () { return DateFormatsConstants; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            var DateFormatsConstants = /** @class */ (function () {
                function DateFormatsConstants() {
                }
                return DateFormatsConstants;
            }());
            DateFormatsConstants.LONG_DATE_STRING = "y/MM/dd H:mm";
            /***/ 
        }),
        /***/ "./src/app/shared/constants/resources-table.ts": 
        /*!*****************************************************!*\
          !*** ./src/app/shared/constants/resources-table.ts ***!
          \*****************************************************/
        /*! exports provided: ResourcesTableConstants */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourcesTableConstants", function () { return ResourcesTableConstants; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            var ResourcesTableConstants = /** @class */ (function () {
                function ResourcesTableConstants() {
                }
                return ResourcesTableConstants;
            }());
            ResourcesTableConstants.PAGE_NUMBER = 1;
            ResourcesTableConstants.COLUMNS_PER_PAGE = 10;
            ResourcesTableConstants.WITH_ASSIGNED_RESOURCES = true;
            ResourcesTableConstants.PAGE_SIZE_OPTIONS = [5, 10, 20];
            /***/ 
        }),
        /***/ "./src/app/shared/pipes/custom.datepipe.ts": 
        /*!*************************************************!*\
          !*** ./src/app/shared/pipes/custom.datepipe.ts ***!
          \*************************************************/
        /*! exports provided: CustomDatePipe */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CustomDatePipe", function () { return CustomDatePipe; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm2015/common.js");
            /* harmony import */ var _constants_date_formats__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../constants/date-formats */ "./src/app/shared/constants/date-formats.ts");
            var CustomDatePipe = /** @class */ (function (_super) {
                __extends(CustomDatePipe, _super);
                function CustomDatePipe() {
                    return _super !== null && _super.apply(this, arguments) || this;
                }
                CustomDatePipe.prototype.transform = function (value, args) {
                    return _super.prototype.transform.call(this, value, _constants_date_formats__WEBPACK_IMPORTED_MODULE_3__["DateFormatsConstants"].LONG_DATE_STRING);
                };
                return CustomDatePipe;
            }(_angular_common__WEBPACK_IMPORTED_MODULE_2__["DatePipe"]));
            CustomDatePipe = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Pipe"])({
                    name: 'customDate'
                })
            ], CustomDatePipe);
            /***/ 
        }),
        /***/ "./src/app/shared/services/dialog.service.ts": 
        /*!***************************************************!*\
          !*** ./src/app/shared/services/dialog.service.ts ***!
          \***************************************************/
        /*! exports provided: DialogService */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "DialogService", function () { return DialogService; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm2015/material.js");
            /* harmony import */ var _components_confirm_dialog_confirm_dialog_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../components/confirm-dialog/confirm-dialog.component */ "./src/app/shared/components/confirm-dialog/confirm-dialog.component.ts");
            var DialogService = /** @class */ (function () {
                function DialogService(dialog) {
                    this.dialog = dialog;
                }
                DialogService.prototype.openConfirmDialog = function (msg) {
                    return this.dialog.open(_components_confirm_dialog_confirm_dialog_component__WEBPACK_IMPORTED_MODULE_3__["ConfirmDialogComponent"], {
                        width: '390px',
                        panelClass: 'confirm-dialog-container',
                        disableClose: true,
                        position: { top: "10px" },
                        data: {
                            message: msg
                        }
                    });
                };
                DialogService.prototype.openFormDialog = function (formComponent) {
                    var dialogConfig = new _angular_material__WEBPACK_IMPORTED_MODULE_2__["MatDialogConfig"]();
                    dialogConfig.disableClose = true;
                    dialogConfig.autoFocus = true;
                    dialogConfig.width = '60%';
                    dialogConfig.panelClass = 'form';
                    this.dialog.open(formComponent, dialogConfig);
                };
                return DialogService;
            }());
            DialogService.ctorParameters = function () { return [
                { type: _angular_material__WEBPACK_IMPORTED_MODULE_2__["MatDialog"] }
            ]; };
            DialogService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
                    providedIn: 'root'
                })
            ], DialogService);
            /***/ 
        }),
        /***/ "./src/app/shared/services/error-handler.service.ts": 
        /*!**********************************************************!*\
          !*** ./src/app/shared/services/error-handler.service.ts ***!
          \**********************************************************/
        /*! exports provided: ErrorHandlerService */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ErrorHandlerService", function () { return ErrorHandlerService; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
            /* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
            var ErrorHandlerService = /** @class */ (function () {
                function ErrorHandlerService(injector) {
                    this.injector = injector;
                }
                ErrorHandlerService.prototype.handleError = function (error) {
                    var router = this.injector.get(_angular_router__WEBPACK_IMPORTED_MODULE_3__["Router"]);
                    console.log('Request URL: ${router.url}');
                    if (error instanceof _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpErrorResponse"]) {
                        console.error('Backend returned status code:', error.status);
                        console.error('Response body:', error.message);
                    }
                    else {
                        console.log('An error occurred', error.message);
                    }
                    router.navigate(['error']);
                };
                return ErrorHandlerService;
            }());
            ErrorHandlerService.ctorParameters = function () { return [
                { type: _angular_core__WEBPACK_IMPORTED_MODULE_1__["Injector"] }
            ]; };
            ErrorHandlerService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
                    providedIn: 'root'
                })
            ], ErrorHandlerService);
            /***/ 
        }),
        /***/ "./src/app/shared/services/notification.service.ts": 
        /*!*********************************************************!*\
          !*** ./src/app/shared/services/notification.service.ts ***!
          \*********************************************************/
        /*! exports provided: NotificationService */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "NotificationService", function () { return NotificationService; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm2015/material.js");
            var NotificationService = /** @class */ (function () {
                function NotificationService(snackBar) {
                    this.snackBar = snackBar;
                    this.config = {
                        duration: 10000,
                        horizontalPosition: 'center',
                        verticalPosition: 'top',
                    };
                }
                NotificationService.prototype.success = function (msg) {
                    this.config['panelClass'] = ['notification', 'success'];
                    this.snackBar.open(msg, '', this.config);
                };
                NotificationService.prototype.warn = function (msg) {
                    this.config['panelClass'] = ['notification', 'warn'];
                    this.snackBar.open(msg, '', this.config);
                };
                return NotificationService;
            }());
            NotificationService.ctorParameters = function () { return [
                { type: _angular_material__WEBPACK_IMPORTED_MODULE_2__["MatSnackBar"] }
            ]; };
            NotificationService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
                    providedIn: 'root'
                })
            ], NotificationService);
            /***/ 
        }),
        /***/ "./src/app/toolbar/toolbar.component.less": 
        /*!************************************************!*\
          !*** ./src/app/toolbar/toolbar.component.less ***!
          \************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = (".toolbar-button {\n  margin: 10px;\n  float: left;\n}\n.fill-space {\n  flex: 1 1 auto;\n}\n.mat-toolbar {\n  margin-bottom: 1rem;\n}\n.mat-toolbar.mat-primary {\n  background-color: purple;\n}\na.mat-button .mat-icon {\n  vertical-align: top;\n  font-size: 1.25em;\n  color: red;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvdG9vbGJhci9EOi9HSVQvVGhlcmFMYW5nL1RoZXJhTGFuZy9leGFtcGxlcy9NdmNXZWIvQ2xpZW50QXBwL3NyYy9hcHAvdG9vbGJhci90b29sYmFyLmNvbXBvbmVudC5sZXNzIiwic3JjL2FwcC90b29sYmFyL3Rvb2xiYXIuY29tcG9uZW50Lmxlc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDRSxZQUFBO0VBQ0EsV0FBQTtBQ0NGO0FERUE7RUFDRSxjQUFBO0FDQUY7QURHQTtFQUNFLG1CQUFBO0FDREY7QURJQTtFQUNFLHdCQUFBO0FDRkY7QURLQTtFQUNFLG1CQUFBO0VBQ0EsaUJBQUE7RUFDQSxVQUFBO0FDSEYiLCJmaWxlIjoic3JjL2FwcC90b29sYmFyL3Rvb2xiYXIuY29tcG9uZW50Lmxlc3MiLCJzb3VyY2VzQ29udGVudCI6WyIudG9vbGJhci1idXR0b24ge1xuICBtYXJnaW46IDEwcHg7XG4gIGZsb2F0IDogbGVmdDtcbn1cblxuLmZpbGwtc3BhY2Uge1xuICBmbGV4OiAxIDEgYXV0bztcbn1cblxuLm1hdC10b29sYmFyIHtcbiAgbWFyZ2luLWJvdHRvbTogMXJlbTtcbn1cblxuLm1hdC10b29sYmFyLm1hdC1wcmltYXJ5IHtcbiAgYmFja2dyb3VuZC1jb2xvcjogcHVycGxlO1xufVxuXG5hLm1hdC1idXR0b24gLm1hdC1pY29uIHtcbiAgdmVydGljYWwtYWxpZ246IHRvcDtcbiAgZm9udC1zaXplICAgICA6IDEuMjVlbTtcbiAgY29sb3IgICAgICAgICA6IHJlZDtcbn0iLCIudG9vbGJhci1idXR0b24ge1xuICBtYXJnaW46IDEwcHg7XG4gIGZsb2F0OiBsZWZ0O1xufVxuLmZpbGwtc3BhY2Uge1xuICBmbGV4OiAxIDEgYXV0bztcbn1cbi5tYXQtdG9vbGJhciB7XG4gIG1hcmdpbi1ib3R0b206IDFyZW07XG59XG4ubWF0LXRvb2xiYXIubWF0LXByaW1hcnkge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiBwdXJwbGU7XG59XG5hLm1hdC1idXR0b24gLm1hdC1pY29uIHtcbiAgdmVydGljYWwtYWxpZ246IHRvcDtcbiAgZm9udC1zaXplOiAxLjI1ZW07XG4gIGNvbG9yOiByZWQ7XG59XG4iXX0= */");
            /***/ 
        }),
        /***/ "./src/app/toolbar/toolbar.component.ts": 
        /*!**********************************************!*\
          !*** ./src/app/toolbar/toolbar.component.ts ***!
          \**********************************************/
        /*! exports provided: ToolbarComponent */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ToolbarComponent", function () { return ToolbarComponent; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _project_http_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../project/http.service */ "./src/app/project/http.service.ts");
            /* harmony import */ var _project_participants_event_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../project-participants/event-service */ "./src/app/project-participants/event-service.ts");
            /* harmony import */ var _request_status_enum__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../request-status-enum */ "./src/app/request-status-enum.ts");
            var ToolbarComponent = /** @class */ (function () {
                function ToolbarComponent(httpService, evtSvc) {
                    this.httpService = httpService;
                    this.evtSvc = evtSvc;
                    this.hasNotification = true;
                }
                ToolbarComponent.prototype.ngOnInit = function () {
                    var _this = this;
                    this.httpService.getAllProjectParticipants().subscribe(function (data) {
                        _this.projectParticipation = data;
                        if ((_this.projectParticipation.filter(function (x) { return x.status === _request_status_enum__WEBPACK_IMPORTED_MODULE_4__["RequestStatus"].New; })).length === 0) {
                            _this.hasNotification = false;
                        }
                    });
                };
                ToolbarComponent.prototype.ngAfterViewInit = function () {
                    var _this = this;
                    this.evtSvc.childEventListner().subscribe(function (info) {
                        _this.hasNotification = false;
                    });
                };
                return ToolbarComponent;
            }());
            ToolbarComponent.ctorParameters = function () { return [
                { type: _project_http_service__WEBPACK_IMPORTED_MODULE_2__["HttpService"] },
                { type: _project_participants_event_service__WEBPACK_IMPORTED_MODULE_3__["EventService"] }
            ]; };
            ToolbarComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
                    selector: 'app-toolbar',
                    template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./toolbar.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/toolbar/toolbar.component.html")).default,
                    providers: [_project_http_service__WEBPACK_IMPORTED_MODULE_2__["HttpService"]],
                    styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./toolbar.component.less */ "./src/app/toolbar/toolbar.component.less")).default]
                })
            ], ToolbarComponent);
            /***/ 
        }),
        /***/ "./src/environments/environment.ts": 
        /*!*****************************************!*\
          !*** ./src/environments/environment.ts ***!
          \*****************************************/
        /*! exports provided: environment */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "environment", function () { return environment; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            // This file can be replaced during build by using the `fileReplacements` array.
            // `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
            // The list of file replacements can be found in `angular.json`.
            var environment = {
                production: false
            };
            /*
             * For easier debugging in development mode, you can import the following file
             * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
             *
             * This import should be commented out in production mode because it will have a negative impact
             * on performance if an error is thrown.
             */
            // import 'zone.js/dist/zone-error';  // Included with Angular CLI.
            /***/ 
        }),
        /***/ "./src/main.ts": 
        /*!*********************!*\
          !*** ./src/main.ts ***!
          \*********************/
        /*! no exports provided */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/platform-browser-dynamic */ "./node_modules/@angular/platform-browser-dynamic/fesm2015/platform-browser-dynamic.js");
            /* harmony import */ var _app_app_module__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./app/app.module */ "./src/app/app.module.ts");
            /* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./environments/environment */ "./src/environments/environment.ts");
            if (_environments_environment__WEBPACK_IMPORTED_MODULE_4__["environment"].production) {
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["enableProdMode"])();
            }
            Object(_angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_2__["platformBrowserDynamic"])().bootstrapModule(_app_app_module__WEBPACK_IMPORTED_MODULE_3__["AppModule"])
                .catch(function (err) { return console.error(err); });
            /***/ 
        }),
        /***/ 0: 
        /*!***************************!*\
          !*** multi ./src/main.ts ***!
          \***************************/
        /*! no static exports found */
        /***/ (function (module, exports, __webpack_require__) {
            module.exports = __webpack_require__(/*! D:\GIT\TheraLang\TheraLang\examples\MvcWeb\ClientApp\src\main.ts */ "./src/main.ts");
            /***/ 
        })
    }, [[0, "runtime", "vendor"]]]);
//# sourceMappingURL=main-es2016.js.map
//# sourceMappingURL=main-es2016.js.map
//# sourceMappingURL=main-es2016.js.map