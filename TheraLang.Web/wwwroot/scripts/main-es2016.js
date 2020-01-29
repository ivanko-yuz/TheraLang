(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["main"],{

/***/ "./$$_lazy_route_resource lazy recursive":
/*!******************************************************!*\
  !*** ./$$_lazy_route_resource lazy namespace object ***!
  \******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

function webpackEmptyAsyncContext(req) {
	// Here Promise.resolve().then() is used instead of new Promise() to prevent
	// uncaught exception popping up in devtools
	return Promise.resolve().then(function() {
		var e = new Error("Cannot find module '" + req + "'");
		e.code = 'MODULE_NOT_FOUND';
		throw e;
	});
}
webpackEmptyAsyncContext.keys = function() { return []; };
webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
module.exports = webpackEmptyAsyncContext;
webpackEmptyAsyncContext.id = "./$$_lazy_route_resource lazy recursive";

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/app.component.html":
/*!**************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/app.component.html ***!
  \**************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<router-outlet></router-outlet>");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/core/footer/footer.component.html":
/*!*****************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/core/footer/footer.component.html ***!
  \*****************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<footer>\r\n    <div fxFlex=\"none\">\r\n        <img src=\"assets/img/uttmm2.png\" alt=\"Logo\" class=\"logo\">\r\n    </div>\r\n    <div class=\"footerMainBlock\" fxFlex fxLayout=\"column\" fxLayoutAlign=\"end stretch\">\r\n        <span>(c) All rights reserved</span>\r\n    </div>\r\n    <div class=\"footerAboutBlock\" fxFlex=\"none\" div fxLayout=\"column\" fxLayoutAlign=\"center stretch\">\r\n        <span>+38 (068) 33 623 77</span>\r\n        <span>+38 (066) 47 654 64</span>\r\n    </div>\r\n</footer>");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/core/toolbar/cms-pages-toolbar-item/cms-pages-toolbar-item.component.html":
/*!*********************************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/core/toolbar/cms-pages-toolbar-item/cms-pages-toolbar-item.component.html ***!
  \*********************************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<a mat-button class=\"menu-item\" [matMenuTriggerFor]=\"menu\">{{'components.cms-pages.title'|translate}}</a>\r\n<mat-menu #menu=\"matMenu\">\r\n    <app-toolbar-item *ngFor=\"let toolbarItem of toolbarItems\" [toolbarItem]=\"toolbarItem\"></app-toolbar-item>\r\n</mat-menu>");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/core/toolbar/language/language.component.html":
/*!*****************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/core/toolbar/language/language.component.html ***!
  \*****************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<button mat-button [matMenuTriggerFor]=\"menu\"><mat-icon>language</mat-icon></button>\r\n<mat-menu #menu=\"matMenu\">\r\n  <button mat-menu-item *ngFor=\"let lang of languages\" [innerText]=\"lang\" (click)=\"changeLang(lang)\"></button>\r\n</mat-menu>\r\n");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/core/toolbar/profile-menu/profile-menu.component.html":
/*!*************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/core/toolbar/profile-menu/profile-menu.component.html ***!
  \*************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<button mat-icon-button [matMenuTriggerFor]=\"menu\"><mat-icon>account_circle</mat-icon></button>\r\n<mat-menu #menu=\"matMenu\">\r\n  <button mat-menu-item (click)=\"onLogout()\">{{'components.account.logout'|translate}}</button>\r\n</mat-menu>\r\n");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/core/toolbar/toolbar-item/toolbar-item.component.html":
/*!*************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/core/toolbar/toolbar-item/toolbar-item.component.html ***!
  \*************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<ng-template [ngIf]=\"isFinalMenu()\">\r\n  <button mat-menu-item [routerLink]=\"toolbarItem.permalink\" [innerText]=\"toolbarItem.title\" (click)=\"onClick()\"></button>\r\n</ng-template>\r\n\r\n<ng-template [ngIf]=\"needSubMenus()\">\r\n  <button mat-menu-item [innerText]=\"toolbarItem.title\" [matMenuTriggerFor]=\"menu\"></button>\r\n  <mat-menu #menu=\"matMenu\">\r\n    <app-toolbar-item *ngFor=\"let subItem of toolbarItem.subItems\" [toolbarItem]=\"subItem\"></app-toolbar-item>\r\n  </mat-menu>\r\n</ng-template>");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/core/toolbar/toolbar.component.html":
/*!*******************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/core/toolbar/toolbar.component.html ***!
  \*******************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<div>\r\n  <mat-toolbar class=\"mat-elevation-z3\">\r\n    <div class=\"img-wrapper\">\r\n      <a mat-button class=\"img-wrapper\" routerLink=\"/\">\r\n        <img src=\"assets/img/uttmm.png\" alt=\"Home\" class=\"img-wrapper\">\r\n      </a>\r\n\r\n      <app-cms-pages-toolbar-item *ngIf=\"isAuthinticated\"></app-cms-pages-toolbar-item>\r\n      \r\n      <a mat-button class=\"menu-item\" routerLink=\"/projects\">{{'components.projects.title'|translate}}</a>\r\n      <a mat-button class=\"menu-item\" routerLink=\"/donations\">{{'components.donation.title'|translate}}</a>\r\n      <a mat-button class=\"menu-item\" *ngIf=\"isAuthinticated\"\r\n        routerLink=\"/resources\">{{'components.resources.title'|translate}}</a>\r\n      <a mat-button class=\"menu-item\" *ngIf=\"isAuthinticated\"\r\n        routerLink=\"/participants\">{{'components.participation.title'|translate}}\r\n        <span>\r\n          <mat-icon *ngIf=\"hasNotification\">notifications</mat-icon>\r\n        </span>\r\n      </a>\r\n      <a mat-button class=\"menu-item\" *ngIf=\"isAuthinticated\"\r\n        routerLink=\"/projectRequest\">{{'components.projects.new-projects'|translate}}</a>\r\n      <a mat-button class=\"menu-item\" *ngIf=\"isAuthinticated\"\r\n        routerLink=\"/projectTypes\">{{'components.projectTypes.title'|translate}}</a>\r\n    </div>\r\n\r\n    <span class=\"fill-space\"></span>\r\n\r\n    <div>\r\n      <span class=\"language\">\r\n        <app-language></app-language>\r\n      </span>\r\n      <button mat-flat-button color=\"primary\" *ngIf=\"!isAuthinticated\" class=\"toolbar-button\"\r\n      routerLink=\"/login\">{{'components.account.signIn'|translate}}</button>\r\n    </div>\r\n\r\n    <span *ngIf=\"isAuthinticated\">\r\n      <app-profile-menu></app-profile-menu>\r\n    </span>\r\n\r\n  </mat-toolbar>\r\n  <div class=\"fill-toolbar-space\"></div>\r\n</div>");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/cms-generic/components/block/block.component.html":
/*!*****************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/modules/cms-generic/components/block/block.component.html ***!
  \*****************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("\r\n<div class=\"row\" *ngIf=\"model.type=='Piranha.Extend.Blocks.ImageBlock' \">\r\n  <div class=\"ImageBlock\">\r\n    <img *ngIf=\"model.body.hasValue\" src=\"{{this.cutLink()}}\">   \r\n  </div>\r\n</div>\r\n\r\n<div class=\"row\" id=\"quoteBlock\" *ngIf=\"model.type=='Piranha.Extend.Blocks.QuoteBlock' \">\r\n  <div class=\"QuoteBlock\">\r\n    <blockquote [innerHTML]=\"model.body.value\">\r\n    </blockquote>\r\n  </div>\r\n</div>\r\n\r\n<div class=\"row\" *ngIf=\"model.type=='Piranha.Extend.Blocks.HtmlBlock' \">\r\n  <div class=\"HtmlBlock\" [innerHTML]=\"model.body.value\"></div>\r\n</div>\r\n\r\n<div class=\"column-block\" id=\"col-block\" *ngIf=\"model.type=='Piranha.Extend.Blocks.ColumnBlock'\">\r\n  <app-block *ngFor=\"let block of model.items\" [model]=\"block\"></app-block>\r\n</div>\r\n\r\n<div class=\"TextBlockDiv\" *ngIf=\"model.type=='Piranha.Extend.Blocks.TextBlock' \">\r\n  <div class=\"TextBlock\" [innerHTML]=\"model.body.value\"></div>\r\n</div>\r\n\r\n<div class=\"AudioBlock\" *ngIf=\"model.type=='Piranha.Extend.Blocks.AudioBlock' \">\r\n  <audio controls>\r\n    <source *ngIf=\"model.body.hasValue\" src=\"{{this.cutLink()}}\" type>\r\n  </audio>\r\n</div>\r\n\r\n<div class=\"VideoBlock\" *ngIf=\"model.type=='Piranha.Extend.Blocks.VideoBlock' \">\r\n  <video controls>\r\n    <source *ngIf=\"model.body.hasValue\" src=\"{{this.cutLink()}}\">\r\n  </video>\r\n</div>\r\n\r\n<div class=\"SeparatorBlock\" *ngIf=\"model.type=='Piranha.Extend.Blocks.SeparatorBlock' \">\r\n  <hr>\r\n</div>\r\n\r\n<div class=\"GalleryBlock\" *ngIf=\"model.type=='Piranha.Extend.Blocks.ImageGalleryBlock' \">\r\n  <app-gallery-block  [block]=\"model\"></app-gallery-block>\r\n</div>");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/cms-generic/components/cms-generic-page/cms-generic-page.component.html":
/*!***************************************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/modules/cms-generic/components/cms-generic-page/cms-generic-page.component.html ***!
  \***************************************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<app-piranha-page  *ngIf=\"cmsRoute\" [cmsRoute]=\"cmsRoute\"></app-piranha-page>\r\n");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/cms-generic/components/gallery-block/gallery-block.component.html":
/*!*********************************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/modules/cms-generic/components/gallery-block/gallery-block.component.html ***!
  \*********************************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<ngb-carousel>\r\n    <ng-template ngbSlide *ngFor=\"let item of block.items\">\r\n        <div class=\"picsum-img-wrapper\">\r\n            <img [src]=\"this.cutLink(item.body.media.publicUrl)\" alt=\"Random first slide\">\r\n        </div>\r\n    </ng-template>\r\n</ngb-carousel>");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/cms-generic/components/piranha-page/piranha-page.component.html":
/*!*******************************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/modules/cms-generic/components/piranha-page/piranha-page.component.html ***!
  \*******************************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<div *ngIf=\"ifGenerate\">\r\n  <h1>{{this.page.title}}</h1>\r\n  <app-block *ngFor=\"let block of this.page.blocks\" [model]=\"block\"></app-block>\r\n</div>");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/login/login.component.html":
/*!******************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/modules/login/login.component.html ***!
  \******************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<mat-card>\r\n  <a [routerLink] = \"['/']\"><img class=\"back-img\" type=\"image\" src=\"/assets/img/back.png\"></a>\r\n  <mat-card-title><img src=\"/assets/img/login.png\" alt=\"\"></mat-card-title>\r\n  <mat-card-content>\r\n    <form [formGroup]=\"this.userService.loginForm\" autocomplete=\"off\">\r\n      <p>\r\n        <mat-form-field appearance=\"outline\">\r\n          <mat-label>{{'components.account.login'|translate}}</mat-label>\r\n          <input formControlName=\"username\" autofocus matInput>\r\n          <mat-error *ngIf=\"this.userService.loginForm.get('username').errors?.required\">{{'components.account.error-input-required'|translate}}</mat-error>\r\n          <mat-error\r\n            *ngIf=\"this.userService.loginForm.get('username').errors?.minlength || this.userService.loginForm.get('username').errors?.maxlength\">\r\n            {{'components.account.error-input-login-length'|translate}}</mat-error>\r\n        </mat-form-field>\r\n      </p>\r\n\r\n      <p>\r\n        <mat-form-field appearance=\"outline\">\r\n          <mat-label>{{'components.account.password'|translate}}</mat-label>\r\n          <input formControlName=\"password\" matInput [type]=\"hide ? 'password' : 'text'\">\r\n\r\n          <mat-error *ngIf=\"this.userService.loginForm.get('password').errors?.required\">{{'components.account.error-input-required'|translate}} </mat-error>\r\n          <mat-error\r\n            *ngIf=\"this.userService.loginForm.get('password').errors?.minlength || this.userService.loginForm.get('password').errors?.maxlength\">\r\n            {{'components.account.error-input-password-length'|translate}}</mat-error>\r\n\r\n          <button mat-icon-button matSuffix (click)=\"hide = !hide\" [attr.aria-label]=\"'Hide password'\"\r\n            [attr.aria-pressed]=\"'hide'\">\r\n            <mat-icon>{{hide ? 'visibility_off' : 'visibility'}}</mat-icon>\r\n          </button>\r\n\r\n        </mat-form-field>\r\n      </p>\r\n\r\n\r\n      <div class=\"button\">\r\n        <button mat-raised-button color=\"primary\" type=\"submit\" [disabled]=\"this.userService.loginForm.invalid\"\r\n          (click)=\"onSubmit()\">{{'common.confirm'|translate}}</button>\r\n      </div>\r\n\r\n\r\n    </form>\r\n  </mat-card-content>\r\n</mat-card>");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/main.component.html":
/*!****************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/main.component.html ***!
  \****************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<div class=\"app-container\" fxLayout=\"column\" fxLayoutAlign=\"start stretch\">\r\n  <div><app-toolbar></app-toolbar></div>\r\n  <div><router-outlet></router-outlet></div>\r\n  <div fxFlex fxFlexFill></div>\r\n  <div><app-footer></app-footer></div>\r\n</div>\r\n");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/donation/donation.component.html":
/*!***********************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/donation/donation.component.html ***!
  \***********************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<div *ngIf=\"projectId === 0; else projectDonation\">\r\n  <h2 class=\"organization-donation-header\">{{'components.donation.donate-4-org'|translate}}</h2>\r\n</div>\r\n<ng-template #projectDonation>\r\n  <h2 class=\"organization-donation-header\">{{'components.donation.donate-4-project'|translate}}</h2>\r\n</ng-template>\r\n<h3 class=\"donation-header\">{{'components.donation.message'|translate}}</h3>\r\n<mat-form-field class=\"form-field\">\r\n  <input matInput type=\"number\" placeholder=\"\" [(ngModel)]=\"donationAmount\" autofocus>\r\n  <button mat-button *ngIf=\"donationAmount\" matSuffix mat-icon-button aria-label=\"Clear\" (click)=\"donationAmount = ''\">\r\n    <mat-icon>close</mat-icon>\r\n  </button>\r\n</mat-form-field>\r\n<br>\r\n<span class=\"donate-button\"><button mat-button color=\"primary\" (click)=\"checkout()\">{{'components.donation.title'|translate}}</button></span>\r\n<div><img src=\"assets/img/paymentmethods.png\" alt=\"\" class=\"payment-methods\"></div>\r\n");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/home/home.component.html":
/*!***************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/home/home.component.html ***!
  \***************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<h1>{{'components.home.title'|translate}}</h1>\r\n\r\n<img src=\"/assets/img/uttmm.png\" alt=\"\" class=\"main-image\">");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-form/project-form.component.html":
/*!***************************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-form/project-form.component.html ***!
  \***************************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<h2 mat-dialog-title>\r\n  <span>{{'components.projects.'+(this.service.form.controls['id'].value?'PROJECT-EDITING':'PROJECT-CREATION')|translate}}</span>\r\n</h2>\r\n<form [formGroup]=\"this.service.form\">\r\n  <mat-dialog-content>\r\n    <mat-form-field>\r\n      <input type=\"hidden\" formControlName=\"id\">\r\n      <input formControlName=\"name\" autofocus required matInput [placeholder]=\"'components.projects.name-of-project'|translate\">\r\n      <mat-error *ngIf=\"service.form.controls['name'].errors?.required\">{{'common.validation.field-is-required'|translate}}</mat-error>\r\n      <mat-error *ngIf=\"service.form.controls['name'].errors?.minlength\">{{'common.validation.line-too-short'|translate}}</mat-error>\r\n      <mat-error *ngIf=\"service.form.controls['name'].errors?.maxlength\">{{'common.validation.line-too-long'|translate}}</mat-error>\r\n    </mat-form-field>\r\n    <mat-form-field>\r\n      <mat-label>{{'common.type'|translate}}</mat-label>\r\n      <mat-select formControlName=\"typeId\" required>\r\n        <mat-option *ngFor=\"let type of projectTypes\" [value]=\"type.id\">\r\n          {{type.typeName}}\r\n        </mat-option>\r\n      </mat-select>\r\n      <mat-error *ngIf=\"service.form.controls['typeId'].errors?.required\">{{'common.validation.field-is-required'|translate}}</mat-error>\r\n    </mat-form-field>\r\n    <mat-form-field>\r\n      <textarea formControlName=\"description\"  required matTextareaAutosize matInput [placeholder]=\"'components.projects.description'|translate\"></textarea>\r\n      <mat-error *ngIf=\"service.form.controls['description'].errors?.required\">{{'common.validation.field-is-required'|translate}}</mat-error>\r\n      <mat-error *ngIf=\"service.form.controls['description'].errors?.minlength\">{{'common.validation.line-too-short'|translate}}</mat-error>\r\n      <mat-error *ngIf=\"service.form.controls['description'].errors?.maxlength\">{{'common.validation.line-too-long'|translate}}</mat-error>\r\n    </mat-form-field>\r\n    <mat-form-field>\r\n      <textarea formControlName=\"details\" matTextareaAutosize matInput [placeholder]=\"'components.projects.details'|translate\"></textarea>\r\n      <mat-error *ngIf=\"service.form.controls['details'].errors?.maxlength\">{{'common.validation.line-too-long'|translate}}</mat-error>\r\n    </mat-form-field>\r\n    <mat-form-field>\r\n      <input formControlName=\"projectStart\" type=[valueAsDate] matInput [matDatepicker]=\"picker\" required [placeholder]=\"'components.projects.project-starts'|translate\" readonly>\r\n      <mat-datepicker-toggle matSuffix [for]=\"picker\"></mat-datepicker-toggle>\r\n      <mat-datepicker #picker></mat-datepicker>\r\n      <mat-error *ngIf=\"service.form.controls['projectStart'].errors?.required\">{{'common.validation.field-is-required'|translate}}</mat-error>\r\n    </mat-form-field>\r\n    <mat-form-field>\r\n      <input formControlName=\"projectEnd\" matInput [matDatepicker]=\"picker1\" [placeholder]=\"'components.projects.project-ends'|translate\" readonly>\r\n      <mat-datepicker-toggle matSuffix [for]=\"picker1\"></mat-datepicker-toggle>\r\n      <mat-datepicker #picker1></mat-datepicker>\r\n      <mat-error *ngIf=\"service.form.controls['projectEnd'].hasError('matDatepickerFilter')\">{{'common.wth'|translate}}</mat-error>\r\n    </mat-form-field>\r\n    <mat-form-field>\r\n      <input formControlName=\"donationTargetSum\" matInput [placeholder]=\"'components.projects.need'|translate\"  type=\"number\">\r\n      <span matPrefix>₴&nbsp;</span>\r\n    </mat-form-field>\r\n  </mat-dialog-content>\r\n  <mat-dialog-actions>\r\n    <button mat-raised-button color=\"primary\" type=\"submit\" [disabled]=\"this.service.form.invalid\"\r\n      (click)='onSubmit()'>{{'common.validation.confirm'|translate}}</button>\r\n    <button mat-raised-button color=\"warn\" type=\"reset\" (click)=\"onClose()\">{{'common.validation.cancel'|translate}}</button>\r\n  </mat-dialog-actions>\r\n</form>\r\n");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-info/project-info.component.html":
/*!***************************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-info/project-info.component.html ***!
  \***************************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<div class=\"mainDiv\">\r\n  <mat-card class=\"example-card\">\r\n    <mat-card-header>\r\n      <div mat-card-avatar class=\"example-header-image\"></div>\r\n      <mat-card-title class=\"headerUpText\">{{projectInfo.name}}</mat-card-title>\r\n      <mat-card-subtitle class=\"headerDownText\">\r\n        {{'common.added-by'|translate}}\r\n        <a class=\"ownerLink\" routerLink=\"/project/{{projectInfo.id}}\">{{'components.projects.owner'|translate}}</a>\r\n      </mat-card-subtitle>\r\n    </mat-card-header>\r\n\r\n    <img mat-card-image class=\"ProjImg\" src=\"../../assets/img/hatiko.gif\" alt=\"Photo\">\r\n    <mat-card-content>\r\n      <p class=\"description\">{{projectInfo.description}}</p>\r\n    </mat-card-content>\r\n  </mat-card>\r\n  <div class=\"bottom-buttons\">\r\n    <button mat-raised-button class=\"resButton\" (click)=\"onJoin()\">{{'components.projects.join'|translate}}</button>\r\n    <button mat-raised-button class=\"resButton\" (click)=\"getResourcesData()\">{{'components.resources.title'|translate}}</button>\r\n  </div>\r\n  <div>\r\n    <app-resources-table [@openClose]=\"isOpen ? 'open' : 'closed'\" id=\"resTabId\" *ngIf=\"generateOnceResourcesTable\"\r\n      [sortedResourcesByCategory]=\"sortedResourcesByCategory\"></app-resources-table>\r\n  </div>\r\n</div>\r\n");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-info/resources-table-for-project/project-type/project-type.component.html":
/*!********************************************************************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-info/resources-table-for-project/project-type/project-type.component.html ***!
  \********************************************************************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<button mat-raised-button (click)=\"onCreate()\">{{'common.create'|translate}}</button>\r\n<table mat-table [dataSource]=\"projectTypes\" class=\"mat-elevation-z8\">\r\n\r\n  <ng-container matColumnDef=\"typeName\">\r\n    <th mat-header-cell *matHeaderCellDef>{{'common.name'|translate}}</th>\r\n    <td mat-cell *matCellDef=\"let element\"> {{element.typeName}} </td>\r\n  </ng-container>\r\n\r\n  <ng-container matColumnDef=\"actions\">\r\n    <mat-header-cell *matHeaderCellDef></mat-header-cell>\r\n    <mat-cell *matCellDef=\"let element\">\r\n      <div>\r\n        <span class=\"editButton\">\r\n          <button mat-raised-button (click)=\"onEdit({id: element.id, typeName: element.typeName})\">{{'common.edit'|translate}}</button>\r\n        </span>\r\n        <span class=\"deleteButton\">\r\n          <button mat-raised-button (click)=\"onDelete(element.id)\">{{'common.delete'|translate}}</button>\r\n        </span>\r\n      </div>\r\n    </mat-cell>\r\n  </ng-container>\r\n\r\n  <tr mat-header-row *matHeaderRowDef=\"displayedColumns\"></tr>\r\n  <tr mat-row *matRowDef=\"let row; columns: displayedColumns;\"></tr>\r\n</table>\r\n");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-info/resources-table-for-project/resources-internal-table/resources-internal-table.component.html":
/*!********************************************************************************************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-info/resources-table-for-project/resources-internal-table/resources-internal-table.component.html ***!
  \********************************************************************************************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<div class=\"mat-elevation-z8\">\r\n  <table mat-table [dataSource]='dataSource'>\r\n\r\n\r\n    <ng-container matColumnDef=\"id\">\r\n      <th mat-header-cell *matHeaderCellDef> ID </th>\r\n      <td mat-cell *matCellDef=\"let i = index\"> {{i+1}} </td>\r\n    </ng-container>\r\n\r\n\r\n    <ng-container matColumnDef=\"name\">\r\n      <th mat-header-cell *matHeaderCellDef>{{'common.name'|translate}}</th>\r\n      <td mat-cell *matCellDef=\"let element\"> {{element.name}} </td>\r\n    </ng-container>\r\n\r\n\r\n    <ng-container matColumnDef=\"date\">\r\n      <th mat-header-cell *matHeaderCellDef>{{'common.date-of-creation'|translate}}</th>\r\n      <td mat-cell *matCellDef=\"let element\"> {{element.createdDateUtc | customDate}} </td>\r\n    </ng-container>\r\n\r\n\r\n    <ng-container matColumnDef=\"description\">\r\n      <th mat-header-cell *matHeaderCellDef>{{'common.description'|translate}}</th>\r\n      <td mat-cell *matCellDef=\"let element\"> {{element.description}} </td>\r\n    </ng-container>\r\n\r\n    <tr mat-header-row *matHeaderRowDef=\"displayedColumns; sticky: true\"></tr>\r\n    <tr mat-row *matRowDef=\"let row; columns: displayedColumns;\"></tr>\r\n  </table>\r\n  <mat-paginator [length]=\"lengthDataArrForDataSource\" [pageSize]=\"this.pageSize\"\r\n    [pageSizeOptions]=\"this.pageSizeOptions\" showFirstLastButtons></mat-paginator>\r\n</div>\r\n");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-info/resources-table-for-project/resources-table/resources-table.component.html":
/*!**************************************************************************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-info/resources-table-for-project/resources-table/resources-table.component.html ***!
  \**************************************************************************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<mat-tab-group mat-stretch-tabs class=\"resTab example-stretched-tabs mat-elevation-z4\"\r\n    (selectedTabChange)=\"convertMatTabChangeEventLabelToString($event)\">\r\n    <mat-tab *ngFor=\"let category of this.resourceService.getAllResourceCategories(sortedResourcesByCategory)\"\r\n        label=\"{{category}}\">\r\n        <app-resources-internal-table [dataSource]=\"dataSource\"\r\n            [lengthDataArrForDataSource]=\"lengthDataArrForDataSource\"></app-resources-internal-table>\r\n    </mat-tab>\r\n</mat-tab-group>");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-participants/project-participants.component.html":
/*!*******************************************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-participants/project-participants.component.html ***!
  \*******************************************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<mat-tab-group class=\"participation-tab\" animationDuration=\"0ms\" #tabPosition\r\n  (selectedTabChange)=\"changeTab(tabPosition.selectedIndex)\">\r\n  <mat-tab label=\"Нові\"></mat-tab>\r\n  <mat-tab label=\"Підтверджені\"></mat-tab>\r\n  <mat-tab label=\"Відхилені\"> </mat-tab>\r\n</mat-tab-group>\r\n<div class=\"mat-elevation-z8\">\r\n  <table mat-table [dataSource]=\"projectParticipationRequest\" *ngIf=\"projectParticipationRequest.filteredData.length > 0\">\r\n\r\n    <ng-container matColumnDef=\"requestedUserName\">\r\n      <th mat-header-cell *matHeaderCellDef>{{'components.user.user-name'|translate}}</th>\r\n      <td mat-cell *matCellDef=\"let element\"> {{element.requestedUserName}} </td>\r\n    </ng-container>\r\n\r\n    <ng-container matColumnDef=\"requestedUserEmail\">\r\n      <th mat-header-cell *matHeaderCellDef>{{'components.user.email'|translate}}</th>\r\n      <td mat-cell *matCellDef=\"let element\"> {{element.requestedUserEmail}} </td>\r\n    </ng-container>\r\n\r\n    <ng-container matColumnDef=\"projectName\">\r\n      <th mat-header-cell *matHeaderCellDef>{{'components.projects.name-of-project'|translate}}</th>\r\n      <td mat-cell *matCellDef=\"let element\"> {{element.projectName}} </td>\r\n    </ng-container>\r\n\r\n    <ng-container matColumnDef=\"status\">\r\n      <th mat-header-cell *matHeaderCellDef>{{'common.status'|translate}}</th>\r\n      <td mat-cell *matCellDef=\"let element\"> {{element.status}} </td>\r\n    </ng-container>\r\n\r\n    <ng-container matColumnDef=\"actions\">\r\n      <mat-header-cell *matHeaderCellDef></mat-header-cell>\r\n      <mat-cell *matCellDef=\"let participationRequest\">\r\n        <div *ngIf=\"showActionButtons\">\r\n          <span class=\"aproveButton\">\r\n            <button mat-raised-button (click)=\"changeStatus('approved', participationRequest)\">{{'common.approve'|translate}}</button>\r\n          </span>\r\n          <span class=\"rejectButton\">\r\n            <button mat-raised-button (click)=\"changeStatus('rejected', participationRequest)\">{{'common.reject'|translate}}</button>\r\n          </span>\r\n        </div>\r\n        <div *ngIf=\"!showActionButtons\">\r\n          <span class=\"toNewButton\" >\r\n            <button mat-raised-button (click)=\"changeStatus('new', participationRequest)\">{{'common.toNew'|translate}}</button>\r\n          </span>\r\n        </div>\r\n      </mat-cell>\r\n    </ng-container>\r\n\r\n    <tr mat-header-row *matHeaderRowDef=\"displayedColumns\"></tr>\r\n    <tr mat-row *matRowDef=\"let row; columns: displayedColumns;\"></tr>\r\n  </table>\r\n  <div class=\"noData\" *ngIf=\"projectParticipationRequest.filteredData.length === 0\">\r\n    <h2>{{'components.participation.empty-list'|translate}}</h2>\r\n  </div>\r\n  <mat-paginator [pageSizeOptions]=\"[5, 10, 20]\" showFirstLastButtons></mat-paginator>\r\n</div>\r\n");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-request/project-request.component.html":
/*!*********************************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-request/project-request.component.html ***!
  \*********************************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<mat-tab-group\r\n  class=\"participation-tab\"\r\n  animationDuration=\"0ms\"\r\n  #tabPosition\r\n  (selectedTabChange)=\"changeTab(tabPosition.selectedIndex)\"\r\n>\r\n  <mat-tab [label]=\"'common.new'|translate\"></mat-tab>\r\n  <mat-tab [label]=\"'common.approved'|translate\"></mat-tab>\r\n  <mat-tab [label]=\"'common.rejected'|translate\"> </mat-tab>\r\n</mat-tab-group>\r\n\r\n\r\n<div *ngFor=\"let project of projects\">\r\n  <mat-card class=\"project-card\">\r\n    <mat-card-header class=\"header\"> </mat-card-header>\r\n    <mat-card-title>{{ project?.name }}</mat-card-title>\r\n    <mat-card-subtitle>Ukraine, id - {{ project?.id }}</mat-card-subtitle>\r\n    <img\r\n      class=\"project-image\"\r\n      mat-card-image\r\n      src=\"http://r.ddmcdn.com/s_f/o_1/cx_462/cy_245/cw_1349/ch_1349/w_720/APL/uploads/2015/06/caturday-shutterstock_149320799.jpg\"\r\n      alt=\"\"\r\n    />\r\n    <mat-card-content>\r\n      <div class=\"project-info\">\r\n        {{ project?.description }}\r\n        <p>\r\n          {{'components.projects.project-starts'|translate}} {{ project?.projectStart | date: \"dd/MM/yyyy\" }}\r\n        </p>\r\n        <p>\r\n          {{'components.projects.project-ends'|translate}} {{ project?.projectEnd | date: \"dd/MM/yyyy\" }}\r\n        </p>\r\n      </div>\r\n    </mat-card-content>\r\n    <div class=\"clear\"></div>\r\n    <mat-card-actions class=\"get-details-button\">\r\n      <div *ngIf=\"showActionButtons\">\r\n        <span class=\"aproveButton\">\r\n          <button\r\n            mat-stroked-button\r\n            (click)=\"changeStatus('approved', project)\"\r\n          >\r\n            {{'common.approve'|translate}}\r\n          </button>\r\n        </span>\r\n        <span class=\"rejectButton\">\r\n          <button\r\n            mat-stroked-button\r\n            (click)=\"changeStatus('rejected', project)\"\r\n          >\r\n            {{'common.reject'|translate}}\r\n          </button>\r\n        </span>\r\n      </div>\r\n    </mat-card-actions>\r\n  </mat-card>\r\n</div>\r\n");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-type-create-form/project-type-create-form.component.html":
/*!***************************************************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-type-create-form/project-type-create-form.component.html ***!
  \***************************************************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<h1 mat-dialog-title>{{'components.projectTypes.new-p-t-creation'|translate}}</h1>\r\n<div mat-dialog-content>\r\n    <p>{{'components.projectTypes.enter-new-type-name'|translate}}</p>\r\n    <mat-form-field>\r\n        <input matInput [(ngModel)]=\"this.newData.typeName\">\r\n    </mat-form-field>\r\n</div>\r\n<div mat-dialog-actions>\r\n    <button mat-button (click)=\"onCloseForm()\">{{'common.cancel'|translate}}</button>\r\n    <button mat-flat-button color=\"primary\" [mat-dialog-close]=\"this.newData.typeName\" cdkFocusInitial (click)=\"onSubmit()\">{{'common.confirm'|translate}}</button>\r\n</div>\r\n");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-type-form/project-type-form.component.html":
/*!*************************************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-type-form/project-type-form.component.html ***!
  \*************************************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<h1 mat-dialog-title>ID {{data.id}}</h1>\r\n<div mat-dialog-content>\r\n    <p>{{'components.projectTypes.enter-new-type-name'|translate}}</p>\r\n    <mat-form-field>\r\n        <input matInput [(ngModel)]=\"data.name\">\r\n    </mat-form-field>\r\n</div>\r\n<div mat-dialog-actions>\r\n    <button mat-button (click)=\"onCloseForm()\">{{'common.cancel'|translate}}</button>\r\n    <button mat-flat-button color=\"primary\" [mat-dialog-close]=\"data.name\" cdkFocusInitial (click)=\"onSubmit()\">{{'common.confirm'|translate}}</button>\r\n</div>\r\n");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project.component.html":
/*!*********************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project.component.html ***!
  \*********************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<button mat-stroked-button (click)=\"onCreate()\">\r\n  <mat-icon>add</mat-icon>{{'components.projects.create'|translate}}\r\n</button>\r\n\r\n<div *ngFor=\"let project of projects\">\r\n  <mat-card class=\"home-card mat-elevation-z5\">\r\n    <mat-card-content class=\"home-card-content\" fxLayout=\"row\">\r\n      \r\n      <div class=\"image-container\" >\r\n        <img class=\"project-image\" src=\"http://r.ddmcdn.com/s_f/o_1/cx_462/cy_245/cw_1349/ch_1349/w_720/APL/uploads/2015/06/caturday-shutterstock_149320799.jpg\" alt=\"\">\r\n      </div>\r\n\r\n      <div class=\"main-container\" fxLayout=\"column\" >\r\n        \r\n        <div class=\"content-container\"  fxLayout=\"row\" fxFlex = \"85\">\r\n          <div class=\"text-conteiner\" fxLayout = \"column\"  fxFlex = \"95\">\r\n            <mat-card-title>\r\n              <a class = \"detailes\" [routerLink]=\"['/projects', project.id]\"> {{project?.name}}</a>\r\n            </mat-card-title>\r\n            <div class = \"project-description\" fxFlex = \"100\">\r\n            {{project?.description.substring(0, 550)}}\r\n            </div>\r\n          </div>\r\n          <div class=\"buttons-container\" fxLayout=\"row\" fxFlex>\r\n            <button mat-icon-button (click)=\"onEdit(project)\">\r\n              <mat-icon>edit</mat-icon>\r\n            </button>\r\n            <button mat-icon-button (click)=\"onDelete(project.id)\">\r\n              <mat-icon>delete</mat-icon>\r\n            </button>\r\n          </div>\r\n        </div>\r\n   \r\n     \r\n        <div class=\"actions-conteiner\"  fxLayout=\"row\">\r\n          <div class=\"progress-bar-block\" fxFlex = \"33\">\r\n            <div class=\"text-content\" >\r\n              <span class=\"donation-sum\">₴{{project.donationsSum}} </span> \r\n              <span class=\"rised-sum\"> {{'components.projects.rised-of'|translate}} {{project.donationTargetSum}}</span>\r\n            </div>\r\n            <section class=\"progress-bar-section\">\r\n              <mat-progress-bar\r\n                class=\"example-margin\"\r\n                [color]=\"primary\"\r\n                [mode]=\"determinate\"\r\n                [value]=\"getProjectProgress(project) * 100\">\r\n              </mat-progress-bar>\r\n            </section>\r\n          </div>\r\n          <div class=\"days-left-block\"  fxLayout=\"column\" fxFlex = \"none\">\r\n            <span class=\"days\">{{project | daysLeft}}</span>\r\n            <span  *ngIf=\"(project | daysLeft) >= 0\" clas=\"texter\">{{'components.projects.days-left'|translate}}</span>\r\n          </div>\r\n          <div class=\"donate-button\" fxFlexAlign=\"end end\" fxFlex = \"70\" fxLayoutAlign=\"end end\">\r\n            <button mat-raised-button color = \"primary\" [routerLink]=\"['/donations', project.id]\">{{'components.projects.donate'|translate}}</button>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </mat-card-content>\r\n  </mat-card>\r\n</div>");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/resource/general-resources-tables/general-resources-inner-table/general-resources-inner-table.component.html":
/*!***************************************************************************************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/resource/general-resources-tables/general-resources-inner-table/general-resources-inner-table.component.html ***!
  \***************************************************************************************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<div class=\"mat-elevation-z8\" *ngIf=\"showTable\">\r\n  <table mat-table [dataSource]=\"dataSource\">\r\n    <ng-container matColumnDef=\"name\">\r\n      <th mat-header-cell *matHeaderCellDef>{{ \"common.name\" | translate }}</th>\r\n      <td mat-cell *matCellDef=\"let element\">{{ element.name }}</td>\r\n    </ng-container>\r\n\r\n    <ng-container matColumnDef=\"date\">\r\n      <th mat-header-cell *matHeaderCellDef>\r\n        {{ \"common.date-of-creation\" | translate }}\r\n      </th>\r\n      <td mat-cell *matCellDef=\"let element\">\r\n        {{ element.createdDateUtc | customDate }}\r\n      </td>\r\n    </ng-container>\r\n\r\n    <ng-container matColumnDef=\"description\">\r\n      <th mat-header-cell *matHeaderCellDef>\r\n        {{ \"common.description\" | translate }}\r\n      </th>\r\n      <td mat-cell *matCellDef=\"let element\">{{ element.description }}</td>\r\n    </ng-container>\r\n\r\n    <ng-container matColumnDef=\"url\">\r\n      <th mat-header-cell *matHeaderCellDef>\r\n        {{ \"common.download\" | translate }}\r\n      </th>\r\n      <td mat-cell *matCellDef=\"let element\">\r\n        <a href=\"{{ element.url }}\">link</a>\r\n      </td>\r\n    </ng-container>\r\n\r\n    <tr mat-header-row *matHeaderRowDef=\"displayedColumns; sticky: true\"></tr>\r\n    <tr mat-row *matRowDef=\"let row; columns: displayedColumns\"></tr>\r\n  </table>\r\n\r\n  <mat-paginator\r\n    *ngIf=\"resources.length > columnsPerPage\"\r\n    [length]=\"this.allResourcesCount\"\r\n    [pageSize]=\"this.columnsPerPage\"\r\n    [pageSizeOptions]=\"this.pageSizeOptions\"\r\n    showFirstLastButtons\r\n    (page)=\"pageChanged($event)\"\r\n  >\r\n  </mat-paginator>\r\n</div>\r\n");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/resource/general-resources-tables/general-resources-table/general-resources-table.component.html":
/*!***************************************************************************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/resource/general-resources-tables/general-resources-table/general-resources-table.component.html ***!
  \***************************************************************************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<button mat-stroked-button (click)=\"addResource()\">\r\n    <mat-icon>add</mat-icon>{{'components.resources.create'|translate}}\r\n</button>\r\n\r\n<mat-tab-group mat-stretch-tabs class=\"resTab example-stretched-tabs mat-elevation-z4\" *ngIf=\"showCategories\">\r\n    <mat-tab  *ngFor=\"let category of this.resourcesCategories\" label=\"{{category.type}}\">\r\n        <app-general-resources-inner-table [resourcesCategoryId]=\"category.id\">\r\n        </app-general-resources-inner-table>\r\n    </mat-tab>\r\n</mat-tab-group>\r\n");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/resource/general-resources.component.html":
/*!********************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/resource/general-resources.component.html ***!
  \********************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<div id=\"resTabId\">\r\n<app-resources-table [sortedResourcesByCategory]= 'sortedResourcesByCategory' ></app-resources-table>\r\n</div>\r\n");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/resource/resource-create/resource-create.component.html":
/*!**********************************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/resource/resource-create/resource-create.component.html ***!
  \**********************************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<h2 mat-dialog-title>\r\n  <p>Створити ресурс</p>\r\n</h2>\r\n\r\n<form [formGroup]=\"service.resourceForm\">\r\n  <mat-dialog-content style=\"height: 350px\">\r\n    <div fxLayout=\"column\">\r\n      <mat-form-field class=\"example-full-width\">\r\n        <mat-select\r\n          formControlName=\"categoryId\"\r\n          [placeholder]=\"'components.resources.type' | translate\"\r\n        >\r\n          <mat-option *ngFor=\"let category of categories\" [value]=\"category.id\">\r\n            {{ category.type }}\r\n          </mat-option>\r\n        </mat-select>\r\n      </mat-form-field>\r\n\r\n      <mat-form-field class=\"example-full-width\">\r\n        <input\r\n          formControlName=\"name\"\r\n          autofocus\r\n          matInput\r\n          [placeholder]=\"'components.resources.name' | translate\"\r\n        />\r\n      </mat-form-field>\r\n\r\n      <mat-form-field class=\"example-full-width\">\r\n        <input\r\n          formControlName=\"description\"\r\n          matInput\r\n          [placeholder]=\"'common.description' | translate\"\r\n        />\r\n      </mat-form-field>\r\n\r\n      <mat-form-field class=\"example-full-width\">\r\n        <input\r\n          formControlName=\"url\"\r\n          matInput\r\n          [placeholder]=\"'components.resources.url' | translate\"\r\n        />\r\n      </mat-form-field>\r\n\r\n      <!-- <mat-form-field class=\"example-full-width\">\r\n        <input\r\n          formControlName=\"fileName\"\r\n          matInput\r\n          [placeholder]=\"'components.resources.file-name' | translate\"\r\n        />\r\n      </mat-form-field> -->\r\n    </div>\r\n\r\n    <mat-form-field>\r\n      <ngx-mat-file-input\r\n        formControlName=\"file\"\r\n        [valuePlaceholder]=\"'components.resources.add' | translate\"\r\n      ></ngx-mat-file-input>\r\n      <mat-icon matSuffix>folder</mat-icon>\r\n    </mat-form-field>\r\n\r\n    <mat-dialog-actions class=\"submitButton\">\r\n      <button\r\n        mat-raised-button\r\n        color=\"primary\"\r\n        type=\"submit\"\r\n        [disabled]=\"this.service.resourceForm.invalid\"\r\n        (click)=\"onSubmit()\"\r\n      >\r\n        {{ \"common.confirm\" | translate }}\r\n      </button>\r\n      <button mat-raised-button color=\"warn\" type=\"reset\" (click)=\"onClose()\">\r\n        {{ \"common.cancel\" | translate }}\r\n      </button>\r\n    </mat-dialog-actions>\r\n  </mat-dialog-content>\r\n</form>\r\n");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/manager/manager.component.html":
/*!**********************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/modules/manager/manager.component.html ***!
  \**********************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<p>manager works!</p>\r\n<router-outlet></router-outlet>");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/manager/page-manager/create-page/create-page.component.html":
/*!***************************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/modules/manager/page-manager/create-page/create-page.component.html ***!
  \***************************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<form [formGroup]=\"form\" (ngSubmit)=\"submit()\">\r\n    <div class=\"form-control\">\r\n        <label for=\"title\">Title</label>\r\n        <input id=\"title\" type=\"text\" formControlName=\"title\">\r\n    </div>\r\n\r\n    <div class=\"form-control\">\r\n        <label>Text</label>\r\n        <div class=\"content\">\r\n            <quill-editor formControlName=\"text\"></quill-editor>\r\n            <button type=\"submit\" class=\"btn btn-block btn-dark\">Create page</button>\r\n        </div>\r\n    </div>\r\n</form>");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/manager/page-manager/page-manager.component.html":
/*!****************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/modules/manager/page-manager/page-manager.component.html ***!
  \****************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<button [routerLink]=\"['/manager', 'pages', 'create']\">Create</button>\r\n<router-outlet></router-outlet>");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/shared/components/confirm-dialog/confirm-dialog.component.html":
/*!**********************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/shared/components/confirm-dialog/confirm-dialog.component.html ***!
  \**********************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<h2 mat-dialog-title >{{data.message}}</h2>\r\n<mat-dialog-actions>\r\n<button mat-flat-button id=\"yes-button\" [mat-dialog-close]=\"true\">{{'common.yes'|translate}}</button>\r\n<button mat-dialog- id=\"no-button\" [mat-dialog-close]=\"false\">{{'common.no'|translate}}</button>\r\n</mat-dialog-actions>\r\n");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/shared/components/error/error.component.html":
/*!****************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/shared/components/error/error.component.html ***!
  \****************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<h2>{{'common.error'|translate}}</h2>\r\n<p class=\"text-error\">{{'common.error-so-sorry'|translate}}</p>\r\n<button mat-stroked-buttom (click)=\"goHome()\">{{'common.return-home'|translate}}</button>\r\n");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/shared/components/transaction-result/transaction-result.component.html":
/*!******************************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/shared/components/transaction-result/transaction-result.component.html ***!
  \******************************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<div *ngIf=\"liqpayResponse !== null\">\r\n    <h1>{{'components.donation.transaction-status'|translate}} <span class=\"status-color\">{{liqpayResponse?.status}}</span></h1>\r\n    <h2>{{'common.money-amount'|translate}} <span class=\"status-color\">{{liqpayResponse?.amount}}</span> ₴</h2>\r\n</div>\r\n");

/***/ }),

/***/ "./node_modules/tslib/tslib.es6.js":
/*!*****************************************!*\
  !*** ./node_modules/tslib/tslib.es6.js ***!
  \*****************************************/
/*! exports provided: __extends, __assign, __rest, __decorate, __param, __metadata, __awaiter, __generator, __exportStar, __values, __read, __spread, __spreadArrays, __await, __asyncGenerator, __asyncDelegator, __asyncValues, __makeTemplateObject, __importStar, __importDefault */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__extends", function() { return __extends; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__assign", function() { return __assign; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__rest", function() { return __rest; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__decorate", function() { return __decorate; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__param", function() { return __param; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__metadata", function() { return __metadata; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__awaiter", function() { return __awaiter; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__generator", function() { return __generator; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__exportStar", function() { return __exportStar; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__values", function() { return __values; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__read", function() { return __read; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__spread", function() { return __spread; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__spreadArrays", function() { return __spreadArrays; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__await", function() { return __await; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__asyncGenerator", function() { return __asyncGenerator; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__asyncDelegator", function() { return __asyncDelegator; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__asyncValues", function() { return __asyncValues; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__makeTemplateObject", function() { return __makeTemplateObject; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__importStar", function() { return __importStar; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__importDefault", function() { return __importDefault; });
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

var extendStatics = function(d, b) {
    extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return extendStatics(d, b);
};

function __extends(d, b) {
    extendStatics(d, b);
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
}

var __assign = function() {
    __assign = Object.assign || function __assign(t) {
        for (var s, i = 1, n = arguments.length; i < n; i++) {
            s = arguments[i];
            for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p)) t[p] = s[p];
        }
        return t;
    }
    return __assign.apply(this, arguments);
}

function __rest(s, e) {
    var t = {};
    for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p) && e.indexOf(p) < 0)
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
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
}

function __param(paramIndex, decorator) {
    return function (target, key) { decorator(target, key, paramIndex); }
}

function __metadata(metadataKey, metadataValue) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(metadataKey, metadataValue);
}

function __awaiter(thisArg, _arguments, P, generator) {
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : new P(function (resolve) { resolve(result.value); }).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
}

function __generator(thisArg, body) {
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
}

function __exportStar(m, exports) {
    for (var p in m) if (!exports.hasOwnProperty(p)) exports[p] = m[p];
}

function __values(o) {
    var m = typeof Symbol === "function" && o[Symbol.iterator], i = 0;
    if (m) return m.call(o);
    return {
        next: function () {
            if (o && i >= o.length) o = void 0;
            return { value: o && o[i++], done: !o };
        }
    };
}

function __read(o, n) {
    var m = typeof Symbol === "function" && o[Symbol.iterator];
    if (!m) return o;
    var i = m.call(o), r, ar = [], e;
    try {
        while ((n === void 0 || n-- > 0) && !(r = i.next()).done) ar.push(r.value);
    }
    catch (error) { e = { error: error }; }
    finally {
        try {
            if (r && !r.done && (m = i["return"])) m.call(i);
        }
        finally { if (e) throw e.error; }
    }
    return ar;
}

function __spread() {
    for (var ar = [], i = 0; i < arguments.length; i++)
        ar = ar.concat(__read(arguments[i]));
    return ar;
}

function __spreadArrays() {
    for (var s = 0, i = 0, il = arguments.length; i < il; i++) s += arguments[i].length;
    for (var r = Array(s), k = 0, i = 0; i < il; i++)
        for (var a = arguments[i], j = 0, jl = a.length; j < jl; j++, k++)
            r[k] = a[j];
    return r;
};

function __await(v) {
    return this instanceof __await ? (this.v = v, this) : new __await(v);
}

function __asyncGenerator(thisArg, _arguments, generator) {
    if (!Symbol.asyncIterator) throw new TypeError("Symbol.asyncIterator is not defined.");
    var g = generator.apply(thisArg, _arguments || []), i, q = [];
    return i = {}, verb("next"), verb("throw"), verb("return"), i[Symbol.asyncIterator] = function () { return this; }, i;
    function verb(n) { if (g[n]) i[n] = function (v) { return new Promise(function (a, b) { q.push([n, v, a, b]) > 1 || resume(n, v); }); }; }
    function resume(n, v) { try { step(g[n](v)); } catch (e) { settle(q[0][3], e); } }
    function step(r) { r.value instanceof __await ? Promise.resolve(r.value.v).then(fulfill, reject) : settle(q[0][2], r); }
    function fulfill(value) { resume("next", value); }
    function reject(value) { resume("throw", value); }
    function settle(f, v) { if (f(v), q.shift(), q.length) resume(q[0][0], q[0][1]); }
}

function __asyncDelegator(o) {
    var i, p;
    return i = {}, verb("next"), verb("throw", function (e) { throw e; }), verb("return"), i[Symbol.iterator] = function () { return this; }, i;
    function verb(n, f) { i[n] = o[n] ? function (v) { return (p = !p) ? { value: __await(o[n](v)), done: n === "return" } : f ? f(v) : v; } : f; }
}

function __asyncValues(o) {
    if (!Symbol.asyncIterator) throw new TypeError("Symbol.asyncIterator is not defined.");
    var m = o[Symbol.asyncIterator], i;
    return m ? m.call(o) : (o = typeof __values === "function" ? __values(o) : o[Symbol.iterator](), i = {}, verb("next"), verb("throw"), verb("return"), i[Symbol.asyncIterator] = function () { return this; }, i);
    function verb(n) { i[n] = o[n] && function (v) { return new Promise(function (resolve, reject) { v = o[n](v), settle(resolve, reject, v.done, v.value); }); }; }
    function settle(resolve, reject, d, v) { Promise.resolve(v).then(function(v) { resolve({ value: v, done: d }); }, reject); }
}

function __makeTemplateObject(cooked, raw) {
    if (Object.defineProperty) { Object.defineProperty(cooked, "raw", { value: raw }); } else { cooked.raw = raw; }
    return cooked;
};

function __importStar(mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (Object.hasOwnProperty.call(mod, k)) result[k] = mod[k];
    result.default = mod;
    return result;
}

function __importDefault(mod) {
    return (mod && mod.__esModule) ? mod : { default: mod };
}


/***/ }),

/***/ "./src/app/app-routing.module.ts":
/*!***************************************!*\
  !*** ./src/app/app-routing.module.ts ***!
  \***************************************/
/*! exports provided: AppRoutingModule, routingComponents */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppRoutingModule", function() { return AppRoutingModule; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "routingComponents", function() { return routingComponents; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var _modules_main_pages_project_project_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./modules/main/pages/project/project.component */ "./src/app/modules/main/pages/project/project.component.ts");
/* harmony import */ var _modules_main_main_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./modules/main/main.component */ "./src/app/modules/main/main.component.ts");
/* harmony import */ var _modules_main_pages_home_home_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./modules/main/pages/home/home.component */ "./src/app/modules/main/pages/home/home.component.ts");
/* harmony import */ var _modules_main_pages_project_project_participants_project_participants_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./modules/main/pages/project/project-participants/project-participants.component */ "./src/app/modules/main/pages/project/project-participants/project-participants.component.ts");
/* harmony import */ var _modules_main_pages_project_project_info_project_info_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./modules/main/pages/project/project-info/project-info.component */ "./src/app/modules/main/pages/project/project-info/project-info.component.ts");
/* harmony import */ var _modules_main_pages_donation_donation_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./modules/main/pages/donation/donation.component */ "./src/app/modules/main/pages/donation/donation.component.ts");
/* harmony import */ var _modules_main_pages_resource_general_resources_tables_general_resources_table_general_resources_table_component__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./modules/main/pages/resource/general-resources-tables/general-resources-table/general-resources-table.component */ "./src/app/modules/main/pages/resource/general-resources-tables/general-resources-table/general-resources-table.component.ts");
/* harmony import */ var _shared_components_transaction_result_transaction_result_component__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ./shared/components/transaction-result/transaction-result.component */ "./src/app/shared/components/transaction-result/transaction-result.component.ts");
/* harmony import */ var _modules_main_pages_project_project_info_resources_table_for_project_project_type_project_type_component__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ./modules/main/pages/project/project-info/resources-table-for-project/project-type/project-type.component */ "./src/app/modules/main/pages/project/project-info/resources-table-for-project/project-type/project-type.component.ts");
/* harmony import */ var _modules_main_pages_project_project_request_project_request_component__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ./modules/main/pages/project/project-request/project-request.component */ "./src/app/modules/main/pages/project/project-request/project-request.component.ts");
/* harmony import */ var _modules_login_login_component__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! ./modules/login/login.component */ "./src/app/modules/login/login.component.ts");
/* harmony import */ var _shared_components_error_error_component__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! ./shared/components/error/error.component */ "./src/app/shared/components/error/error.component.ts");
/* harmony import */ var _modules_cms_generic_cms_module__WEBPACK_IMPORTED_MODULE_15__ = __webpack_require__(/*! ./modules/cms-generic/cms.module */ "./src/app/modules/cms-generic/cms.module.ts");
/* harmony import */ var _modules_main_pages_resource_general_resources_component__WEBPACK_IMPORTED_MODULE_16__ = __webpack_require__(/*! ./modules/main/pages/resource/general-resources.component */ "./src/app/modules/main/pages/resource/general-resources.component.ts");
/* harmony import */ var _modules_manager_manager_component__WEBPACK_IMPORTED_MODULE_17__ = __webpack_require__(/*! ./modules/manager/manager.component */ "./src/app/modules/manager/manager.component.ts");
/* harmony import */ var _modules_manager_page_manager_page_manager_component__WEBPACK_IMPORTED_MODULE_18__ = __webpack_require__(/*! ./modules/manager/page-manager/page-manager.component */ "./src/app/modules/manager/page-manager/page-manager.component.ts");
/* harmony import */ var _modules_manager_page_manager_create_page_create_page_component__WEBPACK_IMPORTED_MODULE_19__ = __webpack_require__(/*! ./modules/manager/page-manager/create-page/create-page.component */ "./src/app/modules/manager/page-manager/create-page/create-page.component.ts");
/* harmony import */ var _shared_guards_auth_guard_service__WEBPACK_IMPORTED_MODULE_20__ = __webpack_require__(/*! ./shared/guards/auth-guard.service */ "./src/app/shared/guards/auth-guard.service.ts");





















const routes = [
    { path: "", component: _modules_main_main_component__WEBPACK_IMPORTED_MODULE_4__["MainComponent"], children: [
            { path: "", component: _modules_main_pages_home_home_component__WEBPACK_IMPORTED_MODULE_5__["HomeComponent"] },
            { path: "participants", component: _modules_main_pages_project_project_participants_project_participants_component__WEBPACK_IMPORTED_MODULE_6__["ProjectParticipantsComponent"], canActivate: [_shared_guards_auth_guard_service__WEBPACK_IMPORTED_MODULE_20__["AuthGuard"]] },
            { path: "projects/:id", component: _modules_main_pages_project_project_info_project_info_component__WEBPACK_IMPORTED_MODULE_7__["ProjectInfoComponent"], canActivate: [_shared_guards_auth_guard_service__WEBPACK_IMPORTED_MODULE_20__["AuthGuard"]] },
            { path: "projects", component: _modules_main_pages_project_project_component__WEBPACK_IMPORTED_MODULE_3__["ProjectComponent"] },
            { path: "donations/:projectId", component: _modules_main_pages_donation_donation_component__WEBPACK_IMPORTED_MODULE_8__["DonationComponent"] },
            { path: "donations", component: _modules_main_pages_donation_donation_component__WEBPACK_IMPORTED_MODULE_8__["DonationComponent"] },
            { path: "resources", component: _modules_main_pages_resource_general_resources_tables_general_resources_table_general_resources_table_component__WEBPACK_IMPORTED_MODULE_9__["GeneralResourcesTableComponent"], canActivate: [_shared_guards_auth_guard_service__WEBPACK_IMPORTED_MODULE_20__["AuthGuard"]] },
            { path: "transaction/:donationId", component: _shared_components_transaction_result_transaction_result_component__WEBPACK_IMPORTED_MODULE_10__["TransactionResultComponent"] },
            { path: "projectTypes", component: _modules_main_pages_project_project_info_resources_table_for_project_project_type_project_type_component__WEBPACK_IMPORTED_MODULE_11__["ProjectTypeComponent"] },
            { path: "projectRequest", component: _modules_main_pages_project_project_request_project_request_component__WEBPACK_IMPORTED_MODULE_12__["ProjectRequestComponent"] },
        ] },
    { path: "login", component: _modules_login_login_component__WEBPACK_IMPORTED_MODULE_13__["LoginComponent"] },
    { path: "error", component: _shared_components_error_error_component__WEBPACK_IMPORTED_MODULE_14__["ErrorComponent"] },
    { path: "manager", component: _modules_manager_manager_component__WEBPACK_IMPORTED_MODULE_17__["ManagerComponent"], children: [
            {
                path: "pages", component: _modules_manager_page_manager_page_manager_component__WEBPACK_IMPORTED_MODULE_18__["PageManagerComponent"], children: [
                    { path: "create", component: _modules_manager_page_manager_create_page_create_page_component__WEBPACK_IMPORTED_MODULE_19__["CreatePageComponent"] }
                ]
            }
        ] },
    { path: "**", loadChildren: () => _modules_cms_generic_cms_module__WEBPACK_IMPORTED_MODULE_15__["CmsModule"] }
];
let AppRoutingModule = class AppRoutingModule {
};
AppRoutingModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        imports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"].forRoot(routes, {
                onSameUrlNavigation: 'reload',
            })],
        exports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"]]
    })
], AppRoutingModule);

const routingComponents = [
    _modules_main_pages_project_project_participants_project_participants_component__WEBPACK_IMPORTED_MODULE_6__["ProjectParticipantsComponent"],
    _modules_main_pages_project_project_component__WEBPACK_IMPORTED_MODULE_3__["ProjectComponent"],
    _modules_main_pages_home_home_component__WEBPACK_IMPORTED_MODULE_5__["HomeComponent"],
    _modules_main_pages_project_project_info_project_info_component__WEBPACK_IMPORTED_MODULE_7__["ProjectInfoComponent"],
    _modules_main_pages_resource_general_resources_component__WEBPACK_IMPORTED_MODULE_16__["GeneralResourcesComponent"],
    _shared_components_error_error_component__WEBPACK_IMPORTED_MODULE_14__["ErrorComponent"],
    _modules_main_pages_project_project_info_resources_table_for_project_project_type_project_type_component__WEBPACK_IMPORTED_MODULE_11__["ProjectTypeComponent"],
    _shared_components_transaction_result_transaction_result_component__WEBPACK_IMPORTED_MODULE_10__["TransactionResultComponent"],
    _modules_main_pages_donation_donation_component__WEBPACK_IMPORTED_MODULE_8__["DonationComponent"],
    _modules_main_pages_project_project_request_project_request_component__WEBPACK_IMPORTED_MODULE_12__["ProjectRequestComponent"],
    _modules_login_login_component__WEBPACK_IMPORTED_MODULE_13__["LoginComponent"],
    _modules_main_main_component__WEBPACK_IMPORTED_MODULE_4__["MainComponent"]
];


/***/ }),

/***/ "./src/app/app.component.less":
/*!************************************!*\
  !*** ./src/app/app.component.less ***!
  \************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2FwcC5jb21wb25lbnQubGVzcyJ9 */");

/***/ }),

/***/ "./src/app/app.component.ts":
/*!**********************************!*\
  !*** ./src/app/app.component.ts ***!
  \**********************************/
/*! exports provided: AppComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppComponent", function() { return AppComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _ngx_translate_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @ngx-translate/core */ "./node_modules/@ngx-translate/core/fesm2015/ngx-translate-core.js");



let AppComponent = class AppComponent {
    constructor(translate) {
        this.title = "UTTMM";
        // this language will be used as a fallback when a translation isn't found in the current language
        translate.setDefaultLang("ua");
        // the lang to use, if the lang isn't available, it will use the current loader to get them
        translate.use("ua");
    }
};
AppComponent.ctorParameters = () => [
    { type: _ngx_translate_core__WEBPACK_IMPORTED_MODULE_2__["TranslateService"] }
];
AppComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: "app-root",
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./app.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/app.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./app.component.less */ "./src/app/app.component.less")).default]
    })
], AppComponent);



/***/ }),

/***/ "./src/app/app.module.ts":
/*!*******************************!*\
  !*** ./src/app/app.module.ts ***!
  \*******************************/
/*! exports provided: tokenGetter, HttpLoaderFactory, AppModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "tokenGetter", function() { return tokenGetter; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "HttpLoaderFactory", function() { return HttpLoaderFactory; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppModule", function() { return AppModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser */ "./node_modules/@angular/platform-browser/fesm2015/platform-browser.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_flex_layout__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/flex-layout */ "./node_modules/@angular/flex-layout/esm2015/flex-layout.js");
/* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm2015/material.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
/* harmony import */ var _app_routing_module__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./app-routing.module */ "./src/app/app-routing.module.ts");
/* harmony import */ var _app_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./app.component */ "./src/app/app.component.ts");
/* harmony import */ var _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! @angular/platform-browser/animations */ "./node_modules/@angular/platform-browser/fesm2015/animations.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm2015/forms.js");
/* harmony import */ var _angular_material_form_field__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! @angular/material/form-field */ "./node_modules/@angular/material/esm2015/form-field.js");
/* harmony import */ var _angular_material_table__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! @angular/material/table */ "./node_modules/@angular/material/esm2015/table.js");
/* harmony import */ var _angular_material_tabs__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! @angular/material/tabs */ "./node_modules/@angular/material/esm2015/tabs.js");
/* harmony import */ var _angular_material_card__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! @angular/material/card */ "./node_modules/@angular/material/esm2015/card.js");
/* harmony import */ var _angular_material_grid_list__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! @angular/material/grid-list */ "./node_modules/@angular/material/esm2015/grid-list.js");
/* harmony import */ var _angular_material_paginator__WEBPACK_IMPORTED_MODULE_15__ = __webpack_require__(/*! @angular/material/paginator */ "./node_modules/@angular/material/esm2015/paginator.js");
/* harmony import */ var _angular_cdk_portal__WEBPACK_IMPORTED_MODULE_16__ = __webpack_require__(/*! @angular/cdk/portal */ "./node_modules/@angular/cdk/esm2015/portal.js");
/* harmony import */ var _angular_cdk_a11y__WEBPACK_IMPORTED_MODULE_17__ = __webpack_require__(/*! @angular/cdk/a11y */ "./node_modules/@angular/cdk/esm2015/a11y.js");
/* harmony import */ var _angular_cdk_stepper__WEBPACK_IMPORTED_MODULE_18__ = __webpack_require__(/*! @angular/cdk/stepper */ "./node_modules/@angular/cdk/esm2015/stepper.js");
/* harmony import */ var _angular_cdk_table__WEBPACK_IMPORTED_MODULE_19__ = __webpack_require__(/*! @angular/cdk/table */ "./node_modules/@angular/cdk/esm2015/table.js");
/* harmony import */ var _angular_cdk_tree__WEBPACK_IMPORTED_MODULE_20__ = __webpack_require__(/*! @angular/cdk/tree */ "./node_modules/@angular/cdk/esm2015/tree.js");
/* harmony import */ var _angular_cdk_scrolling__WEBPACK_IMPORTED_MODULE_21__ = __webpack_require__(/*! @angular/cdk/scrolling */ "./node_modules/@angular/cdk/esm2015/scrolling.js");
/* harmony import */ var _angular_cdk_drag_drop__WEBPACK_IMPORTED_MODULE_22__ = __webpack_require__(/*! @angular/cdk/drag-drop */ "./node_modules/@angular/cdk/esm2015/drag-drop.js");
/* harmony import */ var _shared_components_confirm_dialog_confirm_dialog_component__WEBPACK_IMPORTED_MODULE_23__ = __webpack_require__(/*! ./shared/components/confirm-dialog/confirm-dialog.component */ "./src/app/shared/components/confirm-dialog/confirm-dialog.component.ts");
/* harmony import */ var _shared_components_error_error_component__WEBPACK_IMPORTED_MODULE_24__ = __webpack_require__(/*! ./shared/components/error/error.component */ "./src/app/shared/components/error/error.component.ts");
/* harmony import */ var _ngx_translate_core__WEBPACK_IMPORTED_MODULE_25__ = __webpack_require__(/*! @ngx-translate/core */ "./node_modules/@ngx-translate/core/fesm2015/ngx-translate-core.js");
/* harmony import */ var _ngx_translate_http_loader__WEBPACK_IMPORTED_MODULE_26__ = __webpack_require__(/*! @ngx-translate/http-loader */ "./node_modules/@ngx-translate/http-loader/fesm2015/ngx-translate-http-loader.js");
/* harmony import */ var _core_toolbar_toolbar_component__WEBPACK_IMPORTED_MODULE_27__ = __webpack_require__(/*! ./core/toolbar/toolbar.component */ "./src/app/core/toolbar/toolbar.component.ts");
/* harmony import */ var _core_toolbar_language_language_component__WEBPACK_IMPORTED_MODULE_28__ = __webpack_require__(/*! ./core/toolbar/language/language.component */ "./src/app/core/toolbar/language/language.component.ts");
/* harmony import */ var _core_http_resource_resource_service__WEBPACK_IMPORTED_MODULE_29__ = __webpack_require__(/*! ./core/http/resource/resource.service */ "./src/app/core/http/resource/resource.service.ts");
/* harmony import */ var _core_http_http_http_service__WEBPACK_IMPORTED_MODULE_30__ = __webpack_require__(/*! ./core/http/http/http.service */ "./src/app/core/http/http/http.service.ts");
/* harmony import */ var _core_services_event_event_service__WEBPACK_IMPORTED_MODULE_31__ = __webpack_require__(/*! ./core/services/event/event-service */ "./src/app/core/services/event/event-service.ts");
/* harmony import */ var _core_services_notification_notification_service__WEBPACK_IMPORTED_MODULE_32__ = __webpack_require__(/*! ./core/services/notification/notification.service */ "./src/app/core/services/notification/notification.service.ts");
/* harmony import */ var _core_services_dialog_dialog_service__WEBPACK_IMPORTED_MODULE_33__ = __webpack_require__(/*! ./core/services/dialog/dialog.service */ "./src/app/core/services/dialog/dialog.service.ts");
/* harmony import */ var _core_services_resource_resource_categories_service__WEBPACK_IMPORTED_MODULE_34__ = __webpack_require__(/*! ./core/services/resource/resource-categories.service */ "./src/app/core/services/resource/resource-categories.service.ts");
/* harmony import */ var _core_http_project_participants_project_participation_service__WEBPACK_IMPORTED_MODULE_35__ = __webpack_require__(/*! ./core/http/project-participants/project-participation.service */ "./src/app/core/http/project-participants/project-participation.service.ts");
/* harmony import */ var _core_services_project_type_project_type_service__WEBPACK_IMPORTED_MODULE_36__ = __webpack_require__(/*! ./core/services/project-type/project-type.service */ "./src/app/core/services/project-type/project-type.service.ts");
/* harmony import */ var _core_http_donations_donation_service__WEBPACK_IMPORTED_MODULE_37__ = __webpack_require__(/*! ./core/http/donations/donation.service */ "./src/app/core/http/donations/donation.service.ts");
/* harmony import */ var _core_http_project_http_project_service__WEBPACK_IMPORTED_MODULE_38__ = __webpack_require__(/*! ./core/http/project/http-project.service */ "./src/app/core/http/project/http-project.service.ts");
/* harmony import */ var _core_auth_user_service__WEBPACK_IMPORTED_MODULE_39__ = __webpack_require__(/*! ./core/auth/user.service */ "./src/app/core/auth/user.service.ts");
/* harmony import */ var _core_http_resource_resource_create_service__WEBPACK_IMPORTED_MODULE_40__ = __webpack_require__(/*! ./core/http/resource/resource-create.service */ "./src/app/core/http/resource/resource-create.service.ts");
/* harmony import */ var _core_http_project_type_project_type_Http_service__WEBPACK_IMPORTED_MODULE_41__ = __webpack_require__(/*! ./core/http/project-type/project-type-Http.service */ "./src/app/core/http/project-type/project-type-Http.service.ts");
/* harmony import */ var _modules_cms_generic_cms_module__WEBPACK_IMPORTED_MODULE_42__ = __webpack_require__(/*! ./modules/cms-generic/cms.module */ "./src/app/modules/cms-generic/cms.module.ts");
/* harmony import */ var _core_toolbar_cms_pages_toolbar_item_cms_pages_toolbar_item_component__WEBPACK_IMPORTED_MODULE_43__ = __webpack_require__(/*! ./core/toolbar/cms-pages-toolbar-item/cms-pages-toolbar-item.component */ "./src/app/core/toolbar/cms-pages-toolbar-item/cms-pages-toolbar-item.component.ts");
/* harmony import */ var _modules_main_pages_project_project_component__WEBPACK_IMPORTED_MODULE_44__ = __webpack_require__(/*! ./modules/main/pages/project/project.component */ "./src/app/modules/main/pages/project/project.component.ts");
/* harmony import */ var _modules_main_pages_home_home_component__WEBPACK_IMPORTED_MODULE_45__ = __webpack_require__(/*! ./modules/main/pages/home/home.component */ "./src/app/modules/main/pages/home/home.component.ts");
/* harmony import */ var _modules_main_pages_project_project_info_project_info_component__WEBPACK_IMPORTED_MODULE_46__ = __webpack_require__(/*! ./modules/main/pages/project/project-info/project-info.component */ "./src/app/modules/main/pages/project/project-info/project-info.component.ts");
/* harmony import */ var _core_footer_footer_component__WEBPACK_IMPORTED_MODULE_47__ = __webpack_require__(/*! ./core/footer/footer.component */ "./src/app/core/footer/footer.component.ts");
/* harmony import */ var _modules_main_pages_project_project_participants_project_participants_component__WEBPACK_IMPORTED_MODULE_48__ = __webpack_require__(/*! ./modules/main/pages/project/project-participants/project-participants.component */ "./src/app/modules/main/pages/project/project-participants/project-participants.component.ts");
/* harmony import */ var _shared_pipes_custom_datepipe__WEBPACK_IMPORTED_MODULE_49__ = __webpack_require__(/*! ./shared/pipes/custom.datepipe */ "./src/app/shared/pipes/custom.datepipe.ts");
/* harmony import */ var _modules_main_pages_project_project_info_resources_table_for_project_resources_table_resources_table_component__WEBPACK_IMPORTED_MODULE_50__ = __webpack_require__(/*! ./modules/main/pages/project/project-info/resources-table-for-project/resources-table/resources-table.component */ "./src/app/modules/main/pages/project/project-info/resources-table-for-project/resources-table/resources-table.component.ts");
/* harmony import */ var _modules_main_pages_project_project_form_project_form_component__WEBPACK_IMPORTED_MODULE_51__ = __webpack_require__(/*! ./modules/main/pages/project/project-form/project-form.component */ "./src/app/modules/main/pages/project/project-form/project-form.component.ts");
/* harmony import */ var _modules_main_pages_project_project_info_resources_table_for_project_resources_internal_table_resources_internal_table_component__WEBPACK_IMPORTED_MODULE_52__ = __webpack_require__(/*! ./modules/main/pages/project/project-info/resources-table-for-project/resources-internal-table/resources-internal-table.component */ "./src/app/modules/main/pages/project/project-info/resources-table-for-project/resources-internal-table/resources-internal-table.component.ts");
/* harmony import */ var _modules_main_pages_resource_general_resources_tables_general_resources_table_general_resources_table_component__WEBPACK_IMPORTED_MODULE_53__ = __webpack_require__(/*! ./modules/main/pages/resource/general-resources-tables/general-resources-table/general-resources-table.component */ "./src/app/modules/main/pages/resource/general-resources-tables/general-resources-table/general-resources-table.component.ts");
/* harmony import */ var _modules_main_pages_resource_general_resources_tables_general_resources_inner_table_general_resources_inner_table_component__WEBPACK_IMPORTED_MODULE_54__ = __webpack_require__(/*! ./modules/main/pages/resource/general-resources-tables/general-resources-inner-table/general-resources-inner-table.component */ "./src/app/modules/main/pages/resource/general-resources-tables/general-resources-inner-table/general-resources-inner-table.component.ts");
/* harmony import */ var _core_toolbar_toolbar_item_toolbar_item_component__WEBPACK_IMPORTED_MODULE_55__ = __webpack_require__(/*! ./core/toolbar/toolbar-item/toolbar-item.component */ "./src/app/core/toolbar/toolbar-item/toolbar-item.component.ts");
/* harmony import */ var _modules_main_pages_donation_donation_component__WEBPACK_IMPORTED_MODULE_56__ = __webpack_require__(/*! ./modules/main/pages/donation/donation.component */ "./src/app/modules/main/pages/donation/donation.component.ts");
/* harmony import */ var _shared_components_transaction_result_transaction_result_component__WEBPACK_IMPORTED_MODULE_57__ = __webpack_require__(/*! ./shared/components/transaction-result/transaction-result.component */ "./src/app/shared/components/transaction-result/transaction-result.component.ts");
/* harmony import */ var _modules_main_pages_project_project_request_project_request_component__WEBPACK_IMPORTED_MODULE_58__ = __webpack_require__(/*! ./modules/main/pages/project/project-request/project-request.component */ "./src/app/modules/main/pages/project/project-request/project-request.component.ts");
/* harmony import */ var _modules_login_login_component__WEBPACK_IMPORTED_MODULE_59__ = __webpack_require__(/*! ./modules/login/login.component */ "./src/app/modules/login/login.component.ts");
/* harmony import */ var _core_toolbar_profile_menu_profile_menu_component__WEBPACK_IMPORTED_MODULE_60__ = __webpack_require__(/*! ./core/toolbar/profile-menu/profile-menu.component */ "./src/app/core/toolbar/profile-menu/profile-menu.component.ts");
/* harmony import */ var _modules_main_pages_resource_resource_create_resource_create_component__WEBPACK_IMPORTED_MODULE_61__ = __webpack_require__(/*! ./modules/main/pages/resource/resource-create/resource-create.component */ "./src/app/modules/main/pages/resource/resource-create/resource-create.component.ts");
/* harmony import */ var _modules_main_pages_project_project_type_form_project_type_form_component__WEBPACK_IMPORTED_MODULE_62__ = __webpack_require__(/*! ./modules/main/pages/project/project-type-form/project-type-form.component */ "./src/app/modules/main/pages/project/project-type-form/project-type-form.component.ts");
/* harmony import */ var _modules_main_pages_project_project_type_create_form_project_type_create_form_component__WEBPACK_IMPORTED_MODULE_63__ = __webpack_require__(/*! ./modules/main/pages/project/project-type-create-form/project-type-create-form.component */ "./src/app/modules/main/pages/project/project-type-create-form/project-type-create-form.component.ts");
/* harmony import */ var _modules_main_main_component__WEBPACK_IMPORTED_MODULE_64__ = __webpack_require__(/*! ./modules/main/main.component */ "./src/app/modules/main/main.component.ts");
/* harmony import */ var ngx_material_file_input__WEBPACK_IMPORTED_MODULE_65__ = __webpack_require__(/*! ngx-material-file-input */ "./node_modules/ngx-material-file-input/fesm2015/ngx-material-file-input.js");
/* harmony import */ var _auth0_angular_jwt__WEBPACK_IMPORTED_MODULE_66__ = __webpack_require__(/*! @auth0/angular-jwt */ "./node_modules/@auth0/angular-jwt/index.js");
/* harmony import */ var _shared_guards_auth_guard_service__WEBPACK_IMPORTED_MODULE_67__ = __webpack_require__(/*! ./shared/guards/auth-guard.service */ "./src/app/shared/guards/auth-guard.service.ts");
/* harmony import */ var _modules_main_pages_project_days_left_pipe__WEBPACK_IMPORTED_MODULE_68__ = __webpack_require__(/*! ./modules/main/pages/project/days-left.pipe */ "./src/app/modules/main/pages/project/days-left.pipe.ts");
/* harmony import */ var _modules_manager_manager_component__WEBPACK_IMPORTED_MODULE_69__ = __webpack_require__(/*! ./modules/manager/manager.component */ "./src/app/modules/manager/manager.component.ts");
/* harmony import */ var _modules_manager_page_manager_page_manager_component__WEBPACK_IMPORTED_MODULE_70__ = __webpack_require__(/*! ./modules/manager/page-manager/page-manager.component */ "./src/app/modules/manager/page-manager/page-manager.component.ts");
/* harmony import */ var _modules_manager_page_manager_create_page_create_page_component__WEBPACK_IMPORTED_MODULE_71__ = __webpack_require__(/*! ./modules/manager/page-manager/create-page/create-page.component */ "./src/app/modules/manager/page-manager/create-page/create-page.component.ts");
/* harmony import */ var ngx_quill__WEBPACK_IMPORTED_MODULE_72__ = __webpack_require__(/*! ngx-quill */ "./node_modules/ngx-quill/fesm2015/ngx-quill.js");










































































function tokenGetter() {
    return localStorage.getItem("jwt");
}
function HttpLoaderFactory(http) {
    return new _ngx_translate_http_loader__WEBPACK_IMPORTED_MODULE_26__["TranslateHttpLoader"](http);
}
let AppModule = class AppModule {
};
AppModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["NgModule"])({
        declarations: [
            _app_component__WEBPACK_IMPORTED_MODULE_7__["AppComponent"],
            _app_routing_module__WEBPACK_IMPORTED_MODULE_6__["routingComponents"],
            _core_toolbar_toolbar_component__WEBPACK_IMPORTED_MODULE_27__["ToolbarComponent"],
            _modules_main_pages_project_project_component__WEBPACK_IMPORTED_MODULE_44__["ProjectComponent"],
            _modules_main_pages_home_home_component__WEBPACK_IMPORTED_MODULE_45__["HomeComponent"],
            _modules_main_pages_project_project_info_project_info_component__WEBPACK_IMPORTED_MODULE_46__["ProjectInfoComponent"],
            _core_footer_footer_component__WEBPACK_IMPORTED_MODULE_47__["FooterComponent"],
            _modules_main_pages_project_project_participants_project_participants_component__WEBPACK_IMPORTED_MODULE_48__["ProjectParticipantsComponent"],
            _shared_pipes_custom_datepipe__WEBPACK_IMPORTED_MODULE_49__["CustomDatePipe"],
            _modules_main_pages_project_project_info_resources_table_for_project_resources_table_resources_table_component__WEBPACK_IMPORTED_MODULE_50__["ResourcesTableComponent"],
            _shared_components_confirm_dialog_confirm_dialog_component__WEBPACK_IMPORTED_MODULE_23__["ConfirmDialogComponent"],
            _shared_components_error_error_component__WEBPACK_IMPORTED_MODULE_24__["ErrorComponent"],
            _modules_main_pages_project_project_form_project_form_component__WEBPACK_IMPORTED_MODULE_51__["ProjectFormComponent"],
            _modules_main_pages_project_project_info_resources_table_for_project_resources_internal_table_resources_internal_table_component__WEBPACK_IMPORTED_MODULE_52__["ResourcesInternalTableComponent"],
            _modules_main_pages_resource_general_resources_tables_general_resources_table_general_resources_table_component__WEBPACK_IMPORTED_MODULE_53__["GeneralResourcesTableComponent"],
            _modules_main_pages_resource_general_resources_tables_general_resources_inner_table_general_resources_inner_table_component__WEBPACK_IMPORTED_MODULE_54__["GeneralResourcesInnerTableComponent"],
            _core_toolbar_toolbar_item_toolbar_item_component__WEBPACK_IMPORTED_MODULE_55__["ToolbarItemComponent"],
            _modules_main_pages_donation_donation_component__WEBPACK_IMPORTED_MODULE_56__["DonationComponent"],
            _shared_components_transaction_result_transaction_result_component__WEBPACK_IMPORTED_MODULE_57__["TransactionResultComponent"],
            _modules_main_pages_project_project_request_project_request_component__WEBPACK_IMPORTED_MODULE_58__["ProjectRequestComponent"],
            _modules_login_login_component__WEBPACK_IMPORTED_MODULE_59__["LoginComponent"],
            _core_toolbar_profile_menu_profile_menu_component__WEBPACK_IMPORTED_MODULE_60__["ProfileMenuComponent"],
            _modules_main_pages_resource_resource_create_resource_create_component__WEBPACK_IMPORTED_MODULE_61__["ResourceCreateComponent"],
            _modules_main_pages_project_project_type_form_project_type_form_component__WEBPACK_IMPORTED_MODULE_62__["ProjectTypeFormComponent"],
            _modules_main_pages_project_project_type_create_form_project_type_create_form_component__WEBPACK_IMPORTED_MODULE_63__["ProjectTypeCreateFormComponent"],
            _core_toolbar_language_language_component__WEBPACK_IMPORTED_MODULE_28__["LanguageComponent"],
            _modules_main_main_component__WEBPACK_IMPORTED_MODULE_64__["MainComponent"],
            _core_toolbar_cms_pages_toolbar_item_cms_pages_toolbar_item_component__WEBPACK_IMPORTED_MODULE_43__["CmsPagesToolbarItemComponent"],
            _modules_main_pages_project_days_left_pipe__WEBPACK_IMPORTED_MODULE_68__["DaysLeftPipe"],
            _modules_manager_manager_component__WEBPACK_IMPORTED_MODULE_69__["ManagerComponent"],
            _modules_manager_page_manager_page_manager_component__WEBPACK_IMPORTED_MODULE_70__["PageManagerComponent"],
            _modules_manager_page_manager_create_page_create_page_component__WEBPACK_IMPORTED_MODULE_71__["CreatePageComponent"]
        ],
        entryComponents: [
            _modules_main_pages_project_project_info_resources_table_for_project_resources_internal_table_resources_internal_table_component__WEBPACK_IMPORTED_MODULE_52__["ResourcesInternalTableComponent"],
            _modules_main_pages_project_project_form_project_form_component__WEBPACK_IMPORTED_MODULE_51__["ProjectFormComponent"],
            _shared_components_confirm_dialog_confirm_dialog_component__WEBPACK_IMPORTED_MODULE_23__["ConfirmDialogComponent"],
            _modules_login_login_component__WEBPACK_IMPORTED_MODULE_59__["LoginComponent"],
            _modules_main_pages_resource_resource_create_resource_create_component__WEBPACK_IMPORTED_MODULE_61__["ResourceCreateComponent"],
            _modules_main_pages_project_project_type_form_project_type_form_component__WEBPACK_IMPORTED_MODULE_62__["ProjectTypeFormComponent"],
            _modules_main_pages_project_project_type_create_form_project_type_create_form_component__WEBPACK_IMPORTED_MODULE_63__["ProjectTypeCreateFormComponent"]
        ],
        imports: [
            _angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__["BrowserModule"],
            _app_routing_module__WEBPACK_IMPORTED_MODULE_6__["AppRoutingModule"],
            _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_8__["BrowserAnimationsModule"],
            _angular_flex_layout__WEBPACK_IMPORTED_MODULE_3__["FlexLayoutModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatToolbarModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatButtonModule"],
            _angular_common_http__WEBPACK_IMPORTED_MODULE_5__["HttpClientModule"],
            _angular_material_card__WEBPACK_IMPORTED_MODULE_13__["MatCardModule"],
            _angular_forms__WEBPACK_IMPORTED_MODULE_9__["FormsModule"],
            _angular_forms__WEBPACK_IMPORTED_MODULE_9__["ReactiveFormsModule"],
            _angular_material_grid_list__WEBPACK_IMPORTED_MODULE_14__["MatGridListModule"],
            _angular_material_form_field__WEBPACK_IMPORTED_MODULE_10__["MatFormFieldModule"],
            _angular_material_tabs__WEBPACK_IMPORTED_MODULE_12__["MatTabsModule"],
            _angular_material_table__WEBPACK_IMPORTED_MODULE_11__["MatTableModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatProgressSpinnerModule"],
            _angular_material_paginator__WEBPACK_IMPORTED_MODULE_15__["MatPaginatorModule"],
            _angular_cdk_a11y__WEBPACK_IMPORTED_MODULE_17__["A11yModule"],
            _angular_cdk_stepper__WEBPACK_IMPORTED_MODULE_18__["CdkStepperModule"],
            _angular_cdk_table__WEBPACK_IMPORTED_MODULE_19__["CdkTableModule"],
            _angular_cdk_tree__WEBPACK_IMPORTED_MODULE_20__["CdkTreeModule"],
            _angular_cdk_drag_drop__WEBPACK_IMPORTED_MODULE_22__["DragDropModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatAutocompleteModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatBadgeModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatBottomSheetModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatButtonModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatButtonToggleModule"],
            _angular_material_card__WEBPACK_IMPORTED_MODULE_13__["MatCardModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatCheckboxModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatChipsModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatStepperModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatDatepickerModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatDialogModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatDividerModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatExpansionModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatIconModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatInputModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatListModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatMenuModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatNativeDateModule"],
            _angular_material_paginator__WEBPACK_IMPORTED_MODULE_15__["MatPaginatorModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatProgressBarModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatProgressSpinnerModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatRadioModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatRippleModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatSelectModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatSidenavModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatSliderModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatSlideToggleModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatSnackBarModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatSortModule"],
            _angular_material_table__WEBPACK_IMPORTED_MODULE_11__["MatTableModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatToolbarModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatTooltipModule"],
            _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatTreeModule"],
            _angular_cdk_portal__WEBPACK_IMPORTED_MODULE_16__["PortalModule"],
            _angular_cdk_scrolling__WEBPACK_IMPORTED_MODULE_21__["ScrollingModule"],
            _modules_cms_generic_cms_module__WEBPACK_IMPORTED_MODULE_42__["CmsModule"],
            ngx_quill__WEBPACK_IMPORTED_MODULE_72__["QuillModule"].forRoot(),
            _ngx_translate_core__WEBPACK_IMPORTED_MODULE_25__["TranslateModule"].forRoot({
                loader: {
                    provide: _ngx_translate_core__WEBPACK_IMPORTED_MODULE_25__["TranslateLoader"],
                    useFactory: HttpLoaderFactory,
                    deps: [_angular_common_http__WEBPACK_IMPORTED_MODULE_5__["HttpClient"]]
                }
            }),
            ngx_material_file_input__WEBPACK_IMPORTED_MODULE_65__["MaterialFileInputModule"],
            _auth0_angular_jwt__WEBPACK_IMPORTED_MODULE_66__["JwtModule"].forRoot({
                config: {
                    tokenGetter: tokenGetter,
                    whitelistedDomains: ["localhost:5000"],
                    blacklistedRoutes: []
                }
            })
        ],
        exports: [
            _modules_main_pages_project_project_info_resources_table_for_project_resources_internal_table_resources_internal_table_component__WEBPACK_IMPORTED_MODULE_52__["ResourcesInternalTableComponent"],
            ngx_quill__WEBPACK_IMPORTED_MODULE_72__["QuillModule"]
        ],
        providers: [
            _core_http_resource_resource_service__WEBPACK_IMPORTED_MODULE_29__["ResourceService"],
            _core_http_http_http_service__WEBPACK_IMPORTED_MODULE_30__["HttpService"],
            _core_services_event_event_service__WEBPACK_IMPORTED_MODULE_31__["EventService"],
            // {provide: ErrorHandler, useClass: ErrorHandlerService},
            _core_services_notification_notification_service__WEBPACK_IMPORTED_MODULE_32__["NotificationService"],
            _core_services_dialog_dialog_service__WEBPACK_IMPORTED_MODULE_33__["DialogService"],
            _core_services_resource_resource_categories_service__WEBPACK_IMPORTED_MODULE_34__["ResourceCategoriesService"],
            _core_http_project_participants_project_participation_service__WEBPACK_IMPORTED_MODULE_35__["ProjectParticipationService"],
            _core_services_project_type_project_type_service__WEBPACK_IMPORTED_MODULE_36__["ProjectTypeService"],
            _core_http_donations_donation_service__WEBPACK_IMPORTED_MODULE_37__["DonationService"],
            _core_http_project_http_project_service__WEBPACK_IMPORTED_MODULE_38__["HttpProjectService"],
            _core_auth_user_service__WEBPACK_IMPORTED_MODULE_39__["UserService"],
            _core_http_resource_resource_create_service__WEBPACK_IMPORTED_MODULE_40__["ResourceCreateService"],
            _core_http_project_type_project_type_Http_service__WEBPACK_IMPORTED_MODULE_41__["ProjectTypeHttp"],
            _shared_guards_auth_guard_service__WEBPACK_IMPORTED_MODULE_67__["AuthGuard"]
        ],
        bootstrap: [_app_component__WEBPACK_IMPORTED_MODULE_7__["AppComponent"]]
    })
], AppModule);



/***/ }),

/***/ "./src/app/configs/api-endpoint.constants.ts":
/*!***************************************************!*\
  !*** ./src/app/configs/api-endpoint.constants.ts ***!
  \***************************************************/
/*! exports provided: liqpayCheckoutUrl, baseUrl, projectUrl, resourceUrl, requestUrl, categoryUrl, participationUrl, donationUrl, projectTypeUrl, cmsSitemapUrl, statusApproveUrl, statusRejectUrl, accountUrl */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "liqpayCheckoutUrl", function() { return liqpayCheckoutUrl; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "baseUrl", function() { return baseUrl; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "projectUrl", function() { return projectUrl; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "resourceUrl", function() { return resourceUrl; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "requestUrl", function() { return requestUrl; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "categoryUrl", function() { return categoryUrl; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "participationUrl", function() { return participationUrl; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "donationUrl", function() { return donationUrl; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "projectTypeUrl", function() { return projectTypeUrl; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "cmsSitemapUrl", function() { return cmsSitemapUrl; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "statusApproveUrl", function() { return statusApproveUrl; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "statusRejectUrl", function() { return statusRejectUrl; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "accountUrl", function() { return accountUrl; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");

const liqpayCheckoutUrl = "https://www.liqpay.ua/api/3/checkout";
const baseUrl = "/api/";
const projectUrl = baseUrl + "projects";
const resourceUrl = baseUrl + "resources";
const requestUrl = baseUrl + "request";
const categoryUrl = baseUrl + "categories";
const participationUrl = baseUrl + "participants";
const donationUrl = baseUrl + "donations";
const projectTypeUrl = baseUrl + "projectTypes";
const cmsSitemapUrl = baseUrl + "sitemap";
const statusApproveUrl = projectUrl + "approve";
const statusRejectUrl = projectUrl + "reject";
const accountUrl = baseUrl + "account";


/***/ }),

/***/ "./src/app/configs/date-formats.ts":
/*!*****************************************!*\
  !*** ./src/app/configs/date-formats.ts ***!
  \*****************************************/
/*! exports provided: LONG_DATE_STRING */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LONG_DATE_STRING", function() { return LONG_DATE_STRING; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");

const LONG_DATE_STRING = 'y/MM/dd H:mm';


/***/ }),

/***/ "./src/app/configs/project-participation-request-status.ts":
/*!*****************************************************************!*\
  !*** ./src/app/configs/project-participation-request-status.ts ***!
  \*****************************************************************/
/*! exports provided: ProjectParticipationRequestStatus */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectParticipationRequestStatus", function() { return ProjectParticipationRequestStatus; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");

var ProjectParticipationRequestStatus;
(function (ProjectParticipationRequestStatus) {
    ProjectParticipationRequestStatus[ProjectParticipationRequestStatus["New"] = 0] = "New";
    ProjectParticipationRequestStatus[ProjectParticipationRequestStatus["Approved"] = 10] = "Approved";
    ProjectParticipationRequestStatus[ProjectParticipationRequestStatus["Rejected"] = 20] = "Rejected";
})(ProjectParticipationRequestStatus || (ProjectParticipationRequestStatus = {}));


/***/ }),

/***/ "./src/app/configs/project-status-request.ts":
/*!***************************************************!*\
  !*** ./src/app/configs/project-status-request.ts ***!
  \***************************************************/
/*! exports provided: ProjectStatusRequest */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectStatusRequest", function() { return ProjectStatusRequest; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");

var ProjectStatusRequest;
(function (ProjectStatusRequest) {
    ProjectStatusRequest[ProjectStatusRequest["New"] = 0] = "New";
    ProjectStatusRequest[ProjectStatusRequest["Approved"] = 10] = "Approved";
    ProjectStatusRequest[ProjectStatusRequest["Rejected"] = 20] = "Rejected";
})(ProjectStatusRequest || (ProjectStatusRequest = {}));


/***/ }),

/***/ "./src/app/configs/resource.constants.ts":
/*!***********************************************!*\
  !*** ./src/app/configs/resource.constants.ts ***!
  \***********************************************/
/*! exports provided: ForbiddenExts */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ForbiddenExts", function() { return ForbiddenExts; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");

const ForbiddenExts = /(.+)(.cmd|.bat|.exe)$/i;


/***/ }),

/***/ "./src/app/configs/resources-table.ts":
/*!********************************************!*\
  !*** ./src/app/configs/resources-table.ts ***!
  \********************************************/
/*! exports provided: ResourcesTableConstants */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourcesTableConstants", function() { return ResourcesTableConstants; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");

class ResourcesTableConstants {
}
ResourcesTableConstants.PAGE_NUMBER = 1;
ResourcesTableConstants.COLUMNS_PER_PAGE = 10;
ResourcesTableConstants.WITH_ASSIGNED_RESOURCES = true;
ResourcesTableConstants.PAGE_SIZE_OPTIONS = [5, 10, 20];


/***/ }),

/***/ "./src/app/core/auth/user.service.ts":
/*!*******************************************!*\
  !*** ./src/app/core/auth/user.service.ts ***!
  \*******************************************/
/*! exports provided: UserService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "UserService", function() { return UserService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm2015/forms.js");
/* harmony import */ var src_app_configs_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! src/app/configs/api-endpoint.constants */ "./src/app/configs/api-endpoint.constants.ts");
/* harmony import */ var _auth0_angular_jwt__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @auth0/angular-jwt */ "./node_modules/@auth0/angular-jwt/index.js");






let UserService = class UserService {
    constructor(http, fb, jwtHelper) {
        this.http = http;
        this.fb = fb;
        this.jwtHelper = jwtHelper;
        this.loginForm = this.fb.group({
            username: [
                "",
                [_angular_forms__WEBPACK_IMPORTED_MODULE_3__["Validators"].required, _angular_forms__WEBPACK_IMPORTED_MODULE_3__["Validators"].minLength(3), _angular_forms__WEBPACK_IMPORTED_MODULE_3__["Validators"].maxLength(50)]
            ],
            password: [
                "",
                [_angular_forms__WEBPACK_IMPORTED_MODULE_3__["Validators"].required, _angular_forms__WEBPACK_IMPORTED_MODULE_3__["Validators"].minLength(3), _angular_forms__WEBPACK_IMPORTED_MODULE_3__["Validators"].maxLength(50)]
            ]
        });
        this.baseUrl = src_app_configs_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_4__["accountUrl"];
    }
    login(loginData) {
        return this.http.post(this.baseUrl + "/login", loginData);
    }
    logout() {
        localStorage.removeItem("jwt");
    }
    isAuthenticated() {
        let token = localStorage.getItem("jwt");
        if (token && !this.jwtHelper.isTokenExpired(token)) {
            return true;
        }
        else {
            return false;
        }
    }
    getUserName() {
        return this.http.get(this.baseUrl + "/getUserName", {
            responseType: "text"
        });
    }
};
UserService.ctorParameters = () => [
    { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"] },
    { type: _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormBuilder"] },
    { type: _auth0_angular_jwt__WEBPACK_IMPORTED_MODULE_5__["JwtHelperService"] }
];
UserService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
        providedIn: "root"
    })
], UserService);



/***/ }),

/***/ "./src/app/core/footer/footer.component.less":
/*!***************************************************!*\
  !*** ./src/app/core/footer/footer.component.less ***!
  \***************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("footer {\n  width: 100%;\n  box-shadow: 0 -3px 2px 0 rgba(0, 0, 0, 0.2);\n}\n.footerMainBlock {\n  text-align: center;\n  color: gray;\n  padding-bottom: 15px;\n}\n.footerAboutBlock {\n  color: #4A1E5F;\n  padding: 0 10px;\n}\n.logo {\n  height: 80px;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvY29yZS9mb290ZXIvQzovRG9jdW1lbnRzL0dpdEh1Yi93aXRob3V0IFBpcmFuaGEvVGhlcmFMYW5nL1RoZXJhTGFuZy5XZWIvQ2xpZW50QXBwL3NyYy9hcHAvY29yZS9mb290ZXIvZm9vdGVyLmNvbXBvbmVudC5sZXNzIiwic3JjL2FwcC9jb3JlL2Zvb3Rlci9mb290ZXIuY29tcG9uZW50Lmxlc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDSSxXQUFBO0VBQ0EsMkNBQUE7QUNDSjtBREVBO0VBQ0ksa0JBQUE7RUFDQSxXQUFBO0VBQ0Esb0JBQUE7QUNBSjtBREdBO0VBQ0ksY0FBQTtFQUNBLGVBQUE7QUNESjtBRElBO0VBQ0ksWUFBQTtBQ0ZKIiwiZmlsZSI6InNyYy9hcHAvY29yZS9mb290ZXIvZm9vdGVyLmNvbXBvbmVudC5sZXNzIiwic291cmNlc0NvbnRlbnQiOlsiZm9vdGVye1xuICAgIHdpZHRoOiAxMDAlO1xuICAgIGJveC1zaGFkb3c6IDAgLTNweCAycHggMCByZ2JhKDAsIDAsIDAsIDAuMik7XG59XG5cbi5mb290ZXJNYWluQmxvY2sge1xuICAgIHRleHQtYWxpZ246IGNlbnRlcjtcbiAgICBjb2xvcjogZ3JheTtcbiAgICBwYWRkaW5nLWJvdHRvbTogMTVweDtcbn1cblxuLmZvb3RlckFib3V0QmxvY2sge1xuICAgIGNvbG9yOiAjNEExRTVGO1xuICAgIHBhZGRpbmc6IDAgMTBweDtcbn1cblxuLmxvZ28ge1xuICAgIGhlaWdodDogODBweDtcbn0iLCJmb290ZXIge1xuICB3aWR0aDogMTAwJTtcbiAgYm94LXNoYWRvdzogMCAtM3B4IDJweCAwIHJnYmEoMCwgMCwgMCwgMC4yKTtcbn1cbi5mb290ZXJNYWluQmxvY2sge1xuICB0ZXh0LWFsaWduOiBjZW50ZXI7XG4gIGNvbG9yOiBncmF5O1xuICBwYWRkaW5nLWJvdHRvbTogMTVweDtcbn1cbi5mb290ZXJBYm91dEJsb2NrIHtcbiAgY29sb3I6ICM0QTFFNUY7XG4gIHBhZGRpbmc6IDAgMTBweDtcbn1cbi5sb2dvIHtcbiAgaGVpZ2h0OiA4MHB4O1xufVxuIl19 */");

/***/ }),

/***/ "./src/app/core/footer/footer.component.ts":
/*!*************************************************!*\
  !*** ./src/app/core/footer/footer.component.ts ***!
  \*************************************************/
/*! exports provided: FooterComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "FooterComponent", function() { return FooterComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let FooterComponent = class FooterComponent {
    constructor() { }
    ngOnInit() {
    }
};
FooterComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-footer',
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./footer.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/core/footer/footer.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./footer.component.less */ "./src/app/core/footer/footer.component.less")).default]
    })
], FooterComponent);



/***/ }),

/***/ "./src/app/core/http/cms/cms-page.service.ts":
/*!***************************************************!*\
  !*** ./src/app/core/http/cms/cms-page.service.ts ***!
  \***************************************************/
/*! exports provided: CmsPageService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CmsPageService", function() { return CmsPageService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _http_http_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../http/http.service */ "./src/app/core/http/http/http.service.ts");



let CmsPageService = class CmsPageService {
    constructor(http) {
        this.http = http;
    }
    getPiranhaPageById(pageId) {
        return tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            const allData = yield this.http
                .getPiranhaPageById(pageId)
                .toPromise()
                .then((data) => data);
            return allData;
        });
    }
};
CmsPageService.ctorParameters = () => [
    { type: _http_http_service__WEBPACK_IMPORTED_MODULE_2__["HttpService"] }
];
CmsPageService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])()
], CmsPageService);



/***/ }),

/***/ "./src/app/core/http/cms/site-map.service.ts":
/*!***************************************************!*\
  !*** ./src/app/core/http/cms/site-map.service.ts ***!
  \***************************************************/
/*! exports provided: SiteMapService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SiteMapService", function() { return SiteMapService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm2015/index.js");
/* harmony import */ var _toolbar_cms_pages_toolbar_item_toolbar_item__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../../toolbar/cms-pages-toolbar-item/toolbar-item */ "./src/app/core/toolbar/cms-pages-toolbar-item/toolbar-item.ts");
/* harmony import */ var _toolbar_toolbar_item_cms_route__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../../toolbar/toolbar-item/cms-route */ "./src/app/core/toolbar/toolbar-item/cms-route.ts");
/* harmony import */ var src_app_configs_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! src/app/configs/api-endpoint.constants */ "./src/app/configs/api-endpoint.constants.ts");







let SiteMapService = class SiteMapService {
    constructor(http) {
        this.http = http;
        this.siteMap = new rxjs__WEBPACK_IMPORTED_MODULE_3__["Subject"]();
        this.toolbarItems = new rxjs__WEBPACK_IMPORTED_MODULE_3__["Subject"]();
        this.siteMapUpdating = false;
        this.updateToolbarItemsOnSubscription();
        this.updateSiteMap();
    }
    getSiteMap() {
        return this.http.get(src_app_configs_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_6__["cmsSitemapUrl"]);
    }
    updateSiteMap() {
        if (this.siteMapUpdating) {
            return;
        }
        else {
            this.siteMapUpdating = true;
        }
        const subscription = this.getSiteMap().subscribe(next => {
            this.siteMap.next(next);
            this.siteMapUpdating = false;
            subscription.unsubscribe();
        }, error => {
            this.siteMap.error(error);
            this.siteMapUpdating = false;
            subscription.unsubscribe();
        });
    }
    updateToolbarItemsOnSubscription() {
        this.siteMap.subscribe(sitemap => {
            this.toolbarItems.next(this.mapToolbarItems(sitemap));
        }, error => {
            this.toolbarItems.error(error);
        });
    }
    mapToolbarItems(siteMap) {
        return siteMap.map(item => {
            const route = new _toolbar_toolbar_item_cms_route__WEBPACK_IMPORTED_MODULE_5__["CmsRoute"](item.pageTypeName, item.id);
            return new _toolbar_cms_pages_toolbar_item_toolbar_item__WEBPACK_IMPORTED_MODULE_4__["ToolbarItem"](item.permalink, route, item.menuTitle, this.mapToolbarItems(item.items));
        });
    }
};
SiteMapService.ctorParameters = () => [
    { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"] }
];
SiteMapService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
        providedIn: "root"
    })
], SiteMapService);



/***/ }),

/***/ "./src/app/core/http/donations/donation.service.ts":
/*!*********************************************************!*\
  !*** ./src/app/core/http/donations/donation.service.ts ***!
  \*********************************************************/
/*! exports provided: DonationService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "DonationService", function() { return DonationService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
/* harmony import */ var src_app_configs_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! src/app/configs/api-endpoint.constants */ "./src/app/configs/api-endpoint.constants.ts");




let DonationService = class DonationService {
    constructor(http) {
        this.http = http;
    }
    getProjectCheckoutModel(donationAmount, projectId) {
        return this.http.get(`${src_app_configs_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_3__["donationUrl"]}/${donationAmount}/${projectId}`);
    }
    getSocietyCheckoutModel(donationAmount) {
        return this.http.get(`${src_app_configs_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_3__["donationUrl"]}/${donationAmount}`);
    }
    getDonationTransaction(donationId) {
        return this.http.get(`${src_app_configs_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_3__["donationUrl"]}/transaction/${donationId}`);
    }
};
DonationService.ctorParameters = () => [
    { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"] }
];
DonationService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])()
], DonationService);



/***/ }),

/***/ "./src/app/core/http/http/http.service.ts":
/*!************************************************!*\
  !*** ./src/app/core/http/http/http.service.ts ***!
  \************************************************/
/*! exports provided: HttpService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "HttpService", function() { return HttpService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
/* harmony import */ var src_app_configs_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! src/app/configs/api-endpoint.constants */ "./src/app/configs/api-endpoint.constants.ts");




let HttpService = class HttpService {
    constructor(http) {
        this.http = http;
        this.url = src_app_configs_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_3__["baseUrl"];
    }
    getAllProjects() {
        return this.http.get(this.url + "projects");
    }
    getProjectInfo(id) {
        return this.http.get(this.url + "projects" + "/" + id);
    }
    getResourcesByCategoryId(categoryId, pageNumber, recordsPerPage) {
        return this.http.get(this.url +
            "resources/all/" +
            categoryId +
            "/" +
            pageNumber +
            "/" +
            recordsPerPage);
    }
    getResourceCategories(withAssignedResources) {
        return this.http.get(this.url + "resources/categories" + "/" + withAssignedResources);
    }
    getResourcesCountByCategoryId(categoryId) {
        return this.http.get(this.url + "resources/count" + "/" + categoryId);
    }
    getAllResourcesById(projectId) {
        return this.http.get(this.url + "resources/all/" + projectId);
    }
    getPiranhaPageById(pageId) {
        return this.http.get(this.url + "page/" + pageId);
    }
    createProject(project) {
        return this.http.post(this.url + "projects" + "/" + "create", project);
    }
    updateProject(project) {
        return this.http.put(this.url + "/" + project.id, project);
    }
    getAllProjectTypes() {
        return this.http.get(this.url + "projectTypes");
    }
    deleteProject(id) {
        return this.http.delete(this.url + "projects" + "/" + id);
    }
    getAllNewProjects() {
        return this.http.get(this.url + "projects/new");
    }
};
HttpService.ctorParameters = () => [
    { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"] }
];
HttpService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])()
], HttpService);



/***/ }),

/***/ "./src/app/core/http/page/page.service.ts":
/*!************************************************!*\
  !*** ./src/app/core/http/page/page.service.ts ***!
  \************************************************/
/*! exports provided: PageService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PageService", function() { return PageService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");



let PageService = class PageService {
    constructor(http) {
        this.http = http;
    }
};
PageService.ctorParameters = () => [
    { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"] }
];
PageService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({ providedIn: 'root' })
], PageService);



/***/ }),

/***/ "./src/app/core/http/project-participants/project-participation.service.ts":
/*!*********************************************************************************!*\
  !*** ./src/app/core/http/project-participants/project-participation.service.ts ***!
  \*********************************************************************************/
/*! exports provided: ProjectParticipationService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectParticipationService", function() { return ProjectParticipationService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
/* harmony import */ var src_app_configs_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! src/app/configs/api-endpoint.constants */ "./src/app/configs/api-endpoint.constants.ts");




let ProjectParticipationService = class ProjectParticipationService {
    constructor(http) {
        this.http = http;
        this.url = src_app_configs_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_3__["participationUrl"];
    }
    getAllProjectParticipants() {
        return this.http.get(this.url);
    }
    changeParticipationStatus(requestId, requestStatus) {
        return this.http.put(this.url + "/" + requestId, requestStatus);
    }
    createParticipRequest(projectId) {
        return this.http.post(this.url + "/create", projectId);
    }
};
ProjectParticipationService.ctorParameters = () => [
    { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"] }
];
ProjectParticipationService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
        providedIn: "root"
    })
], ProjectParticipationService);



/***/ }),

/***/ "./src/app/core/http/project-type/project-type-Http.service.ts":
/*!*********************************************************************!*\
  !*** ./src/app/core/http/project-type/project-type-Http.service.ts ***!
  \*********************************************************************/
/*! exports provided: ProjectTypeHttp */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectTypeHttp", function() { return ProjectTypeHttp; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
/* harmony import */ var src_app_configs_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! src/app/configs/api-endpoint.constants */ "./src/app/configs/api-endpoint.constants.ts");




let ProjectTypeHttp = class ProjectTypeHttp {
    constructor(http) {
        this.http = http;
    }
    getAllProjectTypes() {
        return this.http.get(src_app_configs_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_3__["projectTypeUrl"]);
    }
    put(data) {
        const urlParams = new _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpParams"]().set("id", data.id.toString());
        return this.http.put(src_app_configs_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_3__["projectTypeUrl"], data, { params: urlParams });
    }
    delete(projectTypeId) {
        return this.http.delete(src_app_configs_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_3__["projectTypeUrl"] + "/" + projectTypeId, {
            observe: "response"
        });
    }
    post(newProjectType) {
        return this.http.post(src_app_configs_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_3__["projectTypeUrl"], newProjectType);
    }
};
ProjectTypeHttp.ctorParameters = () => [
    { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"] }
];
ProjectTypeHttp = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])()
], ProjectTypeHttp);



/***/ }),

/***/ "./src/app/core/http/project/http-project.service.ts":
/*!***********************************************************!*\
  !*** ./src/app/core/http/project/http-project.service.ts ***!
  \***********************************************************/
/*! exports provided: HttpProjectService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "HttpProjectService", function() { return HttpProjectService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
/* harmony import */ var src_app_configs_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! src/app/configs/api-endpoint.constants */ "./src/app/configs/api-endpoint.constants.ts");




let HttpProjectService = class HttpProjectService {
    constructor(http) {
        this.http = http;
        this.url = src_app_configs_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_3__["projectUrl"];
    }
    getAllProjectParticipants() {
        return this.http.get(this.url);
    }
    GetProjectsByStatus(status) {
        return this.http.get(this.url + "/newstatus/" + status);
    }
    Approve(id) {
        return this.http.get(this.url + "/approve/" + id);
    }
    Reject(id) {
        return this.http.get(this.url + "/reject/" + id);
    }
};
HttpProjectService.ctorParameters = () => [
    { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"] }
];
HttpProjectService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])()
], HttpProjectService);



/***/ }),

/***/ "./src/app/core/http/project/project.service.ts":
/*!******************************************************!*\
  !*** ./src/app/core/http/project/project.service.ts ***!
  \******************************************************/
/*! exports provided: ProjectService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectService", function() { return ProjectService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm2015/forms.js");
/* harmony import */ var _http_http_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../http/http.service */ "./src/app/core/http/http/http.service.ts");
/* harmony import */ var _ngx_translate_core__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @ngx-translate/core */ "./node_modules/@ngx-translate/core/fesm2015/ngx-translate-core.js");
/* harmony import */ var _services_notification_notification_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../../services/notification/notification.service */ "./src/app/core/services/notification/notification.service.ts");






let ProjectService = class ProjectService {
    constructor(fb, httpService, notificationService, translate) {
        this.fb = fb;
        this.httpService = httpService;
        this.notificationService = notificationService;
        this.translate = translate;
        this.form = this.fb.group({
            id: [""],
            name: [
                "",
                [_angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required, _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].minLength(3), _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].maxLength(50)]
            ],
            description: [
                "",
                [
                    _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required,
                    _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].minLength(10),
                    _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].maxLength(8000)
                ]
            ],
            details: ["", _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].maxLength(8000)],
            projectStart: ["", _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required],
            projectEnd: [""],
            typeId: ["", _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required],
            donationTargetSum: [""]
        });
    }
    initializeFormGroup() {
        this.form.setValue({
            id: null,
            name: "",
            description: "",
            details: "",
            projectStart: "",
            projectEnd: "",
            typeId: "",
            donationTargetSum: ""
        });
    }
    populateForm(project) {
        this.form.setValue({
            id: project.id,
            name: project.name,
            description: project.description,
            details: project.details,
            projectStart: project.projectStart,
            projectEnd: project.projectEnd,
            typeId: project.typeId,
            donationTargetSum: project.donationTargetSum
        });
    }
    addProject(project) {
        this.httpService.createProject(project).subscribe((msg) => tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            msg = yield this.translate
                .get("common.created-successfully")
                .toPromise();
            this.notificationService.success(msg);
        }), (error) => tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            console.log(error);
            this.notificationService.warn(yield this.translate.get("common.wth").toPromise());
        }));
    }
    editProject(project) {
        this.httpService.updateProject(project).subscribe((msg) => tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            msg = yield this.translate.get("updated-successfully").toPromise();
            this.notificationService.success(msg);
        }), (error) => tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            console.log(error);
            this.notificationService.warn(yield this.translate.get("common.wth").toPromise());
        }));
    }
    getProjectTypes() {
        return this.httpService.getAllProjectTypes();
    }
};
ProjectService.ctorParameters = () => [
    { type: _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormBuilder"] },
    { type: _http_http_service__WEBPACK_IMPORTED_MODULE_3__["HttpService"] },
    { type: _services_notification_notification_service__WEBPACK_IMPORTED_MODULE_5__["NotificationService"] },
    { type: _ngx_translate_core__WEBPACK_IMPORTED_MODULE_4__["TranslateService"] }
];
ProjectService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
        providedIn: "root"
    })
], ProjectService);



/***/ }),

/***/ "./src/app/core/http/resource/resource-create.service.ts":
/*!***************************************************************!*\
  !*** ./src/app/core/http/resource/resource-create.service.ts ***!
  \***************************************************************/
/*! exports provided: ResourceCreateService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourceCreateService", function() { return ResourceCreateService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm2015/forms.js");
/* harmony import */ var _configs_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../../configs/api-endpoint.constants */ "./src/app/configs/api-endpoint.constants.ts");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
/* harmony import */ var _ngx_translate_core__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @ngx-translate/core */ "./node_modules/@ngx-translate/core/fesm2015/ngx-translate-core.js");
/* harmony import */ var _services_notification_notification_service__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ../../services/notification/notification.service */ "./src/app/core/services/notification/notification.service.ts");
/* harmony import */ var src_app_configs_resource_constants__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! src/app/configs/resource.constants */ "./src/app/configs/resource.constants.ts");
/* harmony import */ var src_app_shared_directives_files_forbidden_extension_directive__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! src/app/shared/directives/files/forbidden-extension.directive */ "./src/app/shared/directives/files/forbidden-extension.directive.ts");
/* harmony import */ var src_app_shared_directives_files_atleastone_form_directive___WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! src/app/shared/directives/files/atleastone-form.directive. */ "./src/app/shared/directives/files/atleastone-form.directive..ts");










let ResourceCreateService = class ResourceCreateService {
    constructor(formBuilder, notificationService, http, translate) {
        this.formBuilder = formBuilder;
        this.notificationService = notificationService;
        this.http = http;
        this.translate = translate;
        this.resourceUrl = _configs_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_3__["resourceUrl"];
        this.categoryUrl = _configs_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_3__["categoryUrl"];
        this.resourceForm = this.formBuilder.group({
            id: [null],
            name: [
                "",
                [
                    _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required,
                    _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].minLength(3),
                    _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].maxLength(50)
                ]
            ],
            description: [
                "",
                [
                    _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required,
                    _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].minLength(5),
                    _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].maxLength(5000)
                ]
            ],
            url: [""],
            // fileName: [""],
            file: [null, [Object(src_app_shared_directives_files_forbidden_extension_directive__WEBPACK_IMPORTED_MODULE_8__["forbiddenExtensionValidator"])(src_app_configs_resource_constants__WEBPACK_IMPORTED_MODULE_7__["ForbiddenExts"])]],
            categoryId: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required]
        }, { validators: [Object(src_app_shared_directives_files_atleastone_form_directive___WEBPACK_IMPORTED_MODULE_9__["atLeastOne"])(_angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required, ["url", "file"])] });
        this.resourceForm.get("file").valueChanges.subscribe(val => {
            const isValidFile = !this.isNullOrEmpty(val);
            if (isValidFile) {
                this.resourceForm.get("url").disable();
            }
            else if (this.resourceForm.get("url").disabled) {
                this.resourceForm.get("url").enable();
            }
        });
    }
    isNullOrEmpty(fileInput) {
        if (fileInput == null) {
            return true;
        }
        if (fileInput.files == null) {
            return true;
        }
        if (fileInput.files.length == 0) {
            return true;
        }
        if (fileInput.files[0].size == 0) {
            return true;
        }
        return false;
    }
    initializeForm() {
        this.resourceForm.setValue({
            id: null,
            name: "",
            description: "",
            url: "",
            // fileName: "",
            file: null,
            categoryId: null
        });
    }
    postResource(resource) {
        const formData = new FormData();
        formData.append("name", resource.name);
        formData.append("description", resource.description);
        formData.append("categoryId", resource.categoryId.toString());
        if (resource.file) {
            formData.append("File", resource.file);
        }
        else {
            formData.append("url", resource.url);
        }
        return this.http.post(this.resourceUrl + "/" + "create", formData);
    }
    putResource(resource) {
        return this.http.put(this.resourceUrl + "/" + "update", resource);
    }
    getCategories() {
        return this.http.get(this.categoryUrl + "/" + "get");
    }
    populateForm(resource) {
        this.resourceForm.setValue(resource);
    }
    addResource(resource) {
        this.postResource(resource).subscribe((response) => tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            this.notificationService.success(yield this.translate.get("common.created-successfully").toPromise());
        }), (error) => tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            this.notificationService.warn(yield this.translate.get("common.wth").toPromise());
        }));
    }
    updateResource(resource) {
        this.putResource(resource).subscribe((response) => tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            this.notificationService.success(yield this.translate.get("common.updated-successfully").toPromise());
        }), (error) => tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            this.notificationService.warn(yield this.translate.get("common.wth").toPromise());
        }));
    }
};
ResourceCreateService.ctorParameters = () => [
    { type: _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormBuilder"] },
    { type: _services_notification_notification_service__WEBPACK_IMPORTED_MODULE_6__["NotificationService"] },
    { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_4__["HttpClient"] },
    { type: _ngx_translate_core__WEBPACK_IMPORTED_MODULE_5__["TranslateService"] }
];
ResourceCreateService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
        providedIn: "root"
    })
], ResourceCreateService);



/***/ }),

/***/ "./src/app/core/http/resource/resource.service.ts":
/*!********************************************************!*\
  !*** ./src/app/core/http/resource/resource.service.ts ***!
  \********************************************************/
/*! exports provided: ResourceService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourceService", function() { return ResourceService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _http_http_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../http/http.service */ "./src/app/core/http/http/http.service.ts");



let ResourceService = class ResourceService {
    constructor(http) {
        this.http = http;
        this.allProjectResources = [];
        this.allResources = [];
    }
    getAllResourcesByProjId(projid) {
        const allData = this.http
            .getAllResourcesById(projid)
            .toPromise()
            .then((data) => {
            this.allProjectResources = data;
            return data;
        });
        return allData;
    }
    getAllResourceCategories(arr) {
        const allResourceCategories = [];
        for (const cat in arr) {
            allResourceCategories.push(cat);
        }
        return allResourceCategories;
    }
    sortAllResourcesByCategories(res) {
        const sortedArray = [];
        res.forEach(resuorce => {
            if (!sortedArray[resuorce.resourceCategory.type]) {
                sortedArray[resuorce.resourceCategory.type] = [];
            }
            sortedArray[resuorce.resourceCategory.type].push(resuorce);
        });
        return sortedArray;
    }
    getResourcesByCategoryId(categoryId, pageNumber, recordsPerPage) {
        const allData = this.http
            .getResourcesByCategoryId(categoryId, pageNumber, recordsPerPage)
            .toPromise()
            .then((data) => {
            this.allResources = data;
            return data;
        });
        return allData;
    }
    getResourcesCountByCategoryId(categoryId) {
        const allData = this.http
            .getResourcesCountByCategoryId(categoryId)
            .toPromise()
            .then((data) => {
            this.countAllResourcesByCategoryId = data;
            return data;
        });
        return allData;
    }
};
ResourceService.ctorParameters = () => [
    { type: _http_http_service__WEBPACK_IMPORTED_MODULE_2__["HttpService"] }
];
ResourceService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])()
], ResourceService);



/***/ }),

/***/ "./src/app/core/services/cms/cms-route-helper.service.ts":
/*!***************************************************************!*\
  !*** ./src/app/core/services/cms/cms-route-helper.service.ts ***!
  \***************************************************************/
/*! exports provided: CmsRouteHelperService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CmsRouteHelperService", function() { return CmsRouteHelperService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _http_cms_site_map_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../http/cms/site-map.service */ "./src/app/core/http/cms/site-map.service.ts");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm2015/index.js");




let CmsRouteHelperService = class CmsRouteHelperService {
    constructor(siteMapService) {
        this.siteMapService = siteMapService;
        this.currentRouteSubject = new rxjs__WEBPACK_IMPORTED_MODULE_3__["Subject"]();
        this.siteSlugMapSubject = new rxjs__WEBPACK_IMPORTED_MODULE_3__["Subject"]();
        this.subscription = new rxjs__WEBPACK_IMPORTED_MODULE_3__["Subscription"]();
        this.subscribeOnToolbarItems();
        this.subscribeRoute();
        this.subscribeSiteSlugMap();
    }
    subscribeOnToolbarItems() {
        const subscription = this.siteMapService.toolbarItems.subscribe(next => {
            this.siteSlugMapSubject.next(this.createSiteSlugMap(next));
        });
        this.subscription.add(subscription);
    }
    subscribeRoute() {
        const subscription = this.currentRouteSubject.subscribe(next => {
            this.currentRoute = next;
        });
        this.subscription.add(subscription);
    }
    subscribeSiteSlugMap() {
        const subscription = this.siteSlugMapSubject.subscribe(next => {
            this.siteSlugMap = next;
        });
        this.subscription.add(subscription);
    }
    getRouteByPathAndUpdate(siteSlugMap, path) {
        const nextRoute = siteSlugMap.get(path);
        if (nextRoute) {
            this.currentRouteSubject.next(nextRoute);
        }
        else {
            this.currentRouteSubject.error("no routes found");
        }
    }
    updateRouteByPath(path) {
        if (this.siteMapService.siteMapUpdating || !this.siteSlugMap) {
            this.siteSlugMapSubject.subscribe(next => this.getRouteByPathAndUpdate(next, path));
        }
        else {
            this.getRouteByPathAndUpdate(this.siteSlugMap, path);
        }
    }
    updateRoute(cmsRoute) {
        this.currentRouteSubject.next(cmsRoute);
    }
    createSiteSlugMap(toolbarItems) {
        const map = new Map();
        toolbarItems.forEach(item => {
            this.createSiteSlugMap(item.subItems).forEach((value, key) => map.set(key, value));
            map.set(item.permalink, item.cmsRoute);
        });
        return map;
    }
};
CmsRouteHelperService.ctorParameters = () => [
    { type: _http_cms_site_map_service__WEBPACK_IMPORTED_MODULE_2__["SiteMapService"] }
];
CmsRouteHelperService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
        providedIn: "root"
    })
], CmsRouteHelperService);



/***/ }),

/***/ "./src/app/core/services/dialog/dialog.service.ts":
/*!********************************************************!*\
  !*** ./src/app/core/services/dialog/dialog.service.ts ***!
  \********************************************************/
/*! exports provided: DialogService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "DialogService", function() { return DialogService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm2015/material.js");
/* harmony import */ var _shared_components_confirm_dialog_confirm_dialog_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../../shared/components/confirm-dialog/confirm-dialog.component */ "./src/app/shared/components/confirm-dialog/confirm-dialog.component.ts");




let DialogService = class DialogService {
    constructor(dialog) {
        this.dialog = dialog;
    }
    openConfirmDialog(msg) {
        return this.dialog.open(_shared_components_confirm_dialog_confirm_dialog_component__WEBPACK_IMPORTED_MODULE_3__["ConfirmDialogComponent"], {
            width: "390px",
            panelClass: "confirm-dialog-container",
            disableClose: true,
            position: { top: "10px" },
            data: {
                message: msg
            }
        });
    }
    openFormDialog(formComponent) {
        const dialogConfig = new _angular_material__WEBPACK_IMPORTED_MODULE_2__["MatDialogConfig"]();
        dialogConfig.disableClose = true;
        dialogConfig.autoFocus = true;
        dialogConfig.width = "60%";
        dialogConfig.panelClass = "form";
        this.dialog.open(formComponent, dialogConfig);
    }
    closeDialogs() {
        this.dialog.closeAll();
    }
};
DialogService.ctorParameters = () => [
    { type: _angular_material__WEBPACK_IMPORTED_MODULE_2__["MatDialog"] }
];
DialogService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
        providedIn: "root"
    })
], DialogService);



/***/ }),

/***/ "./src/app/core/services/event/event-service.ts":
/*!******************************************************!*\
  !*** ./src/app/core/services/event/event-service.ts ***!
  \******************************************************/
/*! exports provided: EventService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "EventService", function() { return EventService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm2015/index.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");



let EventService = class EventService {
    constructor() {
        this.childClickedEvent = new rxjs__WEBPACK_IMPORTED_MODULE_1__["Subject"]();
    }
    emitChildEvent() {
        this.childClickedEvent.next();
    }
    childEventListner() {
        return this.childClickedEvent.asObservable();
    }
};
EventService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["Injectable"])()
], EventService);



/***/ }),

/***/ "./src/app/core/services/notification/notification.service.ts":
/*!********************************************************************!*\
  !*** ./src/app/core/services/notification/notification.service.ts ***!
  \********************************************************************/
/*! exports provided: NotificationService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "NotificationService", function() { return NotificationService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm2015/material.js");



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
NotificationService.ctorParameters = () => [
    { type: _angular_material__WEBPACK_IMPORTED_MODULE_2__["MatSnackBar"] }
];
NotificationService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
        providedIn: 'root'
    })
], NotificationService);



/***/ }),

/***/ "./src/app/core/services/project-type/project-type.service.ts":
/*!********************************************************************!*\
  !*** ./src/app/core/services/project-type/project-type.service.ts ***!
  \********************************************************************/
/*! exports provided: ProjectTypeService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectTypeService", function() { return ProjectTypeService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _http_project_type_project_type_Http_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../http/project-type/project-type-Http.service */ "./src/app/core/http/project-type/project-type-Http.service.ts");
/* harmony import */ var _ngx_translate_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @ngx-translate/core */ "./node_modules/@ngx-translate/core/fesm2015/ngx-translate-core.js");
/* harmony import */ var _notification_notification_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../notification/notification.service */ "./src/app/core/services/notification/notification.service.ts");





let ProjectTypeService = class ProjectTypeService {
    constructor(http, notificationService, translate) {
        this.http = http;
        this.notificationService = notificationService;
        this.translate = translate;
    }
    getAllProjectTypes() {
        const alldata = this.http
            .getAllProjectTypes()
            .toPromise()
            .then((data) => {
            this.allProjectTypes = data;
            return data;
        });
        return alldata;
    }
    Update(projectType) {
        this.http.put(projectType).subscribe((response) => tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            this.notificationService.success(yield this.getLocalization("common.updated-successfully"));
            // "Project type was successfully updated"
        }), (error) => tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            this.notificationService.warn(yield this.getLocalization("common.wth"));
            // "Project type was not updated"
        }));
    }
    Create(newProjectType) {
        this.http.post(newProjectType).subscribe((response) => tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            this.notificationService.success(yield this.getLocalization("common.added-successfully"));
            // "Project type was successfully added"
        }), (error) => tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            this.notificationService.warn(yield this.getLocalization("common.wth"));
            // "Project type was not added"
        }));
        return;
    }
    Delete(projectTypeId) {
        this.http.delete(projectTypeId).subscribe((response) => tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            this.notificationService.success(yield this.getLocalization("common.deleted-successfully"));
            // "Project type was successfully deleted"
        }), (error) => tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            this.notificationService.warn(yield this.getLocalization("common.wth"));
            // "Project type was not deleted"
        }));
    }
    getLocalization(locPath) {
        return this.translate.get(locPath).toPromise();
    }
};
ProjectTypeService.ctorParameters = () => [
    { type: _http_project_type_project_type_Http_service__WEBPACK_IMPORTED_MODULE_2__["ProjectTypeHttp"] },
    { type: _notification_notification_service__WEBPACK_IMPORTED_MODULE_4__["NotificationService"] },
    { type: _ngx_translate_core__WEBPACK_IMPORTED_MODULE_3__["TranslateService"] }
];
ProjectTypeService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])()
], ProjectTypeService);



/***/ }),

/***/ "./src/app/core/services/resource/resource-categories.service.ts":
/*!***********************************************************************!*\
  !*** ./src/app/core/services/resource/resource-categories.service.ts ***!
  \***********************************************************************/
/*! exports provided: ResourceCategoriesService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourceCategoriesService", function() { return ResourceCategoriesService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _http_http_http_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../http/http/http.service */ "./src/app/core/http/http/http.service.ts");



let ResourceCategoriesService = class ResourceCategoriesService {
    constructor(http) {
        this.http = http;
    }
    getResourceCategories(withAssignedResources) {
        const categories = this.http
            .getResourceCategories(withAssignedResources)
            .toPromise()
            .then((category) => {
            this.resourceCategories = category;
            return category;
        });
        return categories;
    }
};
ResourceCategoriesService.ctorParameters = () => [
    { type: _http_http_http_service__WEBPACK_IMPORTED_MODULE_2__["HttpService"] }
];
ResourceCategoriesService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])()
], ResourceCategoriesService);



/***/ }),

/***/ "./src/app/core/toolbar/cms-pages-toolbar-item/cms-pages-toolbar-item.component.less":
/*!*******************************************************************************************!*\
  !*** ./src/app/core/toolbar/cms-pages-toolbar-item/cms-pages-toolbar-item.component.less ***!
  \*******************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2NvcmUvdG9vbGJhci9jbXMtcGFnZXMtdG9vbGJhci1pdGVtL2Ntcy1wYWdlcy10b29sYmFyLWl0ZW0uY29tcG9uZW50Lmxlc3MifQ== */");

/***/ }),

/***/ "./src/app/core/toolbar/cms-pages-toolbar-item/cms-pages-toolbar-item.component.ts":
/*!*****************************************************************************************!*\
  !*** ./src/app/core/toolbar/cms-pages-toolbar-item/cms-pages-toolbar-item.component.ts ***!
  \*****************************************************************************************/
/*! exports provided: CmsPagesToolbarItemComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CmsPagesToolbarItemComponent", function() { return CmsPagesToolbarItemComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _http_cms_site_map_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../http/cms/site-map.service */ "./src/app/core/http/cms/site-map.service.ts");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm2015/index.js");




let CmsPagesToolbarItemComponent = class CmsPagesToolbarItemComponent {
    constructor(siteMapService) {
        this.siteMapService = siteMapService;
        this.toolbarItems = [];
        this.subscription = new rxjs__WEBPACK_IMPORTED_MODULE_3__["Subscription"]();
    }
    ngOnInit() {
        this.subscribeOnSiteMapService();
    }
    ngOnDestroy() {
        this.subscription.unsubscribe();
    }
    subscribeOnSiteMapService() {
        const toolbarItemsSubscription = this.siteMapService.toolbarItems.subscribe(next => (this.toolbarItems = next), error => "do nothing for now");
        this.subscription.add(toolbarItemsSubscription);
    }
};
CmsPagesToolbarItemComponent.ctorParameters = () => [
    { type: _http_cms_site_map_service__WEBPACK_IMPORTED_MODULE_2__["SiteMapService"] }
];
CmsPagesToolbarItemComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-cms-pages-toolbar-item',
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./cms-pages-toolbar-item.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/core/toolbar/cms-pages-toolbar-item/cms-pages-toolbar-item.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./cms-pages-toolbar-item.component.less */ "./src/app/core/toolbar/cms-pages-toolbar-item/cms-pages-toolbar-item.component.less")).default, tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ../toolbar-menu-item.less */ "./src/app/core/toolbar/toolbar-menu-item.less")).default]
    })
], CmsPagesToolbarItemComponent);



/***/ }),

/***/ "./src/app/core/toolbar/cms-pages-toolbar-item/toolbar-item.ts":
/*!*********************************************************************!*\
  !*** ./src/app/core/toolbar/cms-pages-toolbar-item/toolbar-item.ts ***!
  \*********************************************************************/
/*! exports provided: ToolbarItem */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ToolbarItem", function() { return ToolbarItem; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");

class ToolbarItem {
    constructor(route, cmsRoute, title, subItems) {
        this.title = title;
        this.subItems = subItems ? subItems : [];
        this.permalink = route;
        this.cmsRoute = cmsRoute;
    }
}


/***/ }),

/***/ "./src/app/core/toolbar/language/language.component.less":
/*!***************************************************************!*\
  !*** ./src/app/core/toolbar/language/language.component.less ***!
  \***************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2NvcmUvdG9vbGJhci9sYW5ndWFnZS9sYW5ndWFnZS5jb21wb25lbnQubGVzcyJ9 */");

/***/ }),

/***/ "./src/app/core/toolbar/language/language.component.ts":
/*!*************************************************************!*\
  !*** ./src/app/core/toolbar/language/language.component.ts ***!
  \*************************************************************/
/*! exports provided: LanguageComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LanguageComponent", function() { return LanguageComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _ngx_translate_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @ngx-translate/core */ "./node_modules/@ngx-translate/core/fesm2015/ngx-translate-core.js");



let LanguageComponent = class LanguageComponent {
    constructor(translate) {
        this.translate = translate;
        this.languages = ['en', 'ua'];
    }
    ngOnInit() {
    }
    changeLang(lang) {
        this.translate.use(lang);
    }
};
LanguageComponent.ctorParameters = () => [
    { type: _ngx_translate_core__WEBPACK_IMPORTED_MODULE_2__["TranslateService"] }
];
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])('menu', { static: false })
], LanguageComponent.prototype, "menu", void 0);
LanguageComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-language',
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./language.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/core/toolbar/language/language.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./language.component.less */ "./src/app/core/toolbar/language/language.component.less")).default]
    })
], LanguageComponent);



/***/ }),

/***/ "./src/app/core/toolbar/profile-menu/profile-menu.component.less":
/*!***********************************************************************!*\
  !*** ./src/app/core/toolbar/profile-menu/profile-menu.component.less ***!
  \***********************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2NvcmUvdG9vbGJhci9wcm9maWxlLW1lbnUvcHJvZmlsZS1tZW51LmNvbXBvbmVudC5sZXNzIn0= */");

/***/ }),

/***/ "./src/app/core/toolbar/profile-menu/profile-menu.component.ts":
/*!*********************************************************************!*\
  !*** ./src/app/core/toolbar/profile-menu/profile-menu.component.ts ***!
  \*********************************************************************/
/*! exports provided: ProfileMenuComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProfileMenuComponent", function() { return ProfileMenuComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _ngx_translate_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @ngx-translate/core */ "./node_modules/@ngx-translate/core/fesm2015/ngx-translate-core.js");
/* harmony import */ var _auth_user_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../auth/user.service */ "./src/app/core/auth/user.service.ts");
/* harmony import */ var _services_notification_notification_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../../services/notification/notification.service */ "./src/app/core/services/notification/notification.service.ts");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");






let ProfileMenuComponent = class ProfileMenuComponent {
    constructor(userService, notification, translate, router) {
        this.userService = userService;
        this.notification = notification;
        this.translate = translate;
        this.router = router;
    }
    ngOnInit() { }
    onLogout() {
        this.userService.logout();
        window.location.reload();
    }
};
ProfileMenuComponent.ctorParameters = () => [
    { type: _auth_user_service__WEBPACK_IMPORTED_MODULE_3__["UserService"] },
    { type: _services_notification_notification_service__WEBPACK_IMPORTED_MODULE_4__["NotificationService"] },
    { type: _ngx_translate_core__WEBPACK_IMPORTED_MODULE_2__["TranslateService"] },
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_5__["Router"] }
];
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])("menu", { static: true })
], ProfileMenuComponent.prototype, "menu", void 0);
ProfileMenuComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: "app-profile-menu",
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./profile-menu.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/core/toolbar/profile-menu/profile-menu.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./profile-menu.component.less */ "./src/app/core/toolbar/profile-menu/profile-menu.component.less")).default]
    })
], ProfileMenuComponent);



/***/ }),

/***/ "./src/app/core/toolbar/toolbar-item/cms-route.ts":
/*!********************************************************!*\
  !*** ./src/app/core/toolbar/toolbar-item/cms-route.ts ***!
  \********************************************************/
/*! exports provided: CmsRoute */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CmsRoute", function() { return CmsRoute; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");

class CmsRoute {
    constructor(pageTypeName, id) {
        this.pageTypeName = pageTypeName;
        this.id = id;
    }
}


/***/ }),

/***/ "./src/app/core/toolbar/toolbar-item/toolbar-item.component.less":
/*!***********************************************************************!*\
  !*** ./src/app/core/toolbar/toolbar-item/toolbar-item.component.less ***!
  \***********************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".mat-menu-item {\n  margin: 0;\n  width: auto;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvY29yZS90b29sYmFyL3Rvb2xiYXItaXRlbS9DOi9Eb2N1bWVudHMvR2l0SHViL3dpdGhvdXQgUGlyYW5oYS9UaGVyYUxhbmcvVGhlcmFMYW5nLldlYi9DbGllbnRBcHAvc3JjL2FwcC9jb3JlL3Rvb2xiYXIvdG9vbGJhci1pdGVtL3Rvb2xiYXItaXRlbS5jb21wb25lbnQubGVzcyIsInNyYy9hcHAvY29yZS90b29sYmFyL3Rvb2xiYXItaXRlbS90b29sYmFyLWl0ZW0uY29tcG9uZW50Lmxlc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDSSxTQUFBO0VBQ0EsV0FBQTtBQ0NKIiwiZmlsZSI6InNyYy9hcHAvY29yZS90b29sYmFyL3Rvb2xiYXItaXRlbS90b29sYmFyLWl0ZW0uY29tcG9uZW50Lmxlc3MiLCJzb3VyY2VzQ29udGVudCI6WyIubWF0LW1lbnUtaXRlbSB7XG4gICAgbWFyZ2luOiAwO1xuICAgIHdpZHRoOmF1dG87XG59IiwiLm1hdC1tZW51LWl0ZW0ge1xuICBtYXJnaW46IDA7XG4gIHdpZHRoOiBhdXRvO1xufVxuIl19 */");

/***/ }),

/***/ "./src/app/core/toolbar/toolbar-item/toolbar-item.component.ts":
/*!*********************************************************************!*\
  !*** ./src/app/core/toolbar/toolbar-item/toolbar-item.component.ts ***!
  \*********************************************************************/
/*! exports provided: ToolbarItemComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ToolbarItemComponent", function() { return ToolbarItemComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _services_cms_cms_route_helper_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../services/cms/cms-route-helper.service */ "./src/app/core/services/cms/cms-route-helper.service.ts");



let ToolbarItemComponent = class ToolbarItemComponent {
    constructor(cmsRouteHelperService) {
        this.cmsRouteHelperService = cmsRouteHelperService;
    }
    ngOnInit() { }
    isFinalMenu() {
        return !this.needSubMenus();
    }
    needSubMenus() {
        return this.toolbarItem.subItems.length > 0; // && this.toolbarItem.cmsRoute.pageTypeName !== 'Blog archive';
        // TODO: adjust if you need exclude
    }
    onClick() {
        this.cmsRouteHelperService.updateRoute(this.toolbarItem.cmsRoute);
    }
};
ToolbarItemComponent.ctorParameters = () => [
    { type: _services_cms_cms_route_helper_service__WEBPACK_IMPORTED_MODULE_2__["CmsRouteHelperService"] }
];
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])()
], ToolbarItemComponent.prototype, "toolbarItem", void 0);
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])("menu", { static: false })
], ToolbarItemComponent.prototype, "menu", void 0);
ToolbarItemComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: "app-toolbar-item",
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./toolbar-item.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/core/toolbar/toolbar-item/toolbar-item.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./toolbar-item.component.less */ "./src/app/core/toolbar/toolbar-item/toolbar-item.component.less")).default]
    })
], ToolbarItemComponent);



/***/ }),

/***/ "./src/app/core/toolbar/toolbar-menu-item.less":
/*!*****************************************************!*\
  !*** ./src/app/core/toolbar/toolbar-menu-item.less ***!
  \*****************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".menu-item {\n  border-radius: 0;\n  height: 75%;\n}\n.menu-item:hover {\n  border-bottom: 3px solid;\n  border-color: #4a1e5f;\n}\na {\n  text-decoration: none;\n  font-size: 100%;\n  white-space: normal;\n  color: black;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvY29yZS90b29sYmFyL0M6L0RvY3VtZW50cy9HaXRIdWIvd2l0aG91dCBQaXJhbmhhL1RoZXJhTGFuZy9UaGVyYUxhbmcuV2ViL0NsaWVudEFwcC9zcmMvYXBwL2NvcmUvdG9vbGJhci90b29sYmFyLW1lbnUtaXRlbS5sZXNzIiwic3JjL2FwcC9jb3JlL3Rvb2xiYXIvdG9vbGJhci1tZW51LWl0ZW0ubGVzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFDQTtFQUNJLGdCQUFBO0VBQ0EsV0FBQTtBQ0FKO0FER0E7RUFDSSx3QkFBQTtFQUNBLHFCQUFBO0FDREo7QURJQTtFQUNJLHFCQUFBO0VBQ0EsZUFBQTtFQUNBLG1CQUFBO0VBQ0EsWUFBQTtBQ0ZKIiwiZmlsZSI6InNyYy9hcHAvY29yZS90b29sYmFyL3Rvb2xiYXItbWVudS1pdGVtLmxlc3MiLCJzb3VyY2VzQ29udGVudCI6WyJcbi5tZW51LWl0ZW0ge1xuICAgIGJvcmRlci1yYWRpdXM6IDA7XG4gICAgaGVpZ2h0OiA3NSU7XG4gIH1cbiAgXG4ubWVudS1pdGVtOmhvdmVyIHtcbiAgICBib3JkZXItYm90dG9tOiAzcHggc29saWQ7XG4gICAgYm9yZGVyLWNvbG9yOiAjNGExZTVmO1xufVxuXG5he1xuICAgIHRleHQtZGVjb3JhdGlvbjogbm9uZTtcbiAgICBmb250LXNpemU6IDEwMCU7XG4gICAgd2hpdGUtc3BhY2U6IG5vcm1hbDtcbiAgICBjb2xvcjogYmxhY2s7XG59IiwiLm1lbnUtaXRlbSB7XG4gIGJvcmRlci1yYWRpdXM6IDA7XG4gIGhlaWdodDogNzUlO1xufVxuLm1lbnUtaXRlbTpob3ZlciB7XG4gIGJvcmRlci1ib3R0b206IDNweCBzb2xpZDtcbiAgYm9yZGVyLWNvbG9yOiAjNGExZTVmO1xufVxuYSB7XG4gIHRleHQtZGVjb3JhdGlvbjogbm9uZTtcbiAgZm9udC1zaXplOiAxMDAlO1xuICB3aGl0ZS1zcGFjZTogbm9ybWFsO1xuICBjb2xvcjogYmxhY2s7XG59XG4iXX0= */");

/***/ }),

/***/ "./src/app/core/toolbar/toolbar.component.less":
/*!*****************************************************!*\
  !*** ./src/app/core/toolbar/toolbar.component.less ***!
  \*****************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".img-wrapper {\n  height: 100%;\n  padding-left: 0;\n  width: auto;\n}\n.mat-toolbar {\n  height: 7vh;\n  padding-left: 0;\n  position: fixed;\n  z-index: 2;\n  background-color: white;\n}\n.fill-toolbar-space {\n  height: 7vh;\n}\ndiv {\n  overflow: inherit;\n}\n.fill-space {\n  flex: 1 1 auto;\n}\n.language {\n  padding-right: 2vh;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvY29yZS90b29sYmFyL0M6L0RvY3VtZW50cy9HaXRIdWIvd2l0aG91dCBQaXJhbmhhL1RoZXJhTGFuZy9UaGVyYUxhbmcuV2ViL0NsaWVudEFwcC9zcmMvYXBwL2NvcmUvdG9vbGJhci90b29sYmFyLmNvbXBvbmVudC5sZXNzIiwic3JjL2FwcC9jb3JlL3Rvb2xiYXIvdG9vbGJhci5jb21wb25lbnQubGVzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQTtFQUNFLFlBQUE7RUFDQSxlQUFBO0VBQ0EsV0FBQTtBQ0NGO0FERUE7RUFDRSxXQUFBO0VBQ0EsZUFBQTtFQUNBLGVBQUE7RUFDQSxVQUFBO0VBQ0EsdUJBQUE7QUNBRjtBREdBO0VBQ0UsV0FBQTtBQ0RGO0FESUE7RUFDRSxpQkFBQTtBQ0ZGO0FETUE7RUFDRSxjQUFBO0FDSkY7QURPQTtFQUNFLGtCQUFBO0FDTEYiLCJmaWxlIjoic3JjL2FwcC9jb3JlL3Rvb2xiYXIvdG9vbGJhci5jb21wb25lbnQubGVzcyIsInNvdXJjZXNDb250ZW50IjpbIi5pbWctd3JhcHBlcntcbiAgaGVpZ2h0OiAxMDAlO1xuICBwYWRkaW5nLWxlZnQ6IDA7XG4gIHdpZHRoOmF1dG87XG59XG5cbi5tYXQtdG9vbGJhcntcbiAgaGVpZ2h0OiA3dmg7XG4gIHBhZGRpbmctbGVmdDogMDtcbiAgcG9zaXRpb246IGZpeGVkO1xuICB6LWluZGV4OiAyO1xuICBiYWNrZ3JvdW5kLWNvbG9yOiB3aGl0ZTtcbn1cblxuLmZpbGwtdG9vbGJhci1zcGFjZSB7XG4gIGhlaWdodDogN3ZoO1xufVxuXG5kaXYge1xuICBvdmVyZmxvdzogaW5oZXJpdDtcbn1cblxuXG4uZmlsbC1zcGFjZSB7XG4gIGZsZXg6IDEgMSBhdXRvO1xufVxuXG4ubGFuZ3VhZ2Uge1xuICBwYWRkaW5nLXJpZ2h0OiAydmg7XG59IiwiLmltZy13cmFwcGVyIHtcbiAgaGVpZ2h0OiAxMDAlO1xuICBwYWRkaW5nLWxlZnQ6IDA7XG4gIHdpZHRoOiBhdXRvO1xufVxuLm1hdC10b29sYmFyIHtcbiAgaGVpZ2h0OiA3dmg7XG4gIHBhZGRpbmctbGVmdDogMDtcbiAgcG9zaXRpb246IGZpeGVkO1xuICB6LWluZGV4OiAyO1xuICBiYWNrZ3JvdW5kLWNvbG9yOiB3aGl0ZTtcbn1cbi5maWxsLXRvb2xiYXItc3BhY2Uge1xuICBoZWlnaHQ6IDd2aDtcbn1cbmRpdiB7XG4gIG92ZXJmbG93OiBpbmhlcml0O1xufVxuLmZpbGwtc3BhY2Uge1xuICBmbGV4OiAxIDEgYXV0bztcbn1cbi5sYW5ndWFnZSB7XG4gIHBhZGRpbmctcmlnaHQ6IDJ2aDtcbn1cbiJdfQ== */");

/***/ }),

/***/ "./src/app/core/toolbar/toolbar.component.ts":
/*!***************************************************!*\
  !*** ./src/app/core/toolbar/toolbar.component.ts ***!
  \***************************************************/
/*! exports provided: ToolbarComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ToolbarComponent", function() { return ToolbarComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm2015/index.js");
/* harmony import */ var _http_project_participants_project_participation_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../http/project-participants/project-participation.service */ "./src/app/core/http/project-participants/project-participation.service.ts");
/* harmony import */ var _services_event_event_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../services/event/event-service */ "./src/app/core/services/event/event-service.ts");
/* harmony import */ var _services_dialog_dialog_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../services/dialog/dialog.service */ "./src/app/core/services/dialog/dialog.service.ts");
/* harmony import */ var _auth_user_service__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ../auth/user.service */ "./src/app/core/auth/user.service.ts");
/* harmony import */ var src_app_configs_project_participation_request_status__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! src/app/configs/project-participation-request-status */ "./src/app/configs/project-participation-request-status.ts");
/* harmony import */ var src_app_modules_login_login_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! src/app/modules/login/login.component */ "./src/app/modules/login/login.component.ts");









let ToolbarComponent = class ToolbarComponent {
    constructor(participantService, eventService, dialog, userService) {
        this.participantService = participantService;
        this.eventService = eventService;
        this.dialog = dialog;
        this.userService = userService;
        this.hasNotification = false;
        this.subscription = new rxjs__WEBPACK_IMPORTED_MODULE_2__["Subscription"]();
    }
    ngOnInit() {
        const subscription = this.participantService
            .getAllProjectParticipants()
            .subscribe((projectParticipation) => {
            this.projectParticipation = projectParticipation;
            if (this.projectParticipation.filter(x => x.status === src_app_configs_project_participation_request_status__WEBPACK_IMPORTED_MODULE_7__["ProjectParticipationRequestStatus"].New).length > 0) {
                this.hasNotification = true;
            }
        });
        this.subscription.add(subscription);
        this.isAuthinticated = this.userService.isAuthenticated();
    }
    ngAfterViewInit() {
        this.eventService.childEventListner().subscribe(click => {
            this.hasNotification = false;
        });
    }
    ngOnDestroy() {
        this.subscription.unsubscribe();
    }
    onLogin() {
        this.dialog.openFormDialog(src_app_modules_login_login_component__WEBPACK_IMPORTED_MODULE_8__["LoginComponent"]);
    }
};
ToolbarComponent.ctorParameters = () => [
    { type: _http_project_participants_project_participation_service__WEBPACK_IMPORTED_MODULE_3__["ProjectParticipationService"] },
    { type: _services_event_event_service__WEBPACK_IMPORTED_MODULE_4__["EventService"] },
    { type: _services_dialog_dialog_service__WEBPACK_IMPORTED_MODULE_5__["DialogService"] },
    { type: _auth_user_service__WEBPACK_IMPORTED_MODULE_6__["UserService"] }
];
ToolbarComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: "app-toolbar",
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./toolbar.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/core/toolbar/toolbar.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./toolbar.component.less */ "./src/app/core/toolbar/toolbar.component.less")).default, tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./toolbar-menu-item.less */ "./src/app/core/toolbar/toolbar-menu-item.less")).default]
    })
], ToolbarComponent);



/***/ }),

/***/ "./src/app/modules/cms-generic/cms-routing.module.ts":
/*!***********************************************************!*\
  !*** ./src/app/modules/cms-generic/cms-routing.module.ts ***!
  \***********************************************************/
/*! exports provided: CmsRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CmsRoutingModule", function() { return CmsRoutingModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var _components_cms_generic_page_cms_generic_page_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./components/cms-generic-page/cms-generic-page.component */ "./src/app/modules/cms-generic/components/cms-generic-page/cms-generic-page.component.ts");




const routes = [{ path: "**", component: _components_cms_generic_page_cms_generic_page_component__WEBPACK_IMPORTED_MODULE_3__["CmsGenericPageComponent"] }];
let CmsRoutingModule = class CmsRoutingModule {
};
CmsRoutingModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        imports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"].forChild(routes)],
        exports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"]]
    })
], CmsRoutingModule);



/***/ }),

/***/ "./src/app/modules/cms-generic/cms.module.ts":
/*!***************************************************!*\
  !*** ./src/app/modules/cms-generic/cms.module.ts ***!
  \***************************************************/
/*! exports provided: CmsModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CmsModule", function() { return CmsModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm2015/common.js");
/* harmony import */ var _components_cms_generic_page_cms_generic_page_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./components/cms-generic-page/cms-generic-page.component */ "./src/app/modules/cms-generic/components/cms-generic-page/cms-generic-page.component.ts");
/* harmony import */ var _cms_routing_module__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./cms-routing.module */ "./src/app/modules/cms-generic/cms-routing.module.ts");
/* harmony import */ var _components_piranha_page_piranha_page_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./components/piranha-page/piranha-page.component */ "./src/app/modules/cms-generic/components/piranha-page/piranha-page.component.ts");
/* harmony import */ var _components_block_block_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./components/block/block.component */ "./src/app/modules/cms-generic/components/block/block.component.ts");
/* harmony import */ var _components_gallery_block_gallery_block_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./components/gallery-block/gallery-block.component */ "./src/app/modules/cms-generic/components/gallery-block/gallery-block.component.ts");
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ "./node_modules/@ng-bootstrap/ng-bootstrap/fesm2015/ng-bootstrap.js");
/* harmony import */ var _core_http_cms_site_map_service__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ../../core/http/cms/site-map.service */ "./src/app/core/http/cms/site-map.service.ts");
/* harmony import */ var _core_services_cms_cms_route_helper_service__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ../../core/services/cms/cms-route-helper.service */ "./src/app/core/services/cms/cms-route-helper.service.ts");
/* harmony import */ var _core_http_cms_cms_page_service__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ../../core/http/cms/cms-page.service */ "./src/app/core/http/cms/cms-page.service.ts");












let CmsModule = class CmsModule {
};
CmsModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        declarations: [
            _components_cms_generic_page_cms_generic_page_component__WEBPACK_IMPORTED_MODULE_3__["CmsGenericPageComponent"],
            _components_piranha_page_piranha_page_component__WEBPACK_IMPORTED_MODULE_5__["PiranhaPageComponent"],
            _components_block_block_component__WEBPACK_IMPORTED_MODULE_6__["BlockComponent"],
            _components_gallery_block_gallery_block_component__WEBPACK_IMPORTED_MODULE_7__["GalleryBlockComponent"]
        ],
        imports: [_angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"], _cms_routing_module__WEBPACK_IMPORTED_MODULE_4__["CmsRoutingModule"], _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_8__["NgbModule"]],
        exports: [_components_gallery_block_gallery_block_component__WEBPACK_IMPORTED_MODULE_7__["GalleryBlockComponent"]],
        providers: [_core_http_cms_site_map_service__WEBPACK_IMPORTED_MODULE_9__["SiteMapService"], _core_services_cms_cms_route_helper_service__WEBPACK_IMPORTED_MODULE_10__["CmsRouteHelperService"], _core_http_cms_cms_page_service__WEBPACK_IMPORTED_MODULE_11__["CmsPageService"]],
        bootstrap: [_components_gallery_block_gallery_block_component__WEBPACK_IMPORTED_MODULE_7__["GalleryBlockComponent"]]
    })
], CmsModule);



/***/ }),

/***/ "./src/app/modules/cms-generic/components/block/block.component.less":
/*!***************************************************************************!*\
  !*** ./src/app/modules/cms-generic/components/block/block.component.less ***!
  \***************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".QuoteBlock,\n.column-block app-block .QuoteBlock {\n  color: #999;\n  border: 1px solid #ddd;\n  padding: 1rem;\n  padding-top: 1.5rem;\n  font-size: 1.1rem;\n  box-shadow: 0 4px 0 #f2f2f4;\n  width: 100% !important;\n  margin: 0 auto;\n  margin-top: 1.5rem;\n  margin-bottom: 1.5rem;\n  font-weight: 300;\n  font-family: \"Open Sans\", sans-serif;\n}\nblockquote,\n.column-block app-block blockquote {\n  display: table-cell;\n  vertical-align: bottom;\n}\n.TextBlock .column-block app-block .TextBlock {\n  max-width: 68%;\n  margin: 0 auto;\n  margin-top: 1.5rem;\n  margin-bottom: 1.5rem;\n  text-align: left;\n  font-weight: 400;\n  font-size: 1rem;\n  line-height: 1.5;\n  font-family: \"Open Sans\", sans-serif;\n}\n.column-block .TextBlock {\n  padding: 1rem;\n}\n.column-block app-block {\n  display: inline;\n  text-align: left;\n  width: 100%;\n  margin-right: 15px;\n  margin-left: 15px;\n  margin-top: 1.5rem;\n}\n.column-block {\n  max-width: 65%;\n  text-align: center;\n  margin-top: 1.5rem;\n  margin-bottom: 1.5rem;\n  margin-left: auto;\n  margin-right: auto;\n  display: flex;\n  padding: 1rem;\n}\n.ImageBlock img {\n  max-width: 68%;\n  display: block;\n  margin: 0 auto;\n  box-shadow: 0 2px 4px 0px rgba(0, 0, 0, 0.2), 0 4px 5px 0 rgba(0, 0, 0, 0.14), 0 1px 10px 0 rgba(0, 0, 0, 0.12);\n}\n.TextBlockDiv .TextBlock {\n  min-height: 100px;\n  padding: 1rem;\n  max-width: 68%;\n  margin: 0 auto;\n  margin-top: 1.5rem;\n  margin-bottom: 1.5rem;\n  text-align: left;\n  font-weight: 400;\n  font-size: 1rem;\n  line-height: 1.5;\n  font-family: \"Open Sans\", sans-serif;\n}\n.VideoBlock,\n.AudioBlock,\n.column-block app-block {\n  margin: 0 auto;\n  width: 68%;\n  margin-top: 1.5rem;\n}\n.VideoBlock video {\n  width: 100%;\n  margin-top: 1.5rem;\n  margin-bottom: 1.5rem;\n  display: block;\n  vertical-align: middle;\n}\ndiv .ImageBlock {\n  margin-top: 1.5rem;\n  margin-bottom: 1.5rem;\n  margin: 0 auto;\n}\n.AudioBlock audio {\n  max-width: 50%;\n  min-width: 150px;\n}\n.SeparatorBlock hr {\n  border-top: 1px solid rgba(0, 0, 0, 0.1);\n  margin-top: 0.5rem;\n  margin-bottom: 0.5rem;\n  border-top-color: #eee;\n  max-width: 68%;\n}\n.SeparatorBlock,\n.HtmlBlock {\n  margin: 0 auto;\n  width: 68%;\n}\n.HtmlBlock {\n  font-family: \"Open Sans\", sans-serif;\n  font-size: 1rem;\n  font-weight: 400;\n  line-height: 1.5;\n  color: #212529;\n  text-align: left;\n}\n#quoteBlock {\n  width: 68%;\n  margin: 0 auto;\n}\n.GalleryBlock {\n  max-width: 45%;\n  margin: 0 auto;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvbW9kdWxlcy9jbXMtZ2VuZXJpYy9jb21wb25lbnRzL2Jsb2NrL0M6L0RvY3VtZW50cy9HaXRIdWIvd2l0aG91dCBQaXJhbmhhL1RoZXJhTGFuZy9UaGVyYUxhbmcuV2ViL0NsaWVudEFwcC9zcmMvYXBwL21vZHVsZXMvY21zLWdlbmVyaWMvY29tcG9uZW50cy9ibG9jay9ibG9jay5jb21wb25lbnQubGVzcyIsInNyYy9hcHAvbW9kdWxlcy9jbXMtZ2VuZXJpYy9jb21wb25lbnRzL2Jsb2NrL2Jsb2NrLmNvbXBvbmVudC5sZXNzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBOztFQUNJLFdBQUE7RUFDQSxzQkFBQTtFQUNBLGFBQUE7RUFDQSxtQkFBQTtFQUNBLGlCQUFBO0VBQ0EsMkJBQUE7RUFDQSxzQkFBQTtFQUNBLGNBQUE7RUFDQSxrQkFBQTtFQUNBLHFCQUFBO0VBQ0EsZ0JBQUE7RUFDQSxvQ0FBQTtBQ0VKO0FEQUE7O0VBQ0ksbUJBQUE7RUFDQSxzQkFBQTtBQ0dKO0FEQUE7RUFDSSxjQUFBO0VBQ0EsY0FBQTtFQUNBLGtCQUFBO0VBQ0EscUJBQUE7RUFDQSxnQkFBQTtFQUNBLGdCQUFBO0VBQ0EsZUFBQTtFQUNBLGdCQUFBO0VBQ0Esb0NBQUE7QUNFSjtBRENBO0VBQ0ksYUFBQTtBQ0NKO0FEQ0E7RUFDSSxlQUFBO0VBQ0EsZ0JBQUE7RUFDQSxXQUFBO0VBQ0Esa0JBQUE7RUFDQSxpQkFBQTtFQUNBLGtCQUFBO0FDQ0o7QURFQTtFQUNJLGNBQUE7RUFDQSxrQkFBQTtFQUNBLGtCQUFBO0VBQ0EscUJBQUE7RUFDQSxpQkFBQTtFQUNBLGtCQUFBO0VBQ0EsYUFBQTtFQUNBLGFBQUE7QUNBSjtBREdBO0VBQ0ksY0FBQTtFQUNBLGNBQUE7RUFDQSxjQUFBO0VBQ0EsK0dBQUE7QUNESjtBRElBO0VBQ0ksaUJBQUE7RUFDQSxhQUFBO0VBQ0EsY0FBQTtFQUNBLGNBQUE7RUFDQSxrQkFBQTtFQUNBLHFCQUFBO0VBQ0EsZ0JBQUE7RUFDQSxnQkFBQTtFQUNBLGVBQUE7RUFDQSxnQkFBQTtFQUNBLG9DQUFBO0FDRko7QURLQTs7O0VBQ0ksY0FBQTtFQUNBLFVBQUE7RUFDQSxrQkFBQTtBQ0RKO0FESUE7RUFDSSxXQUFBO0VBQ0Esa0JBQUE7RUFDQSxxQkFBQTtFQUNBLGNBQUE7RUFDQSxzQkFBQTtBQ0ZKO0FES0E7RUFDSSxrQkFBQTtFQUNBLHFCQUFBO0VBQ0EsY0FBQTtBQ0hKO0FETUE7RUFDSSxjQUFBO0VBQ0EsZ0JBQUE7QUNKSjtBRE9BO0VBQ0ksd0NBQUE7RUFDQSxrQkFBQTtFQUNBLHFCQUFBO0VBQ0Esc0JBQUE7RUFDQSxjQUFBO0FDTEo7QURRQTs7RUFDSSxjQUFBO0VBQ0EsVUFBQTtBQ0xKO0FEUUE7RUFDSSxvQ0FBQTtFQUNBLGVBQUE7RUFDQSxnQkFBQTtFQUNBLGdCQUFBO0VBQ0EsY0FBQTtFQUNBLGdCQUFBO0FDTko7QURTQTtFQUNJLFVBQUE7RUFDQSxjQUFBO0FDUEo7QURVQTtFQUNJLGNBQUE7RUFDQSxjQUFBO0FDUkoiLCJmaWxlIjoic3JjL2FwcC9tb2R1bGVzL2Ntcy1nZW5lcmljL2NvbXBvbmVudHMvYmxvY2svYmxvY2suY29tcG9uZW50Lmxlc3MiLCJzb3VyY2VzQ29udGVudCI6WyIuUXVvdGVCbG9jaywgLmNvbHVtbi1ibG9jayBhcHAtYmxvY2sgLlF1b3RlQmxvY2sge1xuICAgIGNvbG9yOiAjOTk5O1xuICAgIGJvcmRlcjogMXB4IHNvbGlkICNkZGQ7XG4gICAgcGFkZGluZzogMXJlbTtcbiAgICBwYWRkaW5nLXRvcDogMS41cmVtO1xuICAgIGZvbnQtc2l6ZTogMS4xcmVtO1xuICAgIGJveC1zaGFkb3c6IDAgNHB4IDAgI2YyZjJmNDtcbiAgICB3aWR0aDogMTAwJSAhaW1wb3J0YW50O1xuICAgIG1hcmdpbjogMCBhdXRvOyBcbiAgICBtYXJnaW4tdG9wOiAxLjVyZW07XG4gICAgbWFyZ2luLWJvdHRvbTogMS41cmVtO1xuICAgIGZvbnQtd2VpZ2h0OiAzMDA7XG4gICAgZm9udC1mYW1pbHk6IFwiT3BlbiBTYW5zXCIsc2Fucy1zZXJpZjtcbn1cbmJsb2NrcXVvdGUsIC5jb2x1bW4tYmxvY2sgYXBwLWJsb2NrIGJsb2NrcXVvdGV7XG4gICAgZGlzcGxheTogdGFibGUtY2VsbDtcbiAgICB2ZXJ0aWNhbC1hbGlnbjogYm90dG9tO1xufVxuXG4uVGV4dEJsb2NrIC5jb2x1bW4tYmxvY2sgYXBwLWJsb2NrIC5UZXh0QmxvY2sgeyAgICBcbiAgICBtYXgtd2lkdGg6IDY4JTsgXG4gICAgbWFyZ2luOiAwIGF1dG87IFxuICAgIG1hcmdpbi10b3A6IDEuNXJlbTtcbiAgICBtYXJnaW4tYm90dG9tOiAxLjVyZW07XG4gICAgdGV4dC1hbGlnbjogbGVmdDtcbiAgICBmb250LXdlaWdodDogNDAwO1xuICAgIGZvbnQtc2l6ZTogMXJlbTtcbiAgICBsaW5lLWhlaWdodDogMS41O1xuICAgIGZvbnQtZmFtaWx5OiBcIk9wZW4gU2Fuc1wiLHNhbnMtc2VyaWY7XG59XG5cbi5jb2x1bW4tYmxvY2sgLlRleHRCbG9jayB7XG4gICAgcGFkZGluZzogMXJlbTtcbn1cbi5jb2x1bW4tYmxvY2sgYXBwLWJsb2NrIHtcbiAgICBkaXNwbGF5OiBpbmxpbmU7ICAgIFxuICAgIHRleHQtYWxpZ246IGxlZnQ7XG4gICAgd2lkdGg6IDEwMCU7XG4gICAgbWFyZ2luLXJpZ2h0OiAxNXB4O1xuICAgIG1hcmdpbi1sZWZ0OiAxNXB4O1xuICAgIG1hcmdpbi10b3A6IDEuNXJlbTtcbn1cblxuLmNvbHVtbi1ibG9jayB7XG4gICAgbWF4LXdpZHRoOiA2NSU7XG4gICAgdGV4dC1hbGlnbjogY2VudGVyO1xuICAgIG1hcmdpbi10b3A6IDEuNXJlbTtcbiAgICBtYXJnaW4tYm90dG9tOiAxLjVyZW07XG4gICAgbWFyZ2luLWxlZnQ6IGF1dG87XG4gICAgbWFyZ2luLXJpZ2h0OiBhdXRvO1xuICAgIGRpc3BsYXk6IGZsZXg7XG4gICAgcGFkZGluZzogMXJlbTtcbn1cblxuLkltYWdlQmxvY2sgaW1nICB7XG4gICAgbWF4LXdpZHRoOiA2OCU7XG4gICAgZGlzcGxheTogYmxvY2s7XG4gICAgbWFyZ2luOiAwIGF1dG87XG4gICAgYm94LXNoYWRvdzogMCAycHggNHB4IDBweCByZ2JhKDAsIDAsIDAsIDAuMiksIDAgNHB4IDVweCAwIHJnYmEoMCwgMCwgMCwgMC4xNCksIDAgMXB4IDEwcHggMCByZ2JhKDAsIDAsIDAsIDAuMTIpO1xufVxuXG4uVGV4dEJsb2NrRGl2IC5UZXh0QmxvY2sge1xuICAgIG1pbi1oZWlnaHQ6IDEwMHB4O1xuICAgIHBhZGRpbmc6IDFyZW07XG4gICAgbWF4LXdpZHRoOiA2OCU7IFxuICAgIG1hcmdpbjogMCBhdXRvOyBcbiAgICBtYXJnaW4tdG9wOiAxLjVyZW07XG4gICAgbWFyZ2luLWJvdHRvbTogMS41cmVtO1xuICAgIHRleHQtYWxpZ246IGxlZnQ7XG4gICAgZm9udC13ZWlnaHQ6IDQwMDtcbiAgICBmb250LXNpemU6IDFyZW07XG4gICAgbGluZS1oZWlnaHQ6IDEuNTtcbiAgICBmb250LWZhbWlseTogXCJPcGVuIFNhbnNcIixzYW5zLXNlcmlmO1xufVxuXG4uVmlkZW9CbG9jaywgLkF1ZGlvQmxvY2ssIC5jb2x1bW4tYmxvY2sgYXBwLWJsb2NrIHtcbiAgICBtYXJnaW46IDAgYXV0bzsgXG4gICAgd2lkdGg6IDY4JTtcbiAgICBtYXJnaW4tdG9wOiAxLjVyZW07XG59XG5cbi5WaWRlb0Jsb2NrIHZpZGVvIHtcbiAgICB3aWR0aDogMTAwJTtcbiAgICBtYXJnaW4tdG9wOiAxLjVyZW07XG4gICAgbWFyZ2luLWJvdHRvbTogMS41cmVtO1xuICAgIGRpc3BsYXk6IGJsb2NrO1xuICAgIHZlcnRpY2FsLWFsaWduOiBtaWRkbGU7XG59XG5cbmRpdiAuSW1hZ2VCbG9jayB7XG4gICAgbWFyZ2luLXRvcDogMS41cmVtO1xuICAgIG1hcmdpbi1ib3R0b206IDEuNXJlbTtcbiAgICBtYXJnaW46IDAgYXV0bzsgXG59XG5cbi5BdWRpb0Jsb2NrIGF1ZGlvIHtcbiAgICBtYXgtd2lkdGg6IDUwJTtcbiAgICBtaW4td2lkdGg6IDE1MHB4O1xufVxuXG4uU2VwYXJhdG9yQmxvY2sgaHJ7XG4gICAgYm9yZGVyLXRvcDogMXB4IHNvbGlkIHJnYmEoMCwwLDAsLjEpO1xuICAgIG1hcmdpbi10b3A6IC41cmVtO1xuICAgIG1hcmdpbi1ib3R0b206IC41cmVtO1xuICAgIGJvcmRlci10b3AtY29sb3I6ICNlZWU7XG4gICAgbWF4LXdpZHRoOiA2OCU7XG59XG5cbi5TZXBhcmF0b3JCbG9jaywgLkh0bWxCbG9jayB7XG4gICAgbWFyZ2luOiAwIGF1dG87IFxuICAgIHdpZHRoOiA2OCU7XG59XG5cbi5IdG1sQmxvY2sge1xuICAgIGZvbnQtZmFtaWx5OiBcIk9wZW4gU2Fuc1wiLHNhbnMtc2VyaWY7XG4gICAgZm9udC1zaXplOiAxcmVtO1xuICAgIGZvbnQtd2VpZ2h0OiA0MDA7XG4gICAgbGluZS1oZWlnaHQ6IDEuNTtcbiAgICBjb2xvcjogIzIxMjUyOTtcbiAgICB0ZXh0LWFsaWduOiBsZWZ0O1xufVxuXG4jcXVvdGVCbG9jayB7XG4gICAgd2lkdGg6IDY4JTtcbiAgICBtYXJnaW46IDAgYXV0bztcbn1cblxuLkdhbGxlcnlCbG9jayB7XG4gICAgbWF4LXdpZHRoOiA0NSU7XG4gICAgbWFyZ2luOiAwIGF1dG87XG59IiwiLlF1b3RlQmxvY2ssXG4uY29sdW1uLWJsb2NrIGFwcC1ibG9jayAuUXVvdGVCbG9jayB7XG4gIGNvbG9yOiAjOTk5O1xuICBib3JkZXI6IDFweCBzb2xpZCAjZGRkO1xuICBwYWRkaW5nOiAxcmVtO1xuICBwYWRkaW5nLXRvcDogMS41cmVtO1xuICBmb250LXNpemU6IDEuMXJlbTtcbiAgYm94LXNoYWRvdzogMCA0cHggMCAjZjJmMmY0O1xuICB3aWR0aDogMTAwJSAhaW1wb3J0YW50O1xuICBtYXJnaW46IDAgYXV0bztcbiAgbWFyZ2luLXRvcDogMS41cmVtO1xuICBtYXJnaW4tYm90dG9tOiAxLjVyZW07XG4gIGZvbnQtd2VpZ2h0OiAzMDA7XG4gIGZvbnQtZmFtaWx5OiBcIk9wZW4gU2Fuc1wiLCBzYW5zLXNlcmlmO1xufVxuYmxvY2txdW90ZSxcbi5jb2x1bW4tYmxvY2sgYXBwLWJsb2NrIGJsb2NrcXVvdGUge1xuICBkaXNwbGF5OiB0YWJsZS1jZWxsO1xuICB2ZXJ0aWNhbC1hbGlnbjogYm90dG9tO1xufVxuLlRleHRCbG9jayAuY29sdW1uLWJsb2NrIGFwcC1ibG9jayAuVGV4dEJsb2NrIHtcbiAgbWF4LXdpZHRoOiA2OCU7XG4gIG1hcmdpbjogMCBhdXRvO1xuICBtYXJnaW4tdG9wOiAxLjVyZW07XG4gIG1hcmdpbi1ib3R0b206IDEuNXJlbTtcbiAgdGV4dC1hbGlnbjogbGVmdDtcbiAgZm9udC13ZWlnaHQ6IDQwMDtcbiAgZm9udC1zaXplOiAxcmVtO1xuICBsaW5lLWhlaWdodDogMS41O1xuICBmb250LWZhbWlseTogXCJPcGVuIFNhbnNcIiwgc2Fucy1zZXJpZjtcbn1cbi5jb2x1bW4tYmxvY2sgLlRleHRCbG9jayB7XG4gIHBhZGRpbmc6IDFyZW07XG59XG4uY29sdW1uLWJsb2NrIGFwcC1ibG9jayB7XG4gIGRpc3BsYXk6IGlubGluZTtcbiAgdGV4dC1hbGlnbjogbGVmdDtcbiAgd2lkdGg6IDEwMCU7XG4gIG1hcmdpbi1yaWdodDogMTVweDtcbiAgbWFyZ2luLWxlZnQ6IDE1cHg7XG4gIG1hcmdpbi10b3A6IDEuNXJlbTtcbn1cbi5jb2x1bW4tYmxvY2sge1xuICBtYXgtd2lkdGg6IDY1JTtcbiAgdGV4dC1hbGlnbjogY2VudGVyO1xuICBtYXJnaW4tdG9wOiAxLjVyZW07XG4gIG1hcmdpbi1ib3R0b206IDEuNXJlbTtcbiAgbWFyZ2luLWxlZnQ6IGF1dG87XG4gIG1hcmdpbi1yaWdodDogYXV0bztcbiAgZGlzcGxheTogZmxleDtcbiAgcGFkZGluZzogMXJlbTtcbn1cbi5JbWFnZUJsb2NrIGltZyB7XG4gIG1heC13aWR0aDogNjglO1xuICBkaXNwbGF5OiBibG9jaztcbiAgbWFyZ2luOiAwIGF1dG87XG4gIGJveC1zaGFkb3c6IDAgMnB4IDRweCAwcHggcmdiYSgwLCAwLCAwLCAwLjIpLCAwIDRweCA1cHggMCByZ2JhKDAsIDAsIDAsIDAuMTQpLCAwIDFweCAxMHB4IDAgcmdiYSgwLCAwLCAwLCAwLjEyKTtcbn1cbi5UZXh0QmxvY2tEaXYgLlRleHRCbG9jayB7XG4gIG1pbi1oZWlnaHQ6IDEwMHB4O1xuICBwYWRkaW5nOiAxcmVtO1xuICBtYXgtd2lkdGg6IDY4JTtcbiAgbWFyZ2luOiAwIGF1dG87XG4gIG1hcmdpbi10b3A6IDEuNXJlbTtcbiAgbWFyZ2luLWJvdHRvbTogMS41cmVtO1xuICB0ZXh0LWFsaWduOiBsZWZ0O1xuICBmb250LXdlaWdodDogNDAwO1xuICBmb250LXNpemU6IDFyZW07XG4gIGxpbmUtaGVpZ2h0OiAxLjU7XG4gIGZvbnQtZmFtaWx5OiBcIk9wZW4gU2Fuc1wiLCBzYW5zLXNlcmlmO1xufVxuLlZpZGVvQmxvY2ssXG4uQXVkaW9CbG9jayxcbi5jb2x1bW4tYmxvY2sgYXBwLWJsb2NrIHtcbiAgbWFyZ2luOiAwIGF1dG87XG4gIHdpZHRoOiA2OCU7XG4gIG1hcmdpbi10b3A6IDEuNXJlbTtcbn1cbi5WaWRlb0Jsb2NrIHZpZGVvIHtcbiAgd2lkdGg6IDEwMCU7XG4gIG1hcmdpbi10b3A6IDEuNXJlbTtcbiAgbWFyZ2luLWJvdHRvbTogMS41cmVtO1xuICBkaXNwbGF5OiBibG9jaztcbiAgdmVydGljYWwtYWxpZ246IG1pZGRsZTtcbn1cbmRpdiAuSW1hZ2VCbG9jayB7XG4gIG1hcmdpbi10b3A6IDEuNXJlbTtcbiAgbWFyZ2luLWJvdHRvbTogMS41cmVtO1xuICBtYXJnaW46IDAgYXV0bztcbn1cbi5BdWRpb0Jsb2NrIGF1ZGlvIHtcbiAgbWF4LXdpZHRoOiA1MCU7XG4gIG1pbi13aWR0aDogMTUwcHg7XG59XG4uU2VwYXJhdG9yQmxvY2sgaHIge1xuICBib3JkZXItdG9wOiAxcHggc29saWQgcmdiYSgwLCAwLCAwLCAwLjEpO1xuICBtYXJnaW4tdG9wOiAwLjVyZW07XG4gIG1hcmdpbi1ib3R0b206IDAuNXJlbTtcbiAgYm9yZGVyLXRvcC1jb2xvcjogI2VlZTtcbiAgbWF4LXdpZHRoOiA2OCU7XG59XG4uU2VwYXJhdG9yQmxvY2ssXG4uSHRtbEJsb2NrIHtcbiAgbWFyZ2luOiAwIGF1dG87XG4gIHdpZHRoOiA2OCU7XG59XG4uSHRtbEJsb2NrIHtcbiAgZm9udC1mYW1pbHk6IFwiT3BlbiBTYW5zXCIsIHNhbnMtc2VyaWY7XG4gIGZvbnQtc2l6ZTogMXJlbTtcbiAgZm9udC13ZWlnaHQ6IDQwMDtcbiAgbGluZS1oZWlnaHQ6IDEuNTtcbiAgY29sb3I6ICMyMTI1Mjk7XG4gIHRleHQtYWxpZ246IGxlZnQ7XG59XG4jcXVvdGVCbG9jayB7XG4gIHdpZHRoOiA2OCU7XG4gIG1hcmdpbjogMCBhdXRvO1xufVxuLkdhbGxlcnlCbG9jayB7XG4gIG1heC13aWR0aDogNDUlO1xuICBtYXJnaW46IDAgYXV0bztcbn1cbiJdfQ== */");

/***/ }),

/***/ "./src/app/modules/cms-generic/components/block/block.component.ts":
/*!*************************************************************************!*\
  !*** ./src/app/modules/cms-generic/components/block/block.component.ts ***!
  \*************************************************************************/
/*! exports provided: BlockComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "BlockComponent", function() { return BlockComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let BlockComponent = class BlockComponent {
    constructor() { }
    cutLink() {
        return this.model.body.media.publicUrl.substr(1);
    }
};
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])()
], BlockComponent.prototype, "model", void 0);
BlockComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: "app-block",
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./block.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/cms-generic/components/block/block.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./block.component.less */ "./src/app/modules/cms-generic/components/block/block.component.less")).default]
    })
], BlockComponent);



/***/ }),

/***/ "./src/app/modules/cms-generic/components/cms-generic-page/cms-generic-page.component.less":
/*!*************************************************************************************************!*\
  !*** ./src/app/modules/cms-generic/components/cms-generic-page/cms-generic-page.component.less ***!
  \*************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL21vZHVsZXMvY21zLWdlbmVyaWMvY29tcG9uZW50cy9jbXMtZ2VuZXJpYy1wYWdlL2Ntcy1nZW5lcmljLXBhZ2UuY29tcG9uZW50Lmxlc3MifQ== */");

/***/ }),

/***/ "./src/app/modules/cms-generic/components/cms-generic-page/cms-generic-page.component.ts":
/*!***********************************************************************************************!*\
  !*** ./src/app/modules/cms-generic/components/cms-generic-page/cms-generic-page.component.ts ***!
  \***********************************************************************************************/
/*! exports provided: CmsGenericPageComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CmsGenericPageComponent", function() { return CmsGenericPageComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _core_services_cms_cms_route_helper_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../../core/services/cms/cms-route-helper.service */ "./src/app/core/services/cms/cms-route-helper.service.ts");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm2015/index.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");





let CmsGenericPageComponent = class CmsGenericPageComponent {
    constructor(cmsRouteHelperService, router) {
        this.cmsRouteHelperService = cmsRouteHelperService;
        this.router = router;
        this.subscription = new rxjs__WEBPACK_IMPORTED_MODULE_3__["Subscription"]();
    }
    ngOnInit() {
        this.subscribeOnCmsRouteChange();
        if (!this.cmsRoute) {
            this.cmsRouteHelperService.updateRouteByPath(this.router.url);
        }
    }
    ngOnDestroy() {
        this.subscription.unsubscribe();
    }
    subscribeOnCmsRouteChange() {
        const subscription = this.cmsRouteHelperService.currentRouteSubject.subscribe(next => {
            this.cmsRoute = next;
        });
        this.subscription.add(subscription);
    }
};
CmsGenericPageComponent.ctorParameters = () => [
    { type: _core_services_cms_cms_route_helper_service__WEBPACK_IMPORTED_MODULE_2__["CmsRouteHelperService"] },
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_4__["Router"] }
];
CmsGenericPageComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: "app-cms-generic-page",
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./cms-generic-page.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/cms-generic/components/cms-generic-page/cms-generic-page.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./cms-generic-page.component.less */ "./src/app/modules/cms-generic/components/cms-generic-page/cms-generic-page.component.less")).default]
    })
], CmsGenericPageComponent);



/***/ }),

/***/ "./src/app/modules/cms-generic/components/gallery-block/gallery-block.component.less":
/*!*******************************************************************************************!*\
  !*** ./src/app/modules/cms-generic/components/gallery-block/gallery-block.component.less ***!
  \*******************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".picsum-img-wrapper img {\n  width: 100%!important;\n  display: block!important;\n  max-width: 100%;\n  vertical-align: middle;\n  border-style: none;\n  box-sizing: border-box;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvbW9kdWxlcy9jbXMtZ2VuZXJpYy9jb21wb25lbnRzL2dhbGxlcnktYmxvY2svQzovRG9jdW1lbnRzL0dpdEh1Yi93aXRob3V0IFBpcmFuaGEvVGhlcmFMYW5nL1RoZXJhTGFuZy5XZWIvQ2xpZW50QXBwL3NyYy9hcHAvbW9kdWxlcy9jbXMtZ2VuZXJpYy9jb21wb25lbnRzL2dhbGxlcnktYmxvY2svZ2FsbGVyeS1ibG9jay5jb21wb25lbnQubGVzcyIsInNyYy9hcHAvbW9kdWxlcy9jbXMtZ2VuZXJpYy9jb21wb25lbnRzL2dhbGxlcnktYmxvY2svZ2FsbGVyeS1ibG9jay5jb21wb25lbnQubGVzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQTtFQUNJLHFCQUFBO0VBQ0Esd0JBQUE7RUFDQSxlQUFBO0VBQ0Esc0JBQUE7RUFDQSxrQkFBQTtFQUNBLHNCQUFBO0FDQ0oiLCJmaWxlIjoic3JjL2FwcC9tb2R1bGVzL2Ntcy1nZW5lcmljL2NvbXBvbmVudHMvZ2FsbGVyeS1ibG9jay9nYWxsZXJ5LWJsb2NrLmNvbXBvbmVudC5sZXNzIiwic291cmNlc0NvbnRlbnQiOlsiLnBpY3N1bS1pbWctd3JhcHBlciBpbWcge1xuICAgIHdpZHRoOiAxMDAlIWltcG9ydGFudDtcbiAgICBkaXNwbGF5OiBibG9jayFpbXBvcnRhbnQ7XG4gICAgbWF4LXdpZHRoOiAxMDAlO1xuICAgIHZlcnRpY2FsLWFsaWduOiBtaWRkbGU7XG4gICAgYm9yZGVyLXN0eWxlOiBub25lO1xuICAgIGJveC1zaXppbmc6IGJvcmRlci1ib3g7XG59ICIsIi5waWNzdW0taW1nLXdyYXBwZXIgaW1nIHtcbiAgd2lkdGg6IDEwMCUhaW1wb3J0YW50O1xuICBkaXNwbGF5OiBibG9jayFpbXBvcnRhbnQ7XG4gIG1heC13aWR0aDogMTAwJTtcbiAgdmVydGljYWwtYWxpZ246IG1pZGRsZTtcbiAgYm9yZGVyLXN0eWxlOiBub25lO1xuICBib3gtc2l6aW5nOiBib3JkZXItYm94O1xufVxuIl19 */");

/***/ }),

/***/ "./src/app/modules/cms-generic/components/gallery-block/gallery-block.component.ts":
/*!*****************************************************************************************!*\
  !*** ./src/app/modules/cms-generic/components/gallery-block/gallery-block.component.ts ***!
  \*****************************************************************************************/
/*! exports provided: GalleryBlockComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "GalleryBlockComponent", function() { return GalleryBlockComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let GalleryBlockComponent = class GalleryBlockComponent {
    constructor() { }
    cutLink(url) {
        return url.substr(1);
    }
};
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])()
], GalleryBlockComponent.prototype, "block", void 0);
GalleryBlockComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: "app-gallery-block",
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./gallery-block.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/cms-generic/components/gallery-block/gallery-block.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./gallery-block.component.less */ "./src/app/modules/cms-generic/components/gallery-block/gallery-block.component.less")).default]
    })
], GalleryBlockComponent);



/***/ }),

/***/ "./src/app/modules/cms-generic/components/piranha-page/piranha-page.component.less":
/*!*****************************************************************************************!*\
  !*** ./src/app/modules/cms-generic/components/piranha-page/piranha-page.component.less ***!
  \*****************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL21vZHVsZXMvY21zLWdlbmVyaWMvY29tcG9uZW50cy9waXJhbmhhLXBhZ2UvcGlyYW5oYS1wYWdlLmNvbXBvbmVudC5sZXNzIn0= */");

/***/ }),

/***/ "./src/app/modules/cms-generic/components/piranha-page/piranha-page.component.ts":
/*!***************************************************************************************!*\
  !*** ./src/app/modules/cms-generic/components/piranha-page/piranha-page.component.ts ***!
  \***************************************************************************************/
/*! exports provided: PiranhaPageComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PiranhaPageComponent", function() { return PiranhaPageComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _core_http_cms_cms_page_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../../core/http/cms/cms-page.service */ "./src/app/core/http/cms/cms-page.service.ts");



let PiranhaPageComponent = class PiranhaPageComponent {
    constructor(cmsPageService) {
        this.cmsPageService = cmsPageService;
        this.ifGenerate = false;
    }
    ngOnInit() {
        return tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            this.page = yield this.cmsPageService.getPiranhaPageById(this.cmsRoute.id);
            this.ifGenerate = true;
        });
    }
};
PiranhaPageComponent.ctorParameters = () => [
    { type: _core_http_cms_cms_page_service__WEBPACK_IMPORTED_MODULE_2__["CmsPageService"] }
];
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])()
], PiranhaPageComponent.prototype, "cmsRoute", void 0);
PiranhaPageComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: "app-piranha-page",
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./piranha-page.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/cms-generic/components/piranha-page/piranha-page.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./piranha-page.component.less */ "./src/app/modules/cms-generic/components/piranha-page/piranha-page.component.less")).default]
    })
], PiranhaPageComponent);



/***/ }),

/***/ "./src/app/modules/login/login.component.less":
/*!****************************************************!*\
  !*** ./src/app/modules/login/login.component.less ***!
  \****************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (":host {\n  height: 100%;\n  display: flex;\n  align-items: center;\n  justify-content: center;\n  background-image: url(\"/assets/img/background.png\");\n  background-size: cover;\n}\n.mat-form-field {\n  width: 100%;\n  min-width: 200px;\n  justify-content: floor;\n}\n.back-img {\n  margin-top: 20px;\n  margin-left: 20px;\n  display: flex;\n  justify-content: center;\n}\nmat-card {\n  width: 400px;\n  height: 470px;\n}\n@media screen and (max-width: 750px) {\n  .mat-card {\n    box-shadow: 0px 0px 0px 0px;\n  }\n  :host {\n    background-image: none;\n  }\n}\nmat-card-title {\n  display: flex;\n  justify-content: center;\n}\nmat-card-content {\n  display: flex;\n  justify-content: center;\n  margin: 20px;\n}\n.button {\n  display: flex;\n  justify-content: center ;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvbW9kdWxlcy9sb2dpbi9DOi9Eb2N1bWVudHMvR2l0SHViL3dpdGhvdXQgUGlyYW5oYS9UaGVyYUxhbmcvVGhlcmFMYW5nLldlYi9DbGllbnRBcHAvc3JjL2FwcC9tb2R1bGVzL2xvZ2luL2xvZ2luLmNvbXBvbmVudC5sZXNzIiwic3JjL2FwcC9tb2R1bGVzL2xvZ2luL2xvZ2luLmNvbXBvbmVudC5sZXNzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0UsWUFBQTtFQUNBLGFBQUE7RUFDQSxtQkFBQTtFQUNBLHVCQUFBO0VBQ0EsbURBQUE7RUFDQSxzQkFBQTtBQ0NGO0FERUE7RUFDRSxXQUFBO0VBQ0EsZ0JBQUE7RUFDQSxzQkFBQTtBQ0FGO0FER0E7RUFDRSxnQkFBQTtFQUNBLGlCQUFBO0VBQ0EsYUFBQTtFQUNBLHVCQUFBO0FDREY7QURJQTtFQUVFLFlBQUE7RUFDQSxhQUFBO0FDSEY7QURNQTtFQUNFO0lBQ0UsMkJBQUE7RUNKRjtFRE1BO0lBQ0Usc0JBQUE7RUNKRjtBQUNGO0FET0E7RUFDRSxhQUFBO0VBQ0EsdUJBQUE7QUNMRjtBRFFBO0VBQ0UsYUFBQTtFQUNBLHVCQUFBO0VBQ0EsWUFBQTtBQ05GO0FEU0E7RUFDRSxhQUFBO0VBQ0Esd0JBQUE7QUNQRiIsImZpbGUiOiJzcmMvYXBwL21vZHVsZXMvbG9naW4vbG9naW4uY29tcG9uZW50Lmxlc3MiLCJzb3VyY2VzQ29udGVudCI6WyI6aG9zdCB7XG4gIGhlaWdodDogMTAwJTtcbiAgZGlzcGxheTogZmxleDtcbiAgYWxpZ24taXRlbXM6IGNlbnRlcjtcbiAganVzdGlmeS1jb250ZW50OiBjZW50ZXI7XG4gIGJhY2tncm91bmQtaW1hZ2U6IHVybChcIi9hc3NldHMvaW1nL2JhY2tncm91bmQucG5nXCIpO1xuICBiYWNrZ3JvdW5kLXNpemU6IGNvdmVyO1xufVxuXG4ubWF0LWZvcm0tZmllbGQge1xuICB3aWR0aDogMTAwJTtcbiAgbWluLXdpZHRoOiAyMDBweDtcbiAganVzdGlmeS1jb250ZW50OiBmbG9vcjtcbn1cblxuLmJhY2staW1ne1xuICBtYXJnaW4tdG9wOiAyMHB4O1xuICBtYXJnaW4tbGVmdDogMjBweDtcbiAgZGlzcGxheTogZmxleDtcbiAganVzdGlmeS1jb250ZW50OiBjZW50ZXI7XG59XG5cbm1hdC1jYXJkeyAgIFxuICBcbiAgd2lkdGg6IDQwMHB4OyAgICBcbiAgaGVpZ2h0OiA0NzBweDsgXG59XG5cbkBtZWRpYSBzY3JlZW4gYW5kIChtYXgtd2lkdGg6IDc1MHB4KSB7XG4gIC5tYXQtY2FyZCB7XG4gICAgYm94LXNoYWRvdzogMHB4IDBweCAwcHggMHB4ICBcbiAgfVxuICA6aG9zdCB7XG4gICAgYmFja2dyb3VuZC1pbWFnZTogbm9uZTtcbiAgfVxufVxuXG5tYXQtY2FyZC10aXRsZSB7XG4gIGRpc3BsYXk6IGZsZXg7XG4gIGp1c3RpZnktY29udGVudDogY2VudGVyO1xufVxuXG5tYXQtY2FyZC1jb250ZW50IHtcbiAgZGlzcGxheTogZmxleDtcbiAganVzdGlmeS1jb250ZW50OiBjZW50ZXI7XG4gIG1hcmdpbjogMjBweDtcbn1cblxuLmJ1dHRvbiB7XG4gIGRpc3BsYXk6IGZsZXg7XG4gIGp1c3RpZnktY29udGVudDogY2VudGVyIDtcbn0iLCI6aG9zdCB7XG4gIGhlaWdodDogMTAwJTtcbiAgZGlzcGxheTogZmxleDtcbiAgYWxpZ24taXRlbXM6IGNlbnRlcjtcbiAganVzdGlmeS1jb250ZW50OiBjZW50ZXI7XG4gIGJhY2tncm91bmQtaW1hZ2U6IHVybChcIi9hc3NldHMvaW1nL2JhY2tncm91bmQucG5nXCIpO1xuICBiYWNrZ3JvdW5kLXNpemU6IGNvdmVyO1xufVxuLm1hdC1mb3JtLWZpZWxkIHtcbiAgd2lkdGg6IDEwMCU7XG4gIG1pbi13aWR0aDogMjAwcHg7XG4gIGp1c3RpZnktY29udGVudDogZmxvb3I7XG59XG4uYmFjay1pbWcge1xuICBtYXJnaW4tdG9wOiAyMHB4O1xuICBtYXJnaW4tbGVmdDogMjBweDtcbiAgZGlzcGxheTogZmxleDtcbiAganVzdGlmeS1jb250ZW50OiBjZW50ZXI7XG59XG5tYXQtY2FyZCB7XG4gIHdpZHRoOiA0MDBweDtcbiAgaGVpZ2h0OiA0NzBweDtcbn1cbkBtZWRpYSBzY3JlZW4gYW5kIChtYXgtd2lkdGg6IDc1MHB4KSB7XG4gIC5tYXQtY2FyZCB7XG4gICAgYm94LXNoYWRvdzogMHB4IDBweCAwcHggMHB4O1xuICB9XG4gIDpob3N0IHtcbiAgICBiYWNrZ3JvdW5kLWltYWdlOiBub25lO1xuICB9XG59XG5tYXQtY2FyZC10aXRsZSB7XG4gIGRpc3BsYXk6IGZsZXg7XG4gIGp1c3RpZnktY29udGVudDogY2VudGVyO1xufVxubWF0LWNhcmQtY29udGVudCB7XG4gIGRpc3BsYXk6IGZsZXg7XG4gIGp1c3RpZnktY29udGVudDogY2VudGVyO1xuICBtYXJnaW46IDIwcHg7XG59XG4uYnV0dG9uIHtcbiAgZGlzcGxheTogZmxleDtcbiAganVzdGlmeS1jb250ZW50OiBjZW50ZXIgO1xufVxuIl19 */");

/***/ }),

/***/ "./src/app/modules/login/login.component.ts":
/*!**************************************************!*\
  !*** ./src/app/modules/login/login.component.ts ***!
  \**************************************************/
/*! exports provided: LoginComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LoginComponent", function() { return LoginComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _core_auth_user_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../core/auth/user.service */ "./src/app/core/auth/user.service.ts");
/* harmony import */ var _ngx_translate_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @ngx-translate/core */ "./node_modules/@ngx-translate/core/fesm2015/ngx-translate-core.js");
/* harmony import */ var src_app_core_services_notification_notification_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! src/app/core/services/notification/notification.service */ "./src/app/core/services/notification/notification.service.ts");
/* harmony import */ var src_app_core_services_dialog_dialog_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! src/app/core/services/dialog/dialog.service */ "./src/app/core/services/dialog/dialog.service.ts");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");







let LoginComponent = class LoginComponent {
    constructor(notificationService, dialog, userService, translate, router) {
        this.notificationService = notificationService;
        this.dialog = dialog;
        this.userService = userService;
        this.translate = translate;
        this.router = router;
        this.hide = true;
    }
    ngOnInit() { }
    onSubmit() {
        this.userService.login(this.userService.loginForm.value).subscribe(response => {
            let token = response.token;
            localStorage.setItem("jwt", token);
            this.invalidLogin = false;
            this.router.navigate(["/"]);
        }, err => {
            console.log(err);
            this.invalidLogin = true;
        });
    }
    onClose() {
        this.userService.loginForm.reset();
        this.dialog.closeDialogs();
    }
};
LoginComponent.ctorParameters = () => [
    { type: src_app_core_services_notification_notification_service__WEBPACK_IMPORTED_MODULE_4__["NotificationService"] },
    { type: src_app_core_services_dialog_dialog_service__WEBPACK_IMPORTED_MODULE_5__["DialogService"] },
    { type: _core_auth_user_service__WEBPACK_IMPORTED_MODULE_2__["UserService"] },
    { type: _ngx_translate_core__WEBPACK_IMPORTED_MODULE_3__["TranslateService"] },
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_6__["Router"] }
];
LoginComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: "app-login",
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./login.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/login/login.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./login.component.less */ "./src/app/modules/login/login.component.less")).default]
    })
], LoginComponent);



/***/ }),

/***/ "./src/app/modules/main/main.component.less":
/*!**************************************************!*\
  !*** ./src/app/modules/main/main.component.less ***!
  \**************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".app-container {\n  height: 100%;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvbW9kdWxlcy9tYWluL0M6L0RvY3VtZW50cy9HaXRIdWIvd2l0aG91dCBQaXJhbmhhL1RoZXJhTGFuZy9UaGVyYUxhbmcuV2ViL0NsaWVudEFwcC9zcmMvYXBwL21vZHVsZXMvbWFpbi9tYWluLmNvbXBvbmVudC5sZXNzIiwic3JjL2FwcC9tb2R1bGVzL21haW4vbWFpbi5jb21wb25lbnQubGVzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQTtFQUNFLFlBQUE7QUNDRiIsImZpbGUiOiJzcmMvYXBwL21vZHVsZXMvbWFpbi9tYWluLmNvbXBvbmVudC5sZXNzIiwic291cmNlc0NvbnRlbnQiOlsiLmFwcC1jb250YWluZXIge1xuICBoZWlnaHQ6IDEwMCU7XG59IiwiLmFwcC1jb250YWluZXIge1xuICBoZWlnaHQ6IDEwMCU7XG59XG4iXX0= */");

/***/ }),

/***/ "./src/app/modules/main/main.component.ts":
/*!************************************************!*\
  !*** ./src/app/modules/main/main.component.ts ***!
  \************************************************/
/*! exports provided: MainComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "MainComponent", function() { return MainComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let MainComponent = class MainComponent {
    constructor() { }
    ngOnInit() {
    }
};
MainComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-main',
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./main.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/main.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./main.component.less */ "./src/app/modules/main/main.component.less")).default]
    })
], MainComponent);



/***/ }),

/***/ "./src/app/modules/main/pages/donation/donation.component.less":
/*!*********************************************************************!*\
  !*** ./src/app/modules/main/pages/donation/donation.component.less ***!
  \*********************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".mat-button {\n  background-color: #6db401;\n  color: white;\n  margin-left: 15px;\n}\n.form-field {\n  width: 200px;\n  margin-bottom: 15px;\n  margin-left: 15px;\n}\n.donation-header {\n  margin-left: 15px;\n}\n::ng-deep .mat-form-field-appearance-legacy .mat-form-field-underline {\n  background-color: purple;\n}\n.payment-methods {\n  width: 30%;\n  height: 15%;\n  margin-top: 13%;\n}\n.organization-donation-header {\n  margin-left: 15px;\n}\n.donated {\n  margin-left: 15px;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL2RvbmF0aW9uL0M6L0RvY3VtZW50cy9HaXRIdWIvd2l0aG91dCBQaXJhbmhhL1RoZXJhTGFuZy9UaGVyYUxhbmcuV2ViL0NsaWVudEFwcC9zcmMvYXBwL21vZHVsZXMvbWFpbi9wYWdlcy9kb25hdGlvbi9kb25hdGlvbi5jb21wb25lbnQubGVzcyIsInNyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL2RvbmF0aW9uL2RvbmF0aW9uLmNvbXBvbmVudC5sZXNzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0kseUJBQUE7RUFDQSxZQUFBO0VBQ0EsaUJBQUE7QUNDSjtBREVBO0VBQ0ksWUFBQTtFQUNBLG1CQUFBO0VBQ0EsaUJBQUE7QUNBSjtBREdBO0VBQ0ksaUJBQUE7QUNESjtBRElBO0VBQ0ksd0JBQUE7QUNGSjtBREtBO0VBQ0ksVUFBQTtFQUNBLFdBQUE7RUFDQSxlQUFBO0FDSEo7QURNQTtFQUNJLGlCQUFBO0FDSko7QURPQTtFQUNJLGlCQUFBO0FDTEoiLCJmaWxlIjoic3JjL2FwcC9tb2R1bGVzL21haW4vcGFnZXMvZG9uYXRpb24vZG9uYXRpb24uY29tcG9uZW50Lmxlc3MiLCJzb3VyY2VzQ29udGVudCI6WyIubWF0LWJ1dHRvbiB7XG4gICAgYmFja2dyb3VuZC1jb2xvcjogcmdiKDEwOSwgMTgwLCAxKTtcbiAgICBjb2xvciAgICAgICAgICAgOiB3aGl0ZTtcbiAgICBtYXJnaW4tbGVmdDogMTVweDtcbn1cblxuLmZvcm0tZmllbGQge1xuICAgIHdpZHRoICAgICAgICA6IDIwMHB4O1xuICAgIG1hcmdpbi1ib3R0b206IDE1cHg7XG4gICAgbWFyZ2luLWxlZnQ6IDE1cHg7XG59XG5cbi5kb25hdGlvbi1oZWFkZXIge1xuICAgIG1hcmdpbi1sZWZ0OiAxNXB4O1xufVxuXG46Om5nLWRlZXAgLm1hdC1mb3JtLWZpZWxkLWFwcGVhcmFuY2UtbGVnYWN5IC5tYXQtZm9ybS1maWVsZC11bmRlcmxpbmUge1xuICAgIGJhY2tncm91bmQtY29sb3I6IHB1cnBsZTtcbn1cblxuLnBheW1lbnQtbWV0aG9kc3tcbiAgICB3aWR0aDogMzAlO1xuICAgIGhlaWdodDogMTUlO1xuICAgIG1hcmdpbi10b3A6IDEzJTtcbn1cblxuLm9yZ2FuaXphdGlvbi1kb25hdGlvbi1oZWFkZXJ7XG4gICAgbWFyZ2luLWxlZnQ6IDE1cHg7XG59XG5cbi5kb25hdGVkIHtcbiAgICBtYXJnaW4tbGVmdDogMTVweDtcbn0iLCIubWF0LWJ1dHRvbiB7XG4gIGJhY2tncm91bmQtY29sb3I6ICM2ZGI0MDE7XG4gIGNvbG9yOiB3aGl0ZTtcbiAgbWFyZ2luLWxlZnQ6IDE1cHg7XG59XG4uZm9ybS1maWVsZCB7XG4gIHdpZHRoOiAyMDBweDtcbiAgbWFyZ2luLWJvdHRvbTogMTVweDtcbiAgbWFyZ2luLWxlZnQ6IDE1cHg7XG59XG4uZG9uYXRpb24taGVhZGVyIHtcbiAgbWFyZ2luLWxlZnQ6IDE1cHg7XG59XG46Om5nLWRlZXAgLm1hdC1mb3JtLWZpZWxkLWFwcGVhcmFuY2UtbGVnYWN5IC5tYXQtZm9ybS1maWVsZC11bmRlcmxpbmUge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiBwdXJwbGU7XG59XG4ucGF5bWVudC1tZXRob2RzIHtcbiAgd2lkdGg6IDMwJTtcbiAgaGVpZ2h0OiAxNSU7XG4gIG1hcmdpbi10b3A6IDEzJTtcbn1cbi5vcmdhbml6YXRpb24tZG9uYXRpb24taGVhZGVyIHtcbiAgbWFyZ2luLWxlZnQ6IDE1cHg7XG59XG4uZG9uYXRlZCB7XG4gIG1hcmdpbi1sZWZ0OiAxNXB4O1xufVxuIl19 */");

/***/ }),

/***/ "./src/app/modules/main/pages/donation/donation.component.ts":
/*!*******************************************************************!*\
  !*** ./src/app/modules/main/pages/donation/donation.component.ts ***!
  \*******************************************************************/
/*! exports provided: DonationComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "DonationComponent", function() { return DonationComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _core_http_donations_donation_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../../core/http/donations/donation.service */ "./src/app/core/http/donations/donation.service.ts");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var src_app_configs_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! src/app/configs/api-endpoint.constants */ "./src/app/configs/api-endpoint.constants.ts");





let DonationComponent = class DonationComponent {
    constructor(donationService, route) {
        this.donationService = donationService;
        this.route = route;
    }
    ngOnInit() {
        this.route.paramMap.subscribe(params => {
            this.projectId = +params.get("projectId");
        });
    }
    checkout() {
        if (this.projectId !== 0) {
            this.donationService
                .getProjectCheckoutModel(this.donationAmount, this.projectId)
                .subscribe((checkoutModel) => {
                this.donationModel = checkoutModel;
                window.location.replace(`${src_app_configs_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_4__["liqpayCheckoutUrl"]}?data=${this.donationModel.data}&signature=${this.donationModel.signature}`);
            });
        }
        else {
            this.donationService
                .getSocietyCheckoutModel(this.donationAmount)
                .subscribe((checkoutModel) => {
                this.donationModel = checkoutModel;
                window.location.replace(`${src_app_configs_api_endpoint_constants__WEBPACK_IMPORTED_MODULE_4__["liqpayCheckoutUrl"]}?data=${this.donationModel.data}&signature=${this.donationModel.signature}`);
            });
        }
    }
};
DonationComponent.ctorParameters = () => [
    { type: _core_http_donations_donation_service__WEBPACK_IMPORTED_MODULE_2__["DonationService"] },
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_3__["ActivatedRoute"] }
];
DonationComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: "app-donation",
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./donation.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/donation/donation.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./donation.component.less */ "./src/app/modules/main/pages/donation/donation.component.less")).default]
    })
], DonationComponent);



/***/ }),

/***/ "./src/app/modules/main/pages/home/home.component.less":
/*!*************************************************************!*\
  !*** ./src/app/modules/main/pages/home/home.component.less ***!
  \*************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL21vZHVsZXMvbWFpbi9wYWdlcy9ob21lL2hvbWUuY29tcG9uZW50Lmxlc3MifQ== */");

/***/ }),

/***/ "./src/app/modules/main/pages/home/home.component.ts":
/*!***********************************************************!*\
  !*** ./src/app/modules/main/pages/home/home.component.ts ***!
  \***********************************************************/
/*! exports provided: HomeComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "HomeComponent", function() { return HomeComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let HomeComponent = class HomeComponent {
    constructor() { }
    ngOnInit() {
    }
};
HomeComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-home',
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./home.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/home/home.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./home.component.less */ "./src/app/modules/main/pages/home/home.component.less")).default]
    })
], HomeComponent);



/***/ }),

/***/ "./src/app/modules/main/pages/project/days-left.pipe.ts":
/*!**************************************************************!*\
  !*** ./src/app/modules/main/pages/project/days-left.pipe.ts ***!
  \**************************************************************/
/*! exports provided: DaysLeftPipe */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "DaysLeftPipe", function() { return DaysLeftPipe; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let DaysLeftPipe = class DaysLeftPipe {
    transform(project) {
        let endDate = new Date(project.projectEnd);
        let timeLeft = endDate.getTime() - Date.now();
        if (timeLeft <= 0)
            return "Expired";
        let daysLeft = Math.ceil(timeLeft / (1000 * 3600 * 24));
        return daysLeft;
    }
};
DaysLeftPipe = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Pipe"])({
        name: 'daysLeft'
    })
], DaysLeftPipe);



/***/ }),

/***/ "./src/app/modules/main/pages/project/project-form/project-form.component.less":
/*!*************************************************************************************!*\
  !*** ./src/app/modules/main/pages/project/project-form/project-form.component.less ***!
  \*************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL21vZHVsZXMvbWFpbi9wYWdlcy9wcm9qZWN0L3Byb2plY3QtZm9ybS9wcm9qZWN0LWZvcm0uY29tcG9uZW50Lmxlc3MifQ== */");

/***/ }),

/***/ "./src/app/modules/main/pages/project/project-form/project-form.component.ts":
/*!***********************************************************************************!*\
  !*** ./src/app/modules/main/pages/project/project-form/project-form.component.ts ***!
  \***********************************************************************************/
/*! exports provided: ProjectFormComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectFormComponent", function() { return ProjectFormComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm2015/material.js");
/* harmony import */ var _core_http_project_project_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../../../../core/http/project/project.service */ "./src/app/core/http/project/project.service.ts");
/* harmony import */ var _ngx_translate_core__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @ngx-translate/core */ "./node_modules/@ngx-translate/core/fesm2015/ngx-translate-core.js");





let ProjectFormComponent = class ProjectFormComponent {
    constructor(dialog, service, dateAdapter, translate) {
        this.dialog = dialog;
        this.service = service;
        this.dateAdapter = dateAdapter;
        this.translate = translate;
    }
    ngOnInit() {
        this.dateAdapter.setLocale(this.translate.currentLang),
            (this.dateAdapter.getFirstDayOfWeek = () => {
                return 1;
            }),
            this.service
                .getProjectTypes()
                .subscribe((projectTypes) => (this.projectTypes = projectTypes));
    }
    onClose() {
        this.service.form.reset();
        this.service.initializeFormGroup();
        this.dialog.close();
    }
    onSubmit() {
        if (this.service.form.invalid) {
            const controls = this.service.form.controls;
            Object.keys(controls).forEach(controlName => controls[controlName].markAsTouched());
            return;
        }
        else if (!this.service.form.get("id").value) {
            this.service.addProject(this.service.form.value);
            this.onClose();
        }
        else {
            this.service.editProject(this.service.form.value);
            this.onClose();
        }
    }
};
ProjectFormComponent.ctorParameters = () => [
    { type: _angular_material__WEBPACK_IMPORTED_MODULE_2__["MatDialogRef"] },
    { type: _core_http_project_project_service__WEBPACK_IMPORTED_MODULE_3__["ProjectService"] },
    { type: _angular_material__WEBPACK_IMPORTED_MODULE_2__["DateAdapter"] },
    { type: _ngx_translate_core__WEBPACK_IMPORTED_MODULE_4__["TranslateService"] }
];
ProjectFormComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: "app-create-project",
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./project-form.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-form/project-form.component.html")).default,
        providers: [_core_http_project_project_service__WEBPACK_IMPORTED_MODULE_3__["ProjectService"]],
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./project-form.component.less */ "./src/app/modules/main/pages/project/project-form/project-form.component.less")).default]
    })
], ProjectFormComponent);



/***/ }),

/***/ "./src/app/modules/main/pages/project/project-info/project-info.component.less":
/*!*************************************************************************************!*\
  !*** ./src/app/modules/main/pages/project/project-info/project-info.component.less ***!
  \*************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".example-card {\n  max-width: 1200px;\n  margin: 0 auto;\n  background-color: gray;\n}\n#resTabId {\n  max-width: 1230px;\n  margin: 0 auto;\n  min-height: 20rem;\n}\napp-resources-table .resTab {\n  border-radius: 25px;\n}\n.example-header-image {\n  background-image: url('trashcat.jpg');\n  background-size: cover;\n}\n.mat-card-header .mat-card-avatar {\n  display: block;\n}\nmat-card-header .mat-card-header-text {\n  margin-top: 10px;\n}\n.description {\n  text-align: center;\n}\n.mat-tab-label {\n  color: black;\n  min-width: 0px !important;\n}\n.mat-card-avatar {\n  width: 4rem !important;\n  height: 4rem !important;\n  margin-bottom: 1rem;\n}\n.bottom-buttons {\n  max-width: 1230px;\n  text-align: right;\n  margin-left: auto;\n  margin-top: 1rem;\n  margin-bottom: 1rem;\n  margin-right: auto;\n  border-radius: 25px;\n  padding-top: 15px;\n  padding-bottom: 15px;\n  box-shadow: 0 2px 4px 0px rgba(0, 0, 0, 0.2), 0 4px 5px 0 rgba(0, 0, 0, 0.14), 0 1px 10px 0 rgba(0, 0, 0, 0.12);\n}\n.bottom-buttons .resButton {\n  margin-right: 1rem;\n  background-color: green;\n  border-radius: 10px;\n  box-shadow: 0 2px 4px -1px rgba(0, 0, 0, 0.2), 0 4px 5px 0 rgba(0, 0, 0, 0.14), 0 1px 10px 0 rgba(0, 0, 0, 0.12);\n}\n.ownerLink {\n  text-decoration: none !important;\n}\n.description {\n  text-align: justify;\n  font-size: 1.5rem;\n}\n.example-rate-limit-reached {\n  color: #980000;\n  text-align: center;\n}\n.img-title {\n  text-align: justify;\n  word-wrap: break-word;\n  margin: 0;\n}\n.mainDiv .mat-card {\n  border-radius: 25px;\n}\n.mainDiv {\n  padding-left: 15vw;\n  padding-right: 15vw;\n}\n.mat-tab-header-pagination-disabled .mat-tab-header-pagination-chevron {\n  border-color: rgba(0, 0, 0, 0.62) !important;\n}\n.mainDiv .example-card {\n  box-shadow: 0 2px 4px 0px rgba(0, 0, 0, 0.2), 0 4px 5px 0 rgba(0, 0, 0, 0.14), 0 1px 10px 0 rgba(0, 0, 0, 0.12);\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Byb2plY3QvcHJvamVjdC1pbmZvL0M6L0RvY3VtZW50cy9HaXRIdWIvd2l0aG91dCBQaXJhbmhhL1RoZXJhTGFuZy9UaGVyYUxhbmcuV2ViL0NsaWVudEFwcC9zcmMvYXBwL21vZHVsZXMvbWFpbi9wYWdlcy9wcm9qZWN0L3Byb2plY3QtaW5mby9wcm9qZWN0LWluZm8uY29tcG9uZW50Lmxlc3MiLCJzcmMvYXBwL21vZHVsZXMvbWFpbi9wYWdlcy9wcm9qZWN0L3Byb2plY3QtaW5mby9wcm9qZWN0LWluZm8uY29tcG9uZW50Lmxlc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDRSxpQkFBQTtFQUNBLGNBQUE7RUFDQSxzQkFBQTtBQ0NGO0FEQ0E7RUFDRSxpQkFBQTtFQUNBLGNBQUE7RUFDQSxpQkFBQTtBQ0NGO0FEQ0E7RUFDRSxtQkFBQTtBQ0NGO0FEQ0E7RUFDRSxxQ0FBQTtFQUNBLHNCQUFBO0FDQ0Y7QURDQTtFQUNFLGNBQUE7QUNDRjtBRENBO0VBQ0UsZ0JBQUE7QUNDRjtBRENBO0VBQ0Usa0JBQUE7QUNDRjtBREVBO0VBQ0UsWUFBQTtFQUNBLHlCQUFBO0FDQUY7QURFQTtFQUNFLHNCQUFBO0VBQ0EsdUJBQUE7RUFDQSxtQkFBQTtBQ0FGO0FERUE7RUFDRSxpQkFBQTtFQUNBLGlCQUFBO0VBQ0EsaUJBQUE7RUFDQSxnQkFBQTtFQUNBLG1CQUFBO0VBQ0Esa0JBQUE7RUFDQSxtQkFBQTtFQUNBLGlCQUFBO0VBQ0Esb0JBQUE7RUFDQSwrR0FBQTtBQ0FGO0FER0E7RUFDRSxrQkFBQTtFQUNBLHVCQUFBO0VBQ0EsbUJBQUE7RUFDQSxnSEFBQTtBQ0RGO0FES0E7RUFDRSxnQ0FBQTtBQ0hGO0FES0E7RUFDRSxtQkFBQTtFQUNBLGlCQUFBO0FDSEY7QURNQTtFQUNFLGNBQUE7RUFDQSxrQkFBQTtBQ0pGO0FET0E7RUFDRSxtQkFBQTtFQUNBLHFCQUFBO0VBQ0EsU0FBQTtBQ0xGO0FEUUE7RUFDRSxtQkFBQTtBQ05GO0FEUUE7RUFDRSxrQkFBQTtFQUNBLG1CQUFBO0FDTkY7QURTQTtFQUNFLDRDQUFBO0FDUEY7QURVQTtFQUNFLCtHQUFBO0FDUkYiLCJmaWxlIjoic3JjL2FwcC9tb2R1bGVzL21haW4vcGFnZXMvcHJvamVjdC9wcm9qZWN0LWluZm8vcHJvamVjdC1pbmZvLmNvbXBvbmVudC5sZXNzIiwic291cmNlc0NvbnRlbnQiOlsiLmV4YW1wbGUtY2FyZCB7XG4gIG1heC13aWR0aDogMTIwMHB4O1xuICBtYXJnaW46IDAgYXV0bztcbiAgYmFja2dyb3VuZC1jb2xvcjogZ3JheTtcbn1cbiNyZXNUYWJJZCB7XG4gIG1heC13aWR0aDogMTIzMHB4O1xuICBtYXJnaW46IDAgYXV0bztcbiAgbWluLWhlaWdodDogMjByZW07XG59XG5hcHAtcmVzb3VyY2VzLXRhYmxlIC5yZXNUYWIge1xuICBib3JkZXItcmFkaXVzOiAyNXB4O1xufVxuLmV4YW1wbGUtaGVhZGVyLWltYWdlIHtcbiAgYmFja2dyb3VuZC1pbWFnZTogdXJsKFwiLi4vLi4vLi4vLi4vLi4vLi4vYXNzZXRzL2ltZy90cmFzaGNhdC5qcGdcIik7XG4gIGJhY2tncm91bmQtc2l6ZTogY292ZXI7XG59XG4ubWF0LWNhcmQtaGVhZGVyIC5tYXQtY2FyZC1hdmF0YXIge1xuICBkaXNwbGF5OiBibG9jaztcbn1cbm1hdC1jYXJkLWhlYWRlciAubWF0LWNhcmQtaGVhZGVyLXRleHQge1xuICBtYXJnaW4tdG9wOiAxMHB4O1xufVxuLmRlc2NyaXB0aW9uIHtcbiAgdGV4dC1hbGlnbjogY2VudGVyO1xufVxuXG4ubWF0LXRhYi1sYWJlbCB7XG4gIGNvbG9yOiBibGFjaztcbiAgbWluLXdpZHRoOiAwcHggIWltcG9ydGFudDtcbn1cbi5tYXQtY2FyZC1hdmF0YXIge1xuICB3aWR0aDogNHJlbSAhaW1wb3J0YW50O1xuICBoZWlnaHQ6IDRyZW0gIWltcG9ydGFudDtcbiAgbWFyZ2luLWJvdHRvbTogMXJlbTtcbn1cbi5ib3R0b20tYnV0dG9ucyB7XG4gIG1heC13aWR0aDogMTIzMHB4O1xuICB0ZXh0LWFsaWduOiByaWdodDtcbiAgbWFyZ2luLWxlZnQ6IGF1dG87XG4gIG1hcmdpbi10b3A6IDFyZW07XG4gIG1hcmdpbi1ib3R0b206IDFyZW07XG4gIG1hcmdpbi1yaWdodDogYXV0bztcbiAgYm9yZGVyLXJhZGl1czogMjVweDtcbiAgcGFkZGluZy10b3A6IDE1cHg7XG4gIHBhZGRpbmctYm90dG9tOiAxNXB4O1xuICBib3gtc2hhZG93OiAwIDJweCA0cHggMHB4IHJnYmEoMCwgMCwgMCwgMC4yKSwgMCA0cHggNXB4IDAgcmdiYSgwLCAwLCAwLCAwLjE0KSxcbiAgICAwIDFweCAxMHB4IDAgcmdiYSgwLCAwLCAwLCAwLjEyKTtcbn1cbi5ib3R0b20tYnV0dG9ucyAucmVzQnV0dG9uIHtcbiAgbWFyZ2luLXJpZ2h0OiAxcmVtO1xuICBiYWNrZ3JvdW5kLWNvbG9yOiBncmVlbjtcbiAgYm9yZGVyLXJhZGl1czogMTBweDtcbiAgYm94LXNoYWRvdzogMCAycHggNHB4IC0xcHggcmdiYSgwLCAwLCAwLCAwLjIpLCAwIDRweCA1cHggMCByZ2JhKDAsIDAsIDAsIDAuMTQpLFxuICAgIDAgMXB4IDEwcHggMCByZ2JhKDAsIDAsIDAsIDAuMTIpO1xufVxuXG4ub3duZXJMaW5rIHtcbiAgdGV4dC1kZWNvcmF0aW9uOiBub25lICFpbXBvcnRhbnQ7XG59XG4uZGVzY3JpcHRpb24ge1xuICB0ZXh0LWFsaWduOiBqdXN0aWZ5O1xuICBmb250LXNpemU6IDEuNXJlbTtcbn1cblxuLmV4YW1wbGUtcmF0ZS1saW1pdC1yZWFjaGVkIHtcbiAgY29sb3I6ICM5ODAwMDA7XG4gIHRleHQtYWxpZ246IGNlbnRlcjtcbn1cblxuLmltZy10aXRsZSB7XG4gIHRleHQtYWxpZ246IGp1c3RpZnk7XG4gIHdvcmQtd3JhcDogYnJlYWstd29yZDtcbiAgbWFyZ2luOiAwO1xufVxuXG4ubWFpbkRpdiAubWF0LWNhcmQge1xuICBib3JkZXItcmFkaXVzOiAyNXB4O1xufVxuLm1haW5EaXYge1xuICBwYWRkaW5nLWxlZnQ6IDE1dnc7XG4gIHBhZGRpbmctcmlnaHQ6IDE1dnc7XG59XG5cbi5tYXQtdGFiLWhlYWRlci1wYWdpbmF0aW9uLWRpc2FibGVkIC5tYXQtdGFiLWhlYWRlci1wYWdpbmF0aW9uLWNoZXZyb24ge1xuICBib3JkZXItY29sb3I6IHJnYmEoMCwgMCwgMCwgMC42MikgIWltcG9ydGFudDtcbn1cblxuLm1haW5EaXYgLmV4YW1wbGUtY2FyZCB7XG4gIGJveC1zaGFkb3c6IDAgMnB4IDRweCAwcHggcmdiYSgwLCAwLCAwLCAwLjIpLCAwIDRweCA1cHggMCByZ2JhKDAsIDAsIDAsIDAuMTQpLFxuICAgIDAgMXB4IDEwcHggMCByZ2JhKDAsIDAsIDAsIDAuMTIpO1xufVxuIiwiLmV4YW1wbGUtY2FyZCB7XG4gIG1heC13aWR0aDogMTIwMHB4O1xuICBtYXJnaW46IDAgYXV0bztcbiAgYmFja2dyb3VuZC1jb2xvcjogZ3JheTtcbn1cbiNyZXNUYWJJZCB7XG4gIG1heC13aWR0aDogMTIzMHB4O1xuICBtYXJnaW46IDAgYXV0bztcbiAgbWluLWhlaWdodDogMjByZW07XG59XG5hcHAtcmVzb3VyY2VzLXRhYmxlIC5yZXNUYWIge1xuICBib3JkZXItcmFkaXVzOiAyNXB4O1xufVxuLmV4YW1wbGUtaGVhZGVyLWltYWdlIHtcbiAgYmFja2dyb3VuZC1pbWFnZTogdXJsKFwiLi4vLi4vLi4vLi4vLi4vLi4vYXNzZXRzL2ltZy90cmFzaGNhdC5qcGdcIik7XG4gIGJhY2tncm91bmQtc2l6ZTogY292ZXI7XG59XG4ubWF0LWNhcmQtaGVhZGVyIC5tYXQtY2FyZC1hdmF0YXIge1xuICBkaXNwbGF5OiBibG9jaztcbn1cbm1hdC1jYXJkLWhlYWRlciAubWF0LWNhcmQtaGVhZGVyLXRleHQge1xuICBtYXJnaW4tdG9wOiAxMHB4O1xufVxuLmRlc2NyaXB0aW9uIHtcbiAgdGV4dC1hbGlnbjogY2VudGVyO1xufVxuLm1hdC10YWItbGFiZWwge1xuICBjb2xvcjogYmxhY2s7XG4gIG1pbi13aWR0aDogMHB4ICFpbXBvcnRhbnQ7XG59XG4ubWF0LWNhcmQtYXZhdGFyIHtcbiAgd2lkdGg6IDRyZW0gIWltcG9ydGFudDtcbiAgaGVpZ2h0OiA0cmVtICFpbXBvcnRhbnQ7XG4gIG1hcmdpbi1ib3R0b206IDFyZW07XG59XG4uYm90dG9tLWJ1dHRvbnMge1xuICBtYXgtd2lkdGg6IDEyMzBweDtcbiAgdGV4dC1hbGlnbjogcmlnaHQ7XG4gIG1hcmdpbi1sZWZ0OiBhdXRvO1xuICBtYXJnaW4tdG9wOiAxcmVtO1xuICBtYXJnaW4tYm90dG9tOiAxcmVtO1xuICBtYXJnaW4tcmlnaHQ6IGF1dG87XG4gIGJvcmRlci1yYWRpdXM6IDI1cHg7XG4gIHBhZGRpbmctdG9wOiAxNXB4O1xuICBwYWRkaW5nLWJvdHRvbTogMTVweDtcbiAgYm94LXNoYWRvdzogMCAycHggNHB4IDBweCByZ2JhKDAsIDAsIDAsIDAuMiksIDAgNHB4IDVweCAwIHJnYmEoMCwgMCwgMCwgMC4xNCksIDAgMXB4IDEwcHggMCByZ2JhKDAsIDAsIDAsIDAuMTIpO1xufVxuLmJvdHRvbS1idXR0b25zIC5yZXNCdXR0b24ge1xuICBtYXJnaW4tcmlnaHQ6IDFyZW07XG4gIGJhY2tncm91bmQtY29sb3I6IGdyZWVuO1xuICBib3JkZXItcmFkaXVzOiAxMHB4O1xuICBib3gtc2hhZG93OiAwIDJweCA0cHggLTFweCByZ2JhKDAsIDAsIDAsIDAuMiksIDAgNHB4IDVweCAwIHJnYmEoMCwgMCwgMCwgMC4xNCksIDAgMXB4IDEwcHggMCByZ2JhKDAsIDAsIDAsIDAuMTIpO1xufVxuLm93bmVyTGluayB7XG4gIHRleHQtZGVjb3JhdGlvbjogbm9uZSAhaW1wb3J0YW50O1xufVxuLmRlc2NyaXB0aW9uIHtcbiAgdGV4dC1hbGlnbjoganVzdGlmeTtcbiAgZm9udC1zaXplOiAxLjVyZW07XG59XG4uZXhhbXBsZS1yYXRlLWxpbWl0LXJlYWNoZWQge1xuICBjb2xvcjogIzk4MDAwMDtcbiAgdGV4dC1hbGlnbjogY2VudGVyO1xufVxuLmltZy10aXRsZSB7XG4gIHRleHQtYWxpZ246IGp1c3RpZnk7XG4gIHdvcmQtd3JhcDogYnJlYWstd29yZDtcbiAgbWFyZ2luOiAwO1xufVxuLm1haW5EaXYgLm1hdC1jYXJkIHtcbiAgYm9yZGVyLXJhZGl1czogMjVweDtcbn1cbi5tYWluRGl2IHtcbiAgcGFkZGluZy1sZWZ0OiAxNXZ3O1xuICBwYWRkaW5nLXJpZ2h0OiAxNXZ3O1xufVxuLm1hdC10YWItaGVhZGVyLXBhZ2luYXRpb24tZGlzYWJsZWQgLm1hdC10YWItaGVhZGVyLXBhZ2luYXRpb24tY2hldnJvbiB7XG4gIGJvcmRlci1jb2xvcjogcmdiYSgwLCAwLCAwLCAwLjYyKSAhaW1wb3J0YW50O1xufVxuLm1haW5EaXYgLmV4YW1wbGUtY2FyZCB7XG4gIGJveC1zaGFkb3c6IDAgMnB4IDRweCAwcHggcmdiYSgwLCAwLCAwLCAwLjIpLCAwIDRweCA1cHggMCByZ2JhKDAsIDAsIDAsIDAuMTQpLCAwIDFweCAxMHB4IDAgcmdiYSgwLCAwLCAwLCAwLjEyKTtcbn1cbiJdfQ== */");

/***/ }),

/***/ "./src/app/modules/main/pages/project/project-info/project-info.component.ts":
/*!***********************************************************************************!*\
  !*** ./src/app/modules/main/pages/project/project-info/project-info.component.ts ***!
  \***********************************************************************************/
/*! exports provided: ProjectInfoComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectInfoComponent", function() { return ProjectInfoComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var _angular_animations__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/animations */ "./node_modules/@angular/animations/fesm2015/animations.js");
/* harmony import */ var _core_http_http_http_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../../../../../core/http/http/http.service */ "./src/app/core/http/http/http.service.ts");
/* harmony import */ var _core_http_project_participants_project_participation_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../../../../../core/http/project-participants/project-participation.service */ "./src/app/core/http/project-participants/project-participation.service.ts");
/* harmony import */ var _core_http_resource_resource_service__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ../../../../../core/http/resource/resource.service */ "./src/app/core/http/resource/resource.service.ts");
/* harmony import */ var _ngx_translate_core__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @ngx-translate/core */ "./node_modules/@ngx-translate/core/fesm2015/ngx-translate-core.js");
/* harmony import */ var src_app_core_services_notification_notification_service__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! src/app/core/services/notification/notification.service */ "./src/app/core/services/notification/notification.service.ts");









let ProjectInfoComponent = class ProjectInfoComponent {
    constructor(route, http, resourceService, participService, notificationService, translate) {
        this.route = route;
        this.http = http;
        this.resourceService = resourceService;
        this.participService = participService;
        this.notificationService = notificationService;
        this.translate = translate;
        this.generateOnceResourcesTable = false;
        this.sortedResourcesByCategory = [];
        this.isOpen = false;
    }
    ngOnInit() {
        this.route.paramMap.subscribe(params => {
            this.projectId = +params.get("id");
            this.http
                .getProjectInfo(this.projectId)
                .subscribe((data) => (this.projectInfo = data));
        });
    }
    getResourcesData() {
        return tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            if (!this.generateOnceResourcesTable) {
                const allResources = yield this.resourceService.getAllResourcesByProjId(this.projectId);
                this.sortedResourcesByCategory = this.resourceService.sortAllResourcesByCategories(allResources);
            }
            this.isOpen = !this.isOpen;
            this.generateOnceResourcesTable = true;
        });
    }
    onJoin() {
        this.participService.createParticipRequest(this.projectId).subscribe((msg) => tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            msg = yield this.translate
                .get("common.messages.request-sent")
                .toPromise();
            this.notificationService.success(msg);
        }), (error) => tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            console.log(error);
            this.notificationService.warn(yield this.translate
                .get("common.messages.cant-send-request")
                .toPromise());
        }));
    }
};
ProjectInfoComponent.ctorParameters = () => [
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_2__["ActivatedRoute"] },
    { type: _core_http_http_http_service__WEBPACK_IMPORTED_MODULE_4__["HttpService"] },
    { type: _core_http_resource_resource_service__WEBPACK_IMPORTED_MODULE_6__["ResourceService"] },
    { type: _core_http_project_participants_project_participation_service__WEBPACK_IMPORTED_MODULE_5__["ProjectParticipationService"] },
    { type: src_app_core_services_notification_notification_service__WEBPACK_IMPORTED_MODULE_8__["NotificationService"] },
    { type: _ngx_translate_core__WEBPACK_IMPORTED_MODULE_7__["TranslateService"] }
];
ProjectInfoComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: "app-project-info",
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./project-info.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-info/project-info.component.html")).default,
        encapsulation: _angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewEncapsulation"].None,
        animations: [
            Object(_angular_animations__WEBPACK_IMPORTED_MODULE_3__["trigger"])("openClose", [
                Object(_angular_animations__WEBPACK_IMPORTED_MODULE_3__["state"])("open", Object(_angular_animations__WEBPACK_IMPORTED_MODULE_3__["style"])({
                    display: "initial"
                })),
                Object(_angular_animations__WEBPACK_IMPORTED_MODULE_3__["state"])("closed", Object(_angular_animations__WEBPACK_IMPORTED_MODULE_3__["style"])({
                    display: "none"
                }))
            ])
        ],
        providers: [_core_http_http_http_service__WEBPACK_IMPORTED_MODULE_4__["HttpService"], _core_http_project_participants_project_participation_service__WEBPACK_IMPORTED_MODULE_5__["ProjectParticipationService"]],
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./project-info.component.less */ "./src/app/modules/main/pages/project/project-info/project-info.component.less")).default]
    })
], ProjectInfoComponent);



/***/ }),

/***/ "./src/app/modules/main/pages/project/project-info/resources-table-for-project/project-type/project-type.component.less":
/*!******************************************************************************************************************************!*\
  !*** ./src/app/modules/main/pages/project/project-info/resources-table-for-project/project-type/project-type.component.less ***!
  \******************************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".deleteButton .mat-raised-button {\n  background-color: #e00909;\n  margin-left: 15px;\n}\n.editButton .mat-raised-button {\n  background-color: #124be7;\n}\n.create {\n  background-color: #09d635;\n  margin-bottom: 15px;\n  margin-left: 15px;\n}\ntable {\n  width: 100%;\n  margin: 15px;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Byb2plY3QvcHJvamVjdC1pbmZvL3Jlc291cmNlcy10YWJsZS1mb3ItcHJvamVjdC9wcm9qZWN0LXR5cGUvQzovRG9jdW1lbnRzL0dpdEh1Yi93aXRob3V0IFBpcmFuaGEvVGhlcmFMYW5nL1RoZXJhTGFuZy5XZWIvQ2xpZW50QXBwL3NyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Byb2plY3QvcHJvamVjdC1pbmZvL3Jlc291cmNlcy10YWJsZS1mb3ItcHJvamVjdC9wcm9qZWN0LXR5cGUvcHJvamVjdC10eXBlLmNvbXBvbmVudC5sZXNzIiwic3JjL2FwcC9tb2R1bGVzL21haW4vcGFnZXMvcHJvamVjdC9wcm9qZWN0LWluZm8vcmVzb3VyY2VzLXRhYmxlLWZvci1wcm9qZWN0L3Byb2plY3QtdHlwZS9wcm9qZWN0LXR5cGUuY29tcG9uZW50Lmxlc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQ0E7RUFDSSx5QkFBQTtFQUNBLGlCQUFBO0FDQUo7QURHRTtFQUNFLHlCQUFBO0FDREo7QURJRTtFQUNJLHlCQUFBO0VBQ0EsbUJBQUE7RUFDQSxpQkFBQTtBQ0ZOO0FES0U7RUFDRSxXQUFBO0VBRUEsWUFBQTtBQ0pKIiwiZmlsZSI6InNyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Byb2plY3QvcHJvamVjdC1pbmZvL3Jlc291cmNlcy10YWJsZS1mb3ItcHJvamVjdC9wcm9qZWN0LXR5cGUvcHJvamVjdC10eXBlLmNvbXBvbmVudC5sZXNzIiwic291cmNlc0NvbnRlbnQiOlsiXG4uZGVsZXRlQnV0dG9uIC5tYXQtcmFpc2VkLWJ1dHRvbiB7XG4gICAgYmFja2dyb3VuZC1jb2xvcjogcmdiKDIyNCwgOSwgOSk7XG4gICAgbWFyZ2luLWxlZnQ6IDE1cHg7XG4gIH1cbiAgXG4gIC5lZGl0QnV0dG9uIC5tYXQtcmFpc2VkLWJ1dHRvbiB7XG4gICAgYmFja2dyb3VuZC1jb2xvcjogcmdiKDE4LCA3NSwgMjMxKVxuICB9XG5cbiAgLmNyZWF0ZSB7XG4gICAgICBiYWNrZ3JvdW5kLWNvbG9yOiByZ2IoOSwgMjE0LCA1Myk7XG4gICAgICBtYXJnaW4tYm90dG9tOiAxNXB4O1xuICAgICAgbWFyZ2luLWxlZnQ6IDE1cHg7XG4gIH1cblxuICB0YWJsZSB7XG4gICAgd2lkdGg6IDEwMCU7XG4gICAgbWFyZ2luOiAxNXB4O1xuICAgIG1hcmdpbjogMTVweDtcbiAgfSIsIi5kZWxldGVCdXR0b24gLm1hdC1yYWlzZWQtYnV0dG9uIHtcbiAgYmFja2dyb3VuZC1jb2xvcjogI2UwMDkwOTtcbiAgbWFyZ2luLWxlZnQ6IDE1cHg7XG59XG4uZWRpdEJ1dHRvbiAubWF0LXJhaXNlZC1idXR0b24ge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjMTI0YmU3O1xufVxuLmNyZWF0ZSB7XG4gIGJhY2tncm91bmQtY29sb3I6ICMwOWQ2MzU7XG4gIG1hcmdpbi1ib3R0b206IDE1cHg7XG4gIG1hcmdpbi1sZWZ0OiAxNXB4O1xufVxudGFibGUge1xuICB3aWR0aDogMTAwJTtcbiAgbWFyZ2luOiAxNXB4O1xufVxuIl19 */");

/***/ }),

/***/ "./src/app/modules/main/pages/project/project-info/resources-table-for-project/project-type/project-type.component.ts":
/*!****************************************************************************************************************************!*\
  !*** ./src/app/modules/main/pages/project/project-info/resources-table-for-project/project-type/project-type.component.ts ***!
  \****************************************************************************************************************************/
/*! exports provided: ProjectTypeComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectTypeComponent", function() { return ProjectTypeComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _core_services_project_type_project_type_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../../../../../../core/services/project-type/project-type.service */ "./src/app/core/services/project-type/project-type.service.ts");
/* harmony import */ var _core_http_project_type_project_type_Http_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../../../../../core/http/project-type/project-type-Http.service */ "./src/app/core/http/project-type/project-type-Http.service.ts");
/* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm2015/material.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _project_type_form_project_type_form_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../../../project-type-form/project-type-form.component */ "./src/app/modules/main/pages/project/project-type-form/project-type-form.component.ts");
/* harmony import */ var src_app_core_services_dialog_dialog_service__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! src/app/core/services/dialog/dialog.service */ "./src/app/core/services/dialog/dialog.service.ts");
/* harmony import */ var _project_type_create_form_project_type_create_form_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ../../../project-type-create-form/project-type-create-form.component */ "./src/app/modules/main/pages/project/project-type-create-form/project-type-create-form.component.ts");








let ProjectTypeComponent = class ProjectTypeComponent {
    constructor(projectTypeService, dialogService, http, dialog) {
        this.projectTypeService = projectTypeService;
        this.dialogService = dialogService;
        this.http = http;
        this.dialog = dialog;
        this.displayedColumns = ["typeName", "actions"];
    }
    ngOnInit() {
        return tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            this.projectTypes = yield this.projectTypeService.getAllProjectTypes();
        });
    }
    onCreate() {
        let dialogRef = this.dialog
            .open(_project_type_create_form_project_type_create_form_component__WEBPACK_IMPORTED_MODULE_7__["ProjectTypeCreateFormComponent"], {})
            .afterClosed()
            .subscribe(res => {
            this.ngOnInit();
        });
    }
    onEdit(projectType) {
        let dialogRef = this.dialog
            .open(_project_type_form_project_type_form_component__WEBPACK_IMPORTED_MODULE_5__["ProjectTypeFormComponent"], {
            data: { name: projectType.typeName, id: projectType.id }
        })
            .afterClosed()
            .subscribe(res => {
            this.ngOnInit();
        });
    }
    onDelete(id) {
        this.http.delete(id).subscribe((res) => tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            this.projectTypes = yield this.projectTypeService.getAllProjectTypes();
        }));
    }
};
ProjectTypeComponent.ctorParameters = () => [
    { type: _core_services_project_type_project_type_service__WEBPACK_IMPORTED_MODULE_1__["ProjectTypeService"] },
    { type: src_app_core_services_dialog_dialog_service__WEBPACK_IMPORTED_MODULE_6__["DialogService"] },
    { type: _core_http_project_type_project_type_Http_service__WEBPACK_IMPORTED_MODULE_2__["ProjectTypeHttp"] },
    { type: _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatDialog"] }
];
ProjectTypeComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_4__["Component"])({
        selector: "app-project-type",
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./project-type.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-info/resources-table-for-project/project-type/project-type.component.html")).default,
        providers: [_core_services_project_type_project_type_service__WEBPACK_IMPORTED_MODULE_1__["ProjectTypeService"], _project_type_form_project_type_form_component__WEBPACK_IMPORTED_MODULE_5__["ProjectTypeFormComponent"]],
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./project-type.component.less */ "./src/app/modules/main/pages/project/project-info/resources-table-for-project/project-type/project-type.component.less")).default]
    })
], ProjectTypeComponent);



/***/ }),

/***/ "./src/app/modules/main/pages/project/project-info/resources-table-for-project/resources-internal-table/resources-internal-table.component.less":
/*!******************************************************************************************************************************************************!*\
  !*** ./src/app/modules/main/pages/project/project-info/resources-table-for-project/resources-internal-table/resources-internal-table.component.less ***!
  \******************************************************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("table {\n  width: 100%;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Byb2plY3QvcHJvamVjdC1pbmZvL3Jlc291cmNlcy10YWJsZS1mb3ItcHJvamVjdC9yZXNvdXJjZXMtaW50ZXJuYWwtdGFibGUvQzovRG9jdW1lbnRzL0dpdEh1Yi93aXRob3V0IFBpcmFuaGEvVGhlcmFMYW5nL1RoZXJhTGFuZy5XZWIvQ2xpZW50QXBwL3NyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Byb2plY3QvcHJvamVjdC1pbmZvL3Jlc291cmNlcy10YWJsZS1mb3ItcHJvamVjdC9yZXNvdXJjZXMtaW50ZXJuYWwtdGFibGUvcmVzb3VyY2VzLWludGVybmFsLXRhYmxlLmNvbXBvbmVudC5sZXNzIiwic3JjL2FwcC9tb2R1bGVzL21haW4vcGFnZXMvcHJvamVjdC9wcm9qZWN0LWluZm8vcmVzb3VyY2VzLXRhYmxlLWZvci1wcm9qZWN0L3Jlc291cmNlcy1pbnRlcm5hbC10YWJsZS9yZXNvdXJjZXMtaW50ZXJuYWwtdGFibGUuY29tcG9uZW50Lmxlc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDSSxXQUFBO0FDQ0oiLCJmaWxlIjoic3JjL2FwcC9tb2R1bGVzL21haW4vcGFnZXMvcHJvamVjdC9wcm9qZWN0LWluZm8vcmVzb3VyY2VzLXRhYmxlLWZvci1wcm9qZWN0L3Jlc291cmNlcy1pbnRlcm5hbC10YWJsZS9yZXNvdXJjZXMtaW50ZXJuYWwtdGFibGUuY29tcG9uZW50Lmxlc3MiLCJzb3VyY2VzQ29udGVudCI6WyJ0YWJsZXtcbiAgICB3aWR0aDogMTAwJTtcbn0iLCJ0YWJsZSB7XG4gIHdpZHRoOiAxMDAlO1xufVxuIl19 */");

/***/ }),

/***/ "./src/app/modules/main/pages/project/project-info/resources-table-for-project/resources-internal-table/resources-internal-table.component.ts":
/*!****************************************************************************************************************************************************!*\
  !*** ./src/app/modules/main/pages/project/project-info/resources-table-for-project/resources-internal-table/resources-internal-table.component.ts ***!
  \****************************************************************************************************************************************************/
/*! exports provided: ResourcesInternalTableComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourcesInternalTableComponent", function() { return ResourcesInternalTableComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm2015/material.js");
/* harmony import */ var _configs_resources_table__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../../../../../../configs/resources-table */ "./src/app/configs/resources-table.ts");




let ResourcesInternalTableComponent = class ResourcesInternalTableComponent {
    constructor() {
        this.displayedColumns = ["id", "name", "date", "description"];
    }
    ngAfterViewInit() {
        this.pageSize = _configs_resources_table__WEBPACK_IMPORTED_MODULE_3__["ResourcesTableConstants"].COLUMNS_PER_PAGE;
        this.pageSizeOptions = _configs_resources_table__WEBPACK_IMPORTED_MODULE_3__["ResourcesTableConstants"].PAGE_SIZE_OPTIONS;
        this.dataSource.paginator = this.paginator;
    }
};
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
        selector: "app-resources-internal-table",
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./resources-internal-table.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-info/resources-table-for-project/resources-internal-table/resources-internal-table.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./resources-internal-table.component.less */ "./src/app/modules/main/pages/project/project-info/resources-table-for-project/resources-internal-table/resources-internal-table.component.less")).default]
    })
], ResourcesInternalTableComponent);



/***/ }),

/***/ "./src/app/modules/main/pages/project/project-info/resources-table-for-project/resources-table/resources-table.component.less":
/*!************************************************************************************************************************************!*\
  !*** ./src/app/modules/main/pages/project/project-info/resources-table-for-project/resources-table/resources-table.component.less ***!
  \************************************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL21vZHVsZXMvbWFpbi9wYWdlcy9wcm9qZWN0L3Byb2plY3QtaW5mby9yZXNvdXJjZXMtdGFibGUtZm9yLXByb2plY3QvcmVzb3VyY2VzLXRhYmxlL3Jlc291cmNlcy10YWJsZS5jb21wb25lbnQubGVzcyJ9 */");

/***/ }),

/***/ "./src/app/modules/main/pages/project/project-info/resources-table-for-project/resources-table/resources-table.component.ts":
/*!**********************************************************************************************************************************!*\
  !*** ./src/app/modules/main/pages/project/project-info/resources-table-for-project/resources-table/resources-table.component.ts ***!
  \**********************************************************************************************************************************/
/*! exports provided: ResourcesTableComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourcesTableComponent", function() { return ResourcesTableComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _core_http_resource_resource_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../../../../../core/http/resource/resource.service */ "./src/app/core/http/resource/resource.service.ts");
/* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm2015/material.js");




let ResourcesTableComponent = class ResourcesTableComponent {
    constructor(resourceService) {
        this.resourceService = resourceService;
    }
    ngOnInit() {
        for (const resCategoty in this.sortedResourcesByCategory) {
            this.selectResourcesArrayByCategotyName(resCategoty);
            return;
        }
    }
    convertMatTabChangeEventLabelToString(event) {
        const category = event.tab.textLabel;
        this.selectResourcesArrayByCategotyName(category);
    }
    selectResourcesArrayByCategotyName(category) {
        this.setDataSourceToInternalResourcesTable(this.sortedResourcesByCategory[category]);
    }
    setDataSourceToInternalResourcesTable(res) {
        this.lengthDataArrForDataSource = res.length;
        this.dataSource = new _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatTableDataSource"](res);
    }
};
ResourcesTableComponent.ctorParameters = () => [
    { type: _core_http_resource_resource_service__WEBPACK_IMPORTED_MODULE_2__["ResourceService"] }
];
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])()
], ResourcesTableComponent.prototype, "sortedResourcesByCategory", void 0);
ResourcesTableComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: "app-resources-table",
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./resources-table.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-info/resources-table-for-project/resources-table/resources-table.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./resources-table.component.less */ "./src/app/modules/main/pages/project/project-info/resources-table-for-project/resources-table/resources-table.component.less")).default]
    })
], ResourcesTableComponent);



/***/ }),

/***/ "./src/app/modules/main/pages/project/project-participants/project-participants.component.less":
/*!*****************************************************************************************************!*\
  !*** ./src/app/modules/main/pages/project/project-participants/project-participants.component.less ***!
  \*****************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("::ng-deep .mat-tab-body-content {\n  font-size: 3rem;\n  margin-left: 10px;\n}\n::ng-deep .mat-tab-label-content {\n  font-size: 1rem;\n  color: black;\n}\n.aproveButton .mat-raised-button {\n  background-color: #07a129;\n  margin-right: 15px;\n  margin-left: 15px;\n}\n.rejectButton .mat-raised-button {\n  background-color: #e00909;\n}\n.toNewButton .mat-raised-button {\n  background-color: #000000;\n  color: #ffffff;\n}\ntable {\n  width: 100%;\n}\n.mat-elevation-z8 {\n  margin: 15px;\n}\n.participation-tab {\n  margin: 15px;\n}\n.noData {\n  vertical-align: text-top;\n  margin: 15px;\n  padding: 15px;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Byb2plY3QvcHJvamVjdC1wYXJ0aWNpcGFudHMvQzovRG9jdW1lbnRzL0dpdEh1Yi93aXRob3V0IFBpcmFuaGEvVGhlcmFMYW5nL1RoZXJhTGFuZy5XZWIvQ2xpZW50QXBwL3NyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Byb2plY3QvcHJvamVjdC1wYXJ0aWNpcGFudHMvcHJvamVjdC1wYXJ0aWNpcGFudHMuY29tcG9uZW50Lmxlc3MiLCJzcmMvYXBwL21vZHVsZXMvbWFpbi9wYWdlcy9wcm9qZWN0L3Byb2plY3QtcGFydGljaXBhbnRzL3Byb2plY3QtcGFydGljaXBhbnRzLmNvbXBvbmVudC5sZXNzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0UsZUFBQTtFQUNBLGlCQUFBO0FDQ0Y7QURFQTtFQUNFLGVBQUE7RUFDQSxZQUFBO0FDQUY7QURHQTtFQUNFLHlCQUFBO0VBQ0Esa0JBQUE7RUFDQSxpQkFBQTtBQ0RGO0FESUE7RUFDRSx5QkFBQTtBQ0ZGO0FES0E7RUFDRSx5QkFBQTtFQUNBLGNBQUE7QUNIRjtBRE1BO0VBQ0UsV0FBQTtBQ0pGO0FET0E7RUFDRSxZQUFBO0FDTEY7QURPQTtFQUNFLFlBQUE7QUNMRjtBRFFBO0VBQ0Usd0JBQUE7RUFDQSxZQUFBO0VBQ0EsYUFBQTtBQ05GIiwiZmlsZSI6InNyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Byb2plY3QvcHJvamVjdC1wYXJ0aWNpcGFudHMvcHJvamVjdC1wYXJ0aWNpcGFudHMuY29tcG9uZW50Lmxlc3MiLCJzb3VyY2VzQ29udGVudCI6WyI6Om5nLWRlZXAgLm1hdC10YWItYm9keS1jb250ZW50IHtcbiAgZm9udC1zaXplICA6IDNyZW07XG4gIG1hcmdpbi1sZWZ0OiAxMHB4O1xufVxuXG46Om5nLWRlZXAgLm1hdC10YWItbGFiZWwtY29udGVudCB7XG4gIGZvbnQtc2l6ZTogMXJlbTtcbiAgY29sb3IgICAgOiBibGFjaztcbn1cblxuLmFwcm92ZUJ1dHRvbiAubWF0LXJhaXNlZC1idXR0b24ge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiByZ2IoNywgMTYxLCA0MSk7XG4gIG1hcmdpbi1yaWdodCAgICA6IDE1cHg7XG4gIG1hcmdpbi1sZWZ0ICAgICA6IDE1cHg7XG59XG5cbi5yZWplY3RCdXR0b24gLm1hdC1yYWlzZWQtYnV0dG9uIHtcbiAgYmFja2dyb3VuZC1jb2xvcjogcmdiKDIyNCwgOSwgOSlcbn1cblxuLnRvTmV3QnV0dG9uIC5tYXQtcmFpc2VkLWJ1dHRvbiB7XG4gIGJhY2tncm91bmQtY29sb3I6IHJnYigwLCAwLCAwKTtcbiAgY29sb3I6IHJnYigyNTUsIDI1NSwgMjU1KVxufVxuXG50YWJsZSB7XG4gIHdpZHRoOiAxMDAlO1xufVxuXG4ubWF0LWVsZXZhdGlvbi16OCB7XG4gIG1hcmdpbjogMTVweDtcbn1cbi5wYXJ0aWNpcGF0aW9uLXRhYiB7XG4gIG1hcmdpbjogMTVweDtcbn1cblxuLm5vRGF0YXtcbiAgdmVydGljYWwtYWxpZ246IHRleHQtdG9wO1xuICBtYXJnaW46IDE1cHg7XG4gIHBhZGRpbmc6IDE1cHg7XG59IiwiOjpuZy1kZWVwIC5tYXQtdGFiLWJvZHktY29udGVudCB7XG4gIGZvbnQtc2l6ZTogM3JlbTtcbiAgbWFyZ2luLWxlZnQ6IDEwcHg7XG59XG46Om5nLWRlZXAgLm1hdC10YWItbGFiZWwtY29udGVudCB7XG4gIGZvbnQtc2l6ZTogMXJlbTtcbiAgY29sb3I6IGJsYWNrO1xufVxuLmFwcm92ZUJ1dHRvbiAubWF0LXJhaXNlZC1idXR0b24ge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjMDdhMTI5O1xuICBtYXJnaW4tcmlnaHQ6IDE1cHg7XG4gIG1hcmdpbi1sZWZ0OiAxNXB4O1xufVxuLnJlamVjdEJ1dHRvbiAubWF0LXJhaXNlZC1idXR0b24ge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjZTAwOTA5O1xufVxuLnRvTmV3QnV0dG9uIC5tYXQtcmFpc2VkLWJ1dHRvbiB7XG4gIGJhY2tncm91bmQtY29sb3I6ICMwMDAwMDA7XG4gIGNvbG9yOiAjZmZmZmZmO1xufVxudGFibGUge1xuICB3aWR0aDogMTAwJTtcbn1cbi5tYXQtZWxldmF0aW9uLXo4IHtcbiAgbWFyZ2luOiAxNXB4O1xufVxuLnBhcnRpY2lwYXRpb24tdGFiIHtcbiAgbWFyZ2luOiAxNXB4O1xufVxuLm5vRGF0YSB7XG4gIHZlcnRpY2FsLWFsaWduOiB0ZXh0LXRvcDtcbiAgbWFyZ2luOiAxNXB4O1xuICBwYWRkaW5nOiAxNXB4O1xufVxuIl19 */");

/***/ }),

/***/ "./src/app/modules/main/pages/project/project-participants/project-participants.component.ts":
/*!***************************************************************************************************!*\
  !*** ./src/app/modules/main/pages/project/project-participants/project-participants.component.ts ***!
  \***************************************************************************************************/
/*! exports provided: ProjectParticipantsComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectParticipantsComponent", function() { return ProjectParticipantsComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _core_services_event_event_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../../../core/services/event/event-service */ "./src/app/core/services/event/event-service.ts");
/* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm2015/material.js");
/* harmony import */ var _core_http_project_participants_project_participation_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../../../../../core/http/project-participants/project-participation.service */ "./src/app/core/http/project-participants/project-participation.service.ts");
/* harmony import */ var src_app_configs_project_participation_request_status__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! src/app/configs/project-participation-request-status */ "./src/app/configs/project-participation-request-status.ts");






let ProjectParticipantsComponent = class ProjectParticipantsComponent {
    constructor(participantService, eventService) {
        this.participantService = participantService;
        this.eventService = eventService;
        this.projectParticipationRequest = new _angular_material__WEBPACK_IMPORTED_MODULE_3__["MatTableDataSource"]();
        this.showActionButtons = true;
        this.displayedColumns = [
            "requestedUserName",
            "projectName",
            "status",
            "actions"
        ];
    }
    ngOnInit() {
        this.participantService
            .getAllProjectParticipants()
            .subscribe((projectParticipants) => {
            this.projectParticipationRequest.data = projectParticipants;
            this.projectParticipationRequest.filterPredicate = (projectParticipant, filter) => projectParticipant.status.toString() === filter;
            this.projectParticipationRequest.paginator = this.paginator;
            this.projectParticipationRequest.filter = src_app_configs_project_participation_request_status__WEBPACK_IMPORTED_MODULE_5__["ProjectParticipationRequestStatus"].New.toString();
        });
    }
    loadPatricipants() {
        this.participantService
            .getAllProjectParticipants()
            .subscribe((projectParticipants) => {
            this.projectParticipationRequest.data = projectParticipants;
            this.removeNotificationIcon();
        });
    }
    changeTab(tabPosition) {
        this.projectParticipationRequest.filter = this.changeFilter(tabPosition);
        this.showActionButtons =
            tabPosition === src_app_configs_project_participation_request_status__WEBPACK_IMPORTED_MODULE_5__["ProjectParticipationRequestStatus"].New ? true : false;
    }
    changeFilter(tabPosition) {
        if (tabPosition === 1) {
            return src_app_configs_project_participation_request_status__WEBPACK_IMPORTED_MODULE_5__["ProjectParticipationRequestStatus"].Approved.toString();
        }
        else if (tabPosition === 2) {
            return src_app_configs_project_participation_request_status__WEBPACK_IMPORTED_MODULE_5__["ProjectParticipationRequestStatus"].Rejected.toString();
        }
        else {
            return src_app_configs_project_participation_request_status__WEBPACK_IMPORTED_MODULE_5__["ProjectParticipationRequestStatus"].New.toString();
        }
    }
    changeStatus(status, projectParticipant) {
        if (status === "approved")
            projectParticipant.status = src_app_configs_project_participation_request_status__WEBPACK_IMPORTED_MODULE_5__["ProjectParticipationRequestStatus"].Approved;
        else if (status === "rejected")
            projectParticipant.status = src_app_configs_project_participation_request_status__WEBPACK_IMPORTED_MODULE_5__["ProjectParticipationRequestStatus"].Rejected;
        else if (status === "new")
            projectParticipant.status = src_app_configs_project_participation_request_status__WEBPACK_IMPORTED_MODULE_5__["ProjectParticipationRequestStatus"].New;
        this.participantService
            .changeParticipationStatus(projectParticipant.id, projectParticipant.status)
            .subscribe(data => {
            this.loadPatricipants();
        });
    }
    removeNotificationIcon() {
        if (this.projectParticipationRequest.filteredData.length === 0) {
            this.eventService.emitChildEvent();
        }
    }
};
ProjectParticipantsComponent.ctorParameters = () => [
    { type: _core_http_project_participants_project_participation_service__WEBPACK_IMPORTED_MODULE_4__["ProjectParticipationService"] },
    { type: _core_services_event_event_service__WEBPACK_IMPORTED_MODULE_2__["EventService"] }
];
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])(_angular_material__WEBPACK_IMPORTED_MODULE_3__["MatPaginator"], { static: true })
], ProjectParticipantsComponent.prototype, "paginator", void 0);
ProjectParticipantsComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: "app-project-participants",
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./project-participants.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-participants/project-participants.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./project-participants.component.less */ "./src/app/modules/main/pages/project/project-participants/project-participants.component.less")).default]
    })
], ProjectParticipantsComponent);



/***/ }),

/***/ "./src/app/modules/main/pages/project/project-request/project-request.component.less":
/*!*******************************************************************************************!*\
  !*** ./src/app/modules/main/pages/project/project-request/project-request.component.less ***!
  \*******************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".aproveButton .mat-stroked-button {\n  background-color: #07a129;\n  margin-right: 15px;\n  margin-left: 15px;\n}\n.rejectButton .mat-stroked-button {\n  background-color: #e00909;\n}\n.project-card {\n  margin: 15px;\n}\n::ng-deep .mat-tab-body-content {\n  font-size: 3rem;\n  margin-left: 10px;\n}\n::ng-deep .mat-tab-label-content {\n  font-size: 1rem;\n  color: black;\n}\n.project-image {\n  max-width: 185px;\n  float: left;\n  margin: 10px 10px 10px 0;\n}\n.clear {\n  clear: both;\n  border: 3px solid;\n  border-color: #797575;\n}\n.get-details-button {\n  text-align: right;\n}\n.header {\n  float: right;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Byb2plY3QvcHJvamVjdC1yZXF1ZXN0L0M6L0RvY3VtZW50cy9HaXRIdWIvd2l0aG91dCBQaXJhbmhhL1RoZXJhTGFuZy9UaGVyYUxhbmcuV2ViL0NsaWVudEFwcC9zcmMvYXBwL21vZHVsZXMvbWFpbi9wYWdlcy9wcm9qZWN0L3Byb2plY3QtcmVxdWVzdC9wcm9qZWN0LXJlcXVlc3QuY29tcG9uZW50Lmxlc3MiLCJzcmMvYXBwL21vZHVsZXMvbWFpbi9wYWdlcy9wcm9qZWN0L3Byb2plY3QtcmVxdWVzdC9wcm9qZWN0LXJlcXVlc3QuY29tcG9uZW50Lmxlc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDRSx5QkFBQTtFQUNBLGtCQUFBO0VBQ0EsaUJBQUE7QUNDRjtBREVBO0VBQ0UseUJBQUE7QUNBRjtBREdBO0VBQ0UsWUFBQTtBQ0RGO0FESUE7RUFDRSxlQUFBO0VBQ0EsaUJBQUE7QUNGRjtBREtBO0VBQ0UsZUFBQTtFQUNBLFlBQUE7QUNIRjtBRE9BO0VBQ0UsZ0JBQUE7RUFDQSxXQUFBO0VBQ0Esd0JBQUE7QUNMRjtBRFFBO0VBQ0UsV0FBQTtFQUNBLGlCQUFBO0VBQ0EscUJBQUE7QUNORjtBRFVBO0VBQ0UsaUJBQUE7QUNSRjtBRFlBO0VBQ0UsWUFBQTtBQ1ZGIiwiZmlsZSI6InNyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Byb2plY3QvcHJvamVjdC1yZXF1ZXN0L3Byb2plY3QtcmVxdWVzdC5jb21wb25lbnQubGVzcyIsInNvdXJjZXNDb250ZW50IjpbIi5hcHJvdmVCdXR0b24gLm1hdC1zdHJva2VkLWJ1dHRvbiB7XG4gIGJhY2tncm91bmQtY29sb3I6IHJnYig3LCAxNjEsIDQxKTtcbiAgbWFyZ2luLXJpZ2h0OiAxNXB4O1xuICBtYXJnaW4tbGVmdDogMTVweDtcbn1cblxuLnJlamVjdEJ1dHRvbiAubWF0LXN0cm9rZWQtYnV0dG9uIHtcbiAgYmFja2dyb3VuZC1jb2xvcjogcmdiKDIyNCwgOSwgOSlcbn1cblxuLnByb2plY3QtY2FyZCB7XG4gIG1hcmdpbjogMTVweDtcbn1cblxuOjpuZy1kZWVwIC5tYXQtdGFiLWJvZHktY29udGVudCB7XG4gIGZvbnQtc2l6ZTogM3JlbTtcbiAgbWFyZ2luLWxlZnQ6IDEwcHg7XG59XG5cbjo6bmctZGVlcCAubWF0LXRhYi1sYWJlbC1jb250ZW50IHtcbiAgZm9udC1zaXplOiAxcmVtO1xuICBjb2xvcjogYmxhY2s7XG59XG5cblxuLnByb2plY3QtaW1hZ2Uge1xuICBtYXgtd2lkdGg6IDE4NXB4O1xuICBmbG9hdDogbGVmdDtcbiAgbWFyZ2luOiAxMHB4IDEwcHggMTBweCAwO1xufVxuXG4uY2xlYXIge1xuICBjbGVhcjogYm90aDtcbiAgYm9yZGVyOiAzcHggc29saWQ7XG4gIGJvcmRlci1jb2xvcjogIzc5NzU3NTtcbn1cblxuXG4uZ2V0LWRldGFpbHMtYnV0dG9uIHtcbiAgdGV4dC1hbGlnbjogcmlnaHQ7XG5cbn1cblxuLmhlYWRlciB7XG4gIGZsb2F0OiByaWdodDtcbn1cbiIsIi5hcHJvdmVCdXR0b24gLm1hdC1zdHJva2VkLWJ1dHRvbiB7XG4gIGJhY2tncm91bmQtY29sb3I6ICMwN2ExMjk7XG4gIG1hcmdpbi1yaWdodDogMTVweDtcbiAgbWFyZ2luLWxlZnQ6IDE1cHg7XG59XG4ucmVqZWN0QnV0dG9uIC5tYXQtc3Ryb2tlZC1idXR0b24ge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjZTAwOTA5O1xufVxuLnByb2plY3QtY2FyZCB7XG4gIG1hcmdpbjogMTVweDtcbn1cbjo6bmctZGVlcCAubWF0LXRhYi1ib2R5LWNvbnRlbnQge1xuICBmb250LXNpemU6IDNyZW07XG4gIG1hcmdpbi1sZWZ0OiAxMHB4O1xufVxuOjpuZy1kZWVwIC5tYXQtdGFiLWxhYmVsLWNvbnRlbnQge1xuICBmb250LXNpemU6IDFyZW07XG4gIGNvbG9yOiBibGFjaztcbn1cbi5wcm9qZWN0LWltYWdlIHtcbiAgbWF4LXdpZHRoOiAxODVweDtcbiAgZmxvYXQ6IGxlZnQ7XG4gIG1hcmdpbjogMTBweCAxMHB4IDEwcHggMDtcbn1cbi5jbGVhciB7XG4gIGNsZWFyOiBib3RoO1xuICBib3JkZXI6IDNweCBzb2xpZDtcbiAgYm9yZGVyLWNvbG9yOiAjNzk3NTc1O1xufVxuLmdldC1kZXRhaWxzLWJ1dHRvbiB7XG4gIHRleHQtYWxpZ246IHJpZ2h0O1xufVxuLmhlYWRlciB7XG4gIGZsb2F0OiByaWdodDtcbn1cbiJdfQ== */");

/***/ }),

/***/ "./src/app/modules/main/pages/project/project-request/project-request.component.ts":
/*!*****************************************************************************************!*\
  !*** ./src/app/modules/main/pages/project/project-request/project-request.component.ts ***!
  \*****************************************************************************************/
/*! exports provided: ProjectRequestComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectRequestComponent", function() { return ProjectRequestComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _core_http_project_http_project_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../../../core/http/project/http-project.service */ "./src/app/core/http/project/http-project.service.ts");
/* harmony import */ var _configs_project_status_request__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../../../../configs/project-status-request */ "./src/app/configs/project-status-request.ts");
/* harmony import */ var src_app_core_http_http_http_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! src/app/core/http/http/http.service */ "./src/app/core/http/http/http.service.ts");





let ProjectRequestComponent = class ProjectRequestComponent {
    constructor(http, projectRequestService) {
        this.http = http;
        this.projectRequestService = projectRequestService;
        this.showActionButtons = true;
    }
    changeStatus(status, project) {
        status === "approved"
            ? this.projectRequestService
                .Approve(project.id)
                .subscribe(data => this.loadNewProjects())
            : this.projectRequestService
                .Reject(project.id)
                .subscribe(data => this.loadNewProjects());
    }
    ngOnInit() {
        return this.http
            .getAllNewProjects()
            .subscribe((projects) => (this.projects = projects));
    }
    loadNewProjects() {
        this.http.getAllNewProjects().subscribe((projects) => {
            this.projects = projects;
        });
    }
    changeTab(tabPosition) {
        if (tabPosition === 1) {
            this.showActionButtons = false;
            return this.projectRequestService
                .GetProjectsByStatus(_configs_project_status_request__WEBPACK_IMPORTED_MODULE_3__["ProjectStatusRequest"].Approved)
                .subscribe((projects) => (this.projects = projects));
        }
        else if (tabPosition === 2) {
            this.showActionButtons = false;
            return this.projectRequestService
                .GetProjectsByStatus(_configs_project_status_request__WEBPACK_IMPORTED_MODULE_3__["ProjectStatusRequest"].Rejected)
                .subscribe((projects) => (this.projects = projects));
        }
        else {
            this.showActionButtons = true;
            return this.http
                .getAllNewProjects()
                .subscribe((projects) => (this.projects = projects));
        }
    }
};
ProjectRequestComponent.ctorParameters = () => [
    { type: src_app_core_http_http_http_service__WEBPACK_IMPORTED_MODULE_4__["HttpService"] },
    { type: _core_http_project_http_project_service__WEBPACK_IMPORTED_MODULE_2__["HttpProjectService"] }
];
ProjectRequestComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: "app-project-request",
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./project-request.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-request/project-request.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./project-request.component.less */ "./src/app/modules/main/pages/project/project-request/project-request.component.less")).default]
    })
], ProjectRequestComponent);



/***/ }),

/***/ "./src/app/modules/main/pages/project/project-type-create-form/project-type-create-form.component.less":
/*!*************************************************************************************************************!*\
  !*** ./src/app/modules/main/pages/project/project-type-create-form/project-type-create-form.component.less ***!
  \*************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".mat-form-field {\n  width: 100%;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Byb2plY3QvcHJvamVjdC10eXBlLWNyZWF0ZS1mb3JtL0M6L0RvY3VtZW50cy9HaXRIdWIvd2l0aG91dCBQaXJhbmhhL1RoZXJhTGFuZy9UaGVyYUxhbmcuV2ViL0NsaWVudEFwcC9zcmMvYXBwL21vZHVsZXMvbWFpbi9wYWdlcy9wcm9qZWN0L3Byb2plY3QtdHlwZS1jcmVhdGUtZm9ybS9wcm9qZWN0LXR5cGUtY3JlYXRlLWZvcm0uY29tcG9uZW50Lmxlc3MiLCJzcmMvYXBwL21vZHVsZXMvbWFpbi9wYWdlcy9wcm9qZWN0L3Byb2plY3QtdHlwZS1jcmVhdGUtZm9ybS9wcm9qZWN0LXR5cGUtY3JlYXRlLWZvcm0uY29tcG9uZW50Lmxlc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDSSxXQUFBO0FDQ0oiLCJmaWxlIjoic3JjL2FwcC9tb2R1bGVzL21haW4vcGFnZXMvcHJvamVjdC9wcm9qZWN0LXR5cGUtY3JlYXRlLWZvcm0vcHJvamVjdC10eXBlLWNyZWF0ZS1mb3JtLmNvbXBvbmVudC5sZXNzIiwic291cmNlc0NvbnRlbnQiOlsiLm1hdC1mb3JtLWZpZWxkIHtcbiAgICB3aWR0aDogMTAwJTtcbn0iLCIubWF0LWZvcm0tZmllbGQge1xuICB3aWR0aDogMTAwJTtcbn1cbiJdfQ== */");

/***/ }),

/***/ "./src/app/modules/main/pages/project/project-type-create-form/project-type-create-form.component.ts":
/*!***********************************************************************************************************!*\
  !*** ./src/app/modules/main/pages/project/project-type-create-form/project-type-create-form.component.ts ***!
  \***********************************************************************************************************/
/*! exports provided: ProjectTypeCreateFormComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectTypeCreateFormComponent", function() { return ProjectTypeCreateFormComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _core_services_project_type_project_type_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../../../core/services/project-type/project-type.service */ "./src/app/core/services/project-type/project-type.service.ts");
/* harmony import */ var _shared_models_project_type_project_type_model__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../../../../shared/models/project-type/project-type.model */ "./src/app/shared/models/project-type/project-type.model.ts");
/* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm2015/material.js");





let ProjectTypeCreateFormComponent = class ProjectTypeCreateFormComponent {
    constructor(dialog, service, dateAdapter) {
        this.dialog = dialog;
        this.service = service;
        this.dateAdapter = dateAdapter;
    }
    ngOnInit() {
        this.newData = new _shared_models_project_type_project_type_model__WEBPACK_IMPORTED_MODULE_3__["ProjectType"]();
    }
    onCloseForm() {
        this.dialog.close();
    }
    onSubmit() {
        this.service.Create(this.newData);
    }
};
ProjectTypeCreateFormComponent.ctorParameters = () => [
    { type: _angular_material__WEBPACK_IMPORTED_MODULE_4__["MatDialogRef"] },
    { type: _core_services_project_type_project_type_service__WEBPACK_IMPORTED_MODULE_2__["ProjectTypeService"] },
    { type: _angular_material__WEBPACK_IMPORTED_MODULE_4__["DateAdapter"] }
];
ProjectTypeCreateFormComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: "app-project-type-create-form",
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./project-type-create-form.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-type-create-form/project-type-create-form.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./project-type-create-form.component.less */ "./src/app/modules/main/pages/project/project-type-create-form/project-type-create-form.component.less")).default]
    })
], ProjectTypeCreateFormComponent);



/***/ }),

/***/ "./src/app/modules/main/pages/project/project-type-form/project-type-form.component.less":
/*!***********************************************************************************************!*\
  !*** ./src/app/modules/main/pages/project/project-type-form/project-type-form.component.less ***!
  \***********************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".mat-form-field {\n  width: 100%;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Byb2plY3QvcHJvamVjdC10eXBlLWZvcm0vQzovRG9jdW1lbnRzL0dpdEh1Yi93aXRob3V0IFBpcmFuaGEvVGhlcmFMYW5nL1RoZXJhTGFuZy5XZWIvQ2xpZW50QXBwL3NyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Byb2plY3QvcHJvamVjdC10eXBlLWZvcm0vcHJvamVjdC10eXBlLWZvcm0uY29tcG9uZW50Lmxlc3MiLCJzcmMvYXBwL21vZHVsZXMvbWFpbi9wYWdlcy9wcm9qZWN0L3Byb2plY3QtdHlwZS1mb3JtL3Byb2plY3QtdHlwZS1mb3JtLmNvbXBvbmVudC5sZXNzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0ksV0FBQTtBQ0NKIiwiZmlsZSI6InNyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Byb2plY3QvcHJvamVjdC10eXBlLWZvcm0vcHJvamVjdC10eXBlLWZvcm0uY29tcG9uZW50Lmxlc3MiLCJzb3VyY2VzQ29udGVudCI6WyIubWF0LWZvcm0tZmllbGQge1xuICAgIHdpZHRoOiAxMDAlO1xufSIsIi5tYXQtZm9ybS1maWVsZCB7XG4gIHdpZHRoOiAxMDAlO1xufVxuIl19 */");

/***/ }),

/***/ "./src/app/modules/main/pages/project/project-type-form/project-type-form.component.ts":
/*!*********************************************************************************************!*\
  !*** ./src/app/modules/main/pages/project/project-type-form/project-type-form.component.ts ***!
  \*********************************************************************************************/
/*! exports provided: ProjectTypeFormComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectTypeFormComponent", function() { return ProjectTypeFormComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm2015/material.js");
/* harmony import */ var _core_services_project_type_project_type_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../../../../core/services/project-type/project-type.service */ "./src/app/core/services/project-type/project-type.service.ts");
/* harmony import */ var _shared_models_project_type_project_type_model__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../../../../../shared/models/project-type/project-type.model */ "./src/app/shared/models/project-type/project-type.model.ts");





let ProjectTypeFormComponent = class ProjectTypeFormComponent {
    constructor(dialog, service, dateAdapter, data) {
        this.dialog = dialog;
        this.service = service;
        this.dateAdapter = dateAdapter;
        this.data = data;
    }
    ngOnInit() { }
    onCloseForm() {
        this.dialog.close();
    }
    onSubmit() {
        let newData = new _shared_models_project_type_project_type_model__WEBPACK_IMPORTED_MODULE_4__["ProjectType"]();
        newData.id = this.data.id;
        newData.typeName = this.data.name;
        this.service.Update(newData);
    }
};
ProjectTypeFormComponent.ctorParameters = () => [
    { type: _angular_material__WEBPACK_IMPORTED_MODULE_2__["MatDialogRef"] },
    { type: _core_services_project_type_project_type_service__WEBPACK_IMPORTED_MODULE_3__["ProjectTypeService"] },
    { type: _angular_material__WEBPACK_IMPORTED_MODULE_2__["DateAdapter"] },
    { type: undefined, decorators: [{ type: _angular_core__WEBPACK_IMPORTED_MODULE_1__["Inject"], args: [_angular_material__WEBPACK_IMPORTED_MODULE_2__["MAT_DIALOG_DATA"],] }] }
];
ProjectTypeFormComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: "app-project-type-form",
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./project-type-form.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project-type-form/project-type-form.component.html")).default,
        providers: [_core_services_project_type_project_type_service__WEBPACK_IMPORTED_MODULE_3__["ProjectTypeService"]],
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./project-type-form.component.less */ "./src/app/modules/main/pages/project/project-type-form/project-type-form.component.less")).default]
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__param"](3, Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Inject"])(_angular_material__WEBPACK_IMPORTED_MODULE_2__["MAT_DIALOG_DATA"]))
], ProjectTypeFormComponent);



/***/ }),

/***/ "./src/app/modules/main/pages/project/project.component.less":
/*!*******************************************************************!*\
  !*** ./src/app/modules/main/pages/project/project.component.less ***!
  \*******************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".mat-stroked-button {\n  background-color: #4a1e5f;\n  margin-left: 15px;\n  color: white;\n}\n.clear {\n  clear: both;\n  border: 1px solid;\n  border-color: #ffffff;\n}\n.mat-card-title {\n  font-size: 32px;\n  margin-bottom: 4px;\n}\n.detailes {\n  color: black;\n}\n.project-image {\n  margin: 0;\n  margin-right: 20px;\n  width: 350px;\n  height: 350px;\n  border-top-left-radius: 4px;\n  border-bottom-left-radius: 4px;\n}\n.project-description {\n  font-family: Roboto;\n  font-style: normal;\n  font-weight: normal;\n  line-height: 1.5;\n  font-size: 20px;\n  line-height: 28px;\n  width: 100%;\n}\n.home-card {\n  padding: 0;\n  margin: 40px;\n  margin-left: 50px;\n  margin-right: 50px;\n}\n.buttons-container {\n  height: 24px;\n}\n.mat-progress-bar {\n  height: 20px;\n  width: 100%;\n}\n.main-container {\n  width: 100%;\n  margin-top: 20px;\n}\n.actions-conteiner {\n  width: 100%;\n  margin-bottom: 20px;\n}\n.donate-button {\n  width: 100px;\n  height: 50px;\n}\n.mat-raised-button {\n  margin-right: 25px;\n  float: right;\n  height: 50px;\n  width: 200px;\n  font-size: 24px;\n}\n.mat-raised-button.mat-primary {\n  background-color: #59B0A1;\n}\n::ng-deep .mat-progress-bar-fill::after {\n  background-color: #59B0A1;\n}\n::ng-deep .mat-progress-bar-buffer {\n  background: #C4C4C4;\n}\n.donation-sum {\n  color: #59B0A1;\n  font-size: 26px;\n}\n.rised-sum {\n  color: #534E4E;\n  font-size: 24px;\n  margin-left: 5px;\n}\n.text-content {\n  display: flex;\n  justify-content: center;\n}\n.days-left-block {\n  padding-left: 20px;\n}\n.days {\n  font-size: 35px;\n  color: #423D3D;\n  height: 38px;\n  text-align: center;\n}\n.ng-star-inserted {\n  font-size: 16px;\n  color: #534E4E;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Byb2plY3QvQzovRG9jdW1lbnRzL0dpdEh1Yi93aXRob3V0IFBpcmFuaGEvVGhlcmFMYW5nL1RoZXJhTGFuZy5XZWIvQ2xpZW50QXBwL3NyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Byb2plY3QvcHJvamVjdC5jb21wb25lbnQubGVzcyIsInNyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Byb2plY3QvcHJvamVjdC5jb21wb25lbnQubGVzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQTtFQUNJLHlCQUFBO0VBQ0EsaUJBQUE7RUFDQSxZQUFBO0FDQ0o7QURFQTtFQUNJLFdBQUE7RUFDQSxpQkFBQTtFQUNBLHFCQUFBO0FDQUo7QURHQTtFQUNJLGVBQUE7RUFDQSxrQkFBQTtBQ0RKO0FESUE7RUFDSSxZQUFBO0FDRko7QURLQTtFQUNJLFNBQUE7RUFDQSxrQkFBQTtFQUNBLFlBQUE7RUFDQSxhQUFBO0VBQ0EsMkJBQUE7RUFDQSw4QkFBQTtBQ0hKO0FETUE7RUFDSSxtQkFBQTtFQUNBLGtCQUFBO0VBQ0EsbUJBQUE7RUFDQSxnQkFBQTtFQUNBLGVBQUE7RUFDQSxpQkFBQTtFQUNBLFdBQUE7QUNKSjtBRE9BO0VBQ0ksVUFBQTtFQUNBLFlBQUE7RUFDQSxpQkFBQTtFQUNBLGtCQUFBO0FDTEo7QURRQTtFQUNJLFlBQUE7QUNOSjtBRFNBO0VBQ0ksWUFBQTtFQUNBLFdBQUE7QUNQSjtBRFVBO0VBQ0ksV0FBQTtFQUNBLGdCQUFBO0FDUko7QURXQTtFQUNJLFdBQUE7RUFDQSxtQkFBQTtBQ1RKO0FEWUE7RUFDSSxZQUFBO0VBQ0EsWUFBQTtBQ1ZKO0FEYUE7RUFDSSxrQkFBQTtFQUNBLFlBQUE7RUFDQSxZQUFBO0VBQ0EsWUFBQTtFQUNBLGVBQUE7QUNYSjtBRGFBO0VBQ0kseUJBQUE7QUNYSjtBRGNBO0VBQ0kseUJBQUE7QUNaSjtBRGVBO0VBQ0ksbUJBQUE7QUNiSjtBRGdCQTtFQUNJLGNBQUE7RUFDQSxlQUFBO0FDZEo7QURpQkE7RUFDSSxjQUFBO0VBQ0EsZUFBQTtFQUNBLGdCQUFBO0FDZko7QURrQkE7RUFDSSxhQUFBO0VBQ0EsdUJBQUE7QUNoQko7QURtQkE7RUFDSSxrQkFBQTtBQ2pCSjtBRG9CQTtFQUNJLGVBQUE7RUFDQSxjQUFBO0VBQ0EsWUFBQTtFQUVBLGtCQUFBO0FDbkJKO0FEc0JBO0VBQ0ksZUFBQTtFQUNBLGNBQUE7QUNwQkoiLCJmaWxlIjoic3JjL2FwcC9tb2R1bGVzL21haW4vcGFnZXMvcHJvamVjdC9wcm9qZWN0LmNvbXBvbmVudC5sZXNzIiwic291cmNlc0NvbnRlbnQiOlsiLm1hdC1zdHJva2VkLWJ1dHRvbiB7XG4gICAgYmFja2dyb3VuZC1jb2xvcjogIzRhMWU1ZjtcbiAgICBtYXJnaW4tbGVmdDogMTVweDtcbiAgICBjb2xvcjogd2hpdGU7XG59XG5cbi5jbGVhciB7XG4gICAgY2xlYXIgICAgICAgOiBib3RoO1xuICAgIGJvcmRlciAgICAgIDogMXB4IHNvbGlkO1xuICAgIGJvcmRlci1jb2xvcjogI2ZmZmZmZjtcbn1cblxuLm1hdC1jYXJkLXRpdGxle1xuICAgIGZvbnQtc2l6ZTogMzJweDtcbiAgICBtYXJnaW4tYm90dG9tOiA0cHg7XG4gICBcbn1cbi5kZXRhaWxlc3tcbiAgICBjb2xvcjogYmxhY2s7XG59XG5cbi5wcm9qZWN0LWltYWdlIHtcbiAgICBtYXJnaW46IDA7XG4gICAgbWFyZ2luLXJpZ2h0OiAyMHB4O1xuICAgIHdpZHRoOiAzNTBweDtcbiAgICBoZWlnaHQ6IDM1MHB4O1xuICAgIGJvcmRlci10b3AtbGVmdC1yYWRpdXM6IDRweDtcbiAgICBib3JkZXItYm90dG9tLWxlZnQtcmFkaXVzOiA0cHg7XG4gIH1cblxuLnByb2plY3QtZGVzY3JpcHRpb257XG4gICAgZm9udC1mYW1pbHk6IFJvYm90bztcbiAgICBmb250LXN0eWxlOiBub3JtYWw7XG4gICAgZm9udC13ZWlnaHQ6IG5vcm1hbDtcbiAgICBsaW5lLWhlaWdodDogMS41O1xuICAgIGZvbnQtc2l6ZTogMjBweDtcbiAgICBsaW5lLWhlaWdodDogMjhweDtcbiAgICB3aWR0aDogMTAwJTtcbn1cblxuLmhvbWUtY2FyZCB7XG4gICAgcGFkZGluZzogMDtcbiAgICBtYXJnaW46IDQwcHg7XG4gICAgbWFyZ2luLWxlZnQ6IDUwcHg7XG4gICAgbWFyZ2luLXJpZ2h0OiA1MHB4O1xufVxuXG4uYnV0dG9ucy1jb250YWluZXJ7XG4gICAgaGVpZ2h0OiAyNHB4O1xufVxuXG4ubWF0LXByb2dyZXNzLWJhciB7XG4gICAgaGVpZ2h0OiAyMHB4O1xuICAgIHdpZHRoOiAxMDAlO1xufVxuXG4ubWFpbi1jb250YWluZXIge1xuICAgIHdpZHRoOiAxMDAlO1xuICAgIG1hcmdpbi10b3A6IDIwcHg7XG59XG5cbi5hY3Rpb25zLWNvbnRlaW5lciB7XG4gICAgd2lkdGg6IDEwMCU7XG4gICAgbWFyZ2luLWJvdHRvbTogMjBweDtcbn1cblxuLmRvbmF0ZS1idXR0b257XG4gICAgd2lkdGg6IDEwMHB4O1xuICAgIGhlaWdodDogNTBweDtcbn1cblxuLm1hdC1yYWlzZWQtYnV0dG9ue1xuICAgIG1hcmdpbi1yaWdodDogMjVweDtcbiAgICBmbG9hdDogcmlnaHQ7XG4gICAgaGVpZ2h0OiA1MHB4O1xuICAgIHdpZHRoOiAyMDBweDtcbiAgICBmb250LXNpemU6IDI0cHg7XG59XG4ubWF0LXJhaXNlZC1idXR0b24ubWF0LXByaW1hcnkge1xuICAgIGJhY2tncm91bmQtY29sb3I6ICAgIzU5QjBBMTtcbn1cblxuOjpuZy1kZWVwIC5tYXQtcHJvZ3Jlc3MtYmFyLWZpbGw6OmFmdGVyIHtcbiAgICBiYWNrZ3JvdW5kLWNvbG9yOiAjNTlCMEExO1xufVxuXG46Om5nLWRlZXAgLm1hdC1wcm9ncmVzcy1iYXItYnVmZmVyIHtcbiAgICBiYWNrZ3JvdW5kOiAjQzRDNEM0IDtcbn1cblxuLmRvbmF0aW9uLXN1bXtcbiAgICBjb2xvcjogIzU5QjBBMTtcbiAgICBmb250LXNpemU6IDI2cHg7XG59XG5cbi5yaXNlZC1zdW17XG4gICAgY29sb3I6ICM1MzRFNEU7XG4gICAgZm9udC1zaXplOiAyNHB4O1xuICAgIG1hcmdpbi1sZWZ0OiA1cHg7XG59XG5cbi50ZXh0LWNvbnRlbnR7XG4gICAgZGlzcGxheTogZmxleDtcbiAgICBqdXN0aWZ5LWNvbnRlbnQ6IGNlbnRlcjtcbn0gICBcblxuLmRheXMtbGVmdC1ibG9ja3tcbiAgICBwYWRkaW5nLWxlZnQ6IDIwcHg7XG59XG5cbi5kYXlze1xuICAgIGZvbnQtc2l6ZTogMzVweDtcbiAgICBjb2xvcjogIzQyM0QzRDtcbiAgICBoZWlnaHQ6IDM4cHg7XG4gICAgXG4gICAgdGV4dC1hbGlnbjogY2VudGVyO1xufVxuXG4ubmctc3Rhci1pbnNlcnRlZHtcbiAgICBmb250LXNpemU6IDE2cHg7XG4gICAgY29sb3I6ICM1MzRFNEU7XG59XG5cbiIsIi5tYXQtc3Ryb2tlZC1idXR0b24ge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjNGExZTVmO1xuICBtYXJnaW4tbGVmdDogMTVweDtcbiAgY29sb3I6IHdoaXRlO1xufVxuLmNsZWFyIHtcbiAgY2xlYXI6IGJvdGg7XG4gIGJvcmRlcjogMXB4IHNvbGlkO1xuICBib3JkZXItY29sb3I6ICNmZmZmZmY7XG59XG4ubWF0LWNhcmQtdGl0bGUge1xuICBmb250LXNpemU6IDMycHg7XG4gIG1hcmdpbi1ib3R0b206IDRweDtcbn1cbi5kZXRhaWxlcyB7XG4gIGNvbG9yOiBibGFjaztcbn1cbi5wcm9qZWN0LWltYWdlIHtcbiAgbWFyZ2luOiAwO1xuICBtYXJnaW4tcmlnaHQ6IDIwcHg7XG4gIHdpZHRoOiAzNTBweDtcbiAgaGVpZ2h0OiAzNTBweDtcbiAgYm9yZGVyLXRvcC1sZWZ0LXJhZGl1czogNHB4O1xuICBib3JkZXItYm90dG9tLWxlZnQtcmFkaXVzOiA0cHg7XG59XG4ucHJvamVjdC1kZXNjcmlwdGlvbiB7XG4gIGZvbnQtZmFtaWx5OiBSb2JvdG87XG4gIGZvbnQtc3R5bGU6IG5vcm1hbDtcbiAgZm9udC13ZWlnaHQ6IG5vcm1hbDtcbiAgbGluZS1oZWlnaHQ6IDEuNTtcbiAgZm9udC1zaXplOiAyMHB4O1xuICBsaW5lLWhlaWdodDogMjhweDtcbiAgd2lkdGg6IDEwMCU7XG59XG4uaG9tZS1jYXJkIHtcbiAgcGFkZGluZzogMDtcbiAgbWFyZ2luOiA0MHB4O1xuICBtYXJnaW4tbGVmdDogNTBweDtcbiAgbWFyZ2luLXJpZ2h0OiA1MHB4O1xufVxuLmJ1dHRvbnMtY29udGFpbmVyIHtcbiAgaGVpZ2h0OiAyNHB4O1xufVxuLm1hdC1wcm9ncmVzcy1iYXIge1xuICBoZWlnaHQ6IDIwcHg7XG4gIHdpZHRoOiAxMDAlO1xufVxuLm1haW4tY29udGFpbmVyIHtcbiAgd2lkdGg6IDEwMCU7XG4gIG1hcmdpbi10b3A6IDIwcHg7XG59XG4uYWN0aW9ucy1jb250ZWluZXIge1xuICB3aWR0aDogMTAwJTtcbiAgbWFyZ2luLWJvdHRvbTogMjBweDtcbn1cbi5kb25hdGUtYnV0dG9uIHtcbiAgd2lkdGg6IDEwMHB4O1xuICBoZWlnaHQ6IDUwcHg7XG59XG4ubWF0LXJhaXNlZC1idXR0b24ge1xuICBtYXJnaW4tcmlnaHQ6IDI1cHg7XG4gIGZsb2F0OiByaWdodDtcbiAgaGVpZ2h0OiA1MHB4O1xuICB3aWR0aDogMjAwcHg7XG4gIGZvbnQtc2l6ZTogMjRweDtcbn1cbi5tYXQtcmFpc2VkLWJ1dHRvbi5tYXQtcHJpbWFyeSB7XG4gIGJhY2tncm91bmQtY29sb3I6ICM1OUIwQTE7XG59XG46Om5nLWRlZXAgLm1hdC1wcm9ncmVzcy1iYXItZmlsbDo6YWZ0ZXIge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjNTlCMEExO1xufVxuOjpuZy1kZWVwIC5tYXQtcHJvZ3Jlc3MtYmFyLWJ1ZmZlciB7XG4gIGJhY2tncm91bmQ6ICNDNEM0QzQ7XG59XG4uZG9uYXRpb24tc3VtIHtcbiAgY29sb3I6ICM1OUIwQTE7XG4gIGZvbnQtc2l6ZTogMjZweDtcbn1cbi5yaXNlZC1zdW0ge1xuICBjb2xvcjogIzUzNEU0RTtcbiAgZm9udC1zaXplOiAyNHB4O1xuICBtYXJnaW4tbGVmdDogNXB4O1xufVxuLnRleHQtY29udGVudCB7XG4gIGRpc3BsYXk6IGZsZXg7XG4gIGp1c3RpZnktY29udGVudDogY2VudGVyO1xufVxuLmRheXMtbGVmdC1ibG9jayB7XG4gIHBhZGRpbmctbGVmdDogMjBweDtcbn1cbi5kYXlzIHtcbiAgZm9udC1zaXplOiAzNXB4O1xuICBjb2xvcjogIzQyM0QzRDtcbiAgaGVpZ2h0OiAzOHB4O1xuICB0ZXh0LWFsaWduOiBjZW50ZXI7XG59XG4ubmctc3Rhci1pbnNlcnRlZCB7XG4gIGZvbnQtc2l6ZTogMTZweDtcbiAgY29sb3I6ICM1MzRFNEU7XG59XG4iXX0= */");

/***/ }),

/***/ "./src/app/modules/main/pages/project/project.component.ts":
/*!*****************************************************************!*\
  !*** ./src/app/modules/main/pages/project/project.component.ts ***!
  \*****************************************************************/
/*! exports provided: ProjectComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectComponent", function() { return ProjectComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _core_http_http_http_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../../core/http/http/http.service */ "./src/app/core/http/http/http.service.ts");
/* harmony import */ var _project_form_project_form_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./project-form/project-form.component */ "./src/app/modules/main/pages/project/project-form/project-form.component.ts");
/* harmony import */ var _core_http_project_project_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../../../../core/http/project/project.service */ "./src/app/core/http/project/project.service.ts");
/* harmony import */ var _core_services_dialog_dialog_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../../../../core/services/dialog/dialog.service */ "./src/app/core/services/dialog/dialog.service.ts");
/* harmony import */ var _ngx_translate_core__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! @ngx-translate/core */ "./node_modules/@ngx-translate/core/fesm2015/ngx-translate-core.js");
/* harmony import */ var src_app_core_services_notification_notification_service__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! src/app/core/services/notification/notification.service */ "./src/app/core/services/notification/notification.service.ts");








let ProjectComponent = class ProjectComponent {
    constructor(httpService, dialogService, service, notificationService, translate) {
        this.httpService = httpService;
        this.dialogService = dialogService;
        this.service = service;
        this.notificationService = notificationService;
        this.translate = translate;
    }
    ngOnInit() {
        this.httpService
            .getAllProjects()
            .subscribe((projects) => (this.projects = projects));
    }
    onCreate() {
        this.service.initializeFormGroup();
        this.dialogService.openFormDialog(_project_form_project_form_component__WEBPACK_IMPORTED_MODULE_3__["ProjectFormComponent"]);
    }
    onEdit(project) {
        this.service.initializeFormGroup();
        this.service.populateForm(project);
        this.dialogService.openFormDialog(_project_form_project_form_component__WEBPACK_IMPORTED_MODULE_3__["ProjectFormComponent"]);
    }
    onDelete(id) {
        return tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            this.dialogService
                .openConfirmDialog(yield this.translate.get("common.r-u-sure").toPromise())
                .afterClosed()
                .subscribe((res) => tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
                if (res) {
                    this.httpService.deleteProject(id).subscribe(result => {
                        this.httpService
                            .getAllProjects()
                            .subscribe((projects) => (this.projects = projects));
                    });
                    this.notificationService.warn(yield this.translate.get("common.deleted-successfully").toPromise());
                }
            }));
        });
    }
    getProjectProgress(project) {
        return (project.donationsSum / project.donationTargetSum);
    }
};
ProjectComponent.ctorParameters = () => [
    { type: _core_http_http_http_service__WEBPACK_IMPORTED_MODULE_2__["HttpService"] },
    { type: _core_services_dialog_dialog_service__WEBPACK_IMPORTED_MODULE_5__["DialogService"] },
    { type: _core_http_project_project_service__WEBPACK_IMPORTED_MODULE_4__["ProjectService"] },
    { type: src_app_core_services_notification_notification_service__WEBPACK_IMPORTED_MODULE_7__["NotificationService"] },
    { type: _ngx_translate_core__WEBPACK_IMPORTED_MODULE_6__["TranslateService"] }
];
ProjectComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: "app-project",
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./project.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/project/project.component.html")).default,
        providers: [],
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./project.component.less */ "./src/app/modules/main/pages/project/project.component.less")).default]
    })
], ProjectComponent);



/***/ }),

/***/ "./src/app/modules/main/pages/resource/general-resources-tables/general-resources-inner-table/general-resources-inner-table.component.less":
/*!*************************************************************************************************************************************************!*\
  !*** ./src/app/modules/main/pages/resource/general-resources-tables/general-resources-inner-table/general-resources-inner-table.component.less ***!
  \*************************************************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("table {\n  width: 100%;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Jlc291cmNlL2dlbmVyYWwtcmVzb3VyY2VzLXRhYmxlcy9nZW5lcmFsLXJlc291cmNlcy1pbm5lci10YWJsZS9DOi9Eb2N1bWVudHMvR2l0SHViL3dpdGhvdXQgUGlyYW5oYS9UaGVyYUxhbmcvVGhlcmFMYW5nLldlYi9DbGllbnRBcHAvc3JjL2FwcC9tb2R1bGVzL21haW4vcGFnZXMvcmVzb3VyY2UvZ2VuZXJhbC1yZXNvdXJjZXMtdGFibGVzL2dlbmVyYWwtcmVzb3VyY2VzLWlubmVyLXRhYmxlL2dlbmVyYWwtcmVzb3VyY2VzLWlubmVyLXRhYmxlLmNvbXBvbmVudC5sZXNzIiwic3JjL2FwcC9tb2R1bGVzL21haW4vcGFnZXMvcmVzb3VyY2UvZ2VuZXJhbC1yZXNvdXJjZXMtdGFibGVzL2dlbmVyYWwtcmVzb3VyY2VzLWlubmVyLXRhYmxlL2dlbmVyYWwtcmVzb3VyY2VzLWlubmVyLXRhYmxlLmNvbXBvbmVudC5sZXNzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0ksV0FBQTtBQ0NKIiwiZmlsZSI6InNyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Jlc291cmNlL2dlbmVyYWwtcmVzb3VyY2VzLXRhYmxlcy9nZW5lcmFsLXJlc291cmNlcy1pbm5lci10YWJsZS9nZW5lcmFsLXJlc291cmNlcy1pbm5lci10YWJsZS5jb21wb25lbnQubGVzcyIsInNvdXJjZXNDb250ZW50IjpbInRhYmxle1xuICAgIHdpZHRoOiAxMDAlO1xufSIsInRhYmxlIHtcbiAgd2lkdGg6IDEwMCU7XG59XG4iXX0= */");

/***/ }),

/***/ "./src/app/modules/main/pages/resource/general-resources-tables/general-resources-inner-table/general-resources-inner-table.component.ts":
/*!***********************************************************************************************************************************************!*\
  !*** ./src/app/modules/main/pages/resource/general-resources-tables/general-resources-inner-table/general-resources-inner-table.component.ts ***!
  \***********************************************************************************************************************************************/
/*! exports provided: GeneralResourcesInnerTableComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "GeneralResourcesInnerTableComponent", function() { return GeneralResourcesInnerTableComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm2015/material.js");
/* harmony import */ var _configs_resources_table__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../../../../../configs/resources-table */ "./src/app/configs/resources-table.ts");
/* harmony import */ var src_app_core_http_resource_resource_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! src/app/core/http/resource/resource.service */ "./src/app/core/http/resource/resource.service.ts");





let GeneralResourcesInnerTableComponent = class GeneralResourcesInnerTableComponent {
    constructor(resourceService) {
        this.resourceService = resourceService;
        this.showTable = false;
        this.columnsPerPage = _configs_resources_table__WEBPACK_IMPORTED_MODULE_3__["ResourcesTableConstants"].COLUMNS_PER_PAGE;
        this.pageSizeOptions = _configs_resources_table__WEBPACK_IMPORTED_MODULE_3__["ResourcesTableConstants"].PAGE_SIZE_OPTIONS;
        this.displayedColumns = ["name", "date", "description", "url"];
    }
    ngOnInit() {
        return tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            this.resources = yield this.resourceService.getResourcesByCategoryId(this.resourcesCategoryId, _configs_resources_table__WEBPACK_IMPORTED_MODULE_3__["ResourcesTableConstants"].PAGE_NUMBER, _configs_resources_table__WEBPACK_IMPORTED_MODULE_3__["ResourcesTableConstants"].COLUMNS_PER_PAGE);
            this.allResourcesCount = yield this.resourceService.getResourcesCountByCategoryId(this.resourcesCategoryId);
            this.dataSource = new _angular_material__WEBPACK_IMPORTED_MODULE_2__["MatTableDataSource"](this.resources);
            this.dataSource.paginator = this.paginator;
            this.showTable = true;
        });
    }
    pageChanged(event) {
        return tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            this.resources = yield this.resourceService.getResourcesByCategoryId(this.resourcesCategoryId, event.pageIndex + 1, event.pageSize);
            this.allResourcesCount = yield this.resourceService.getResourcesCountByCategoryId(this.resourcesCategoryId);
            this.dataSource = new _angular_material__WEBPACK_IMPORTED_MODULE_2__["MatTableDataSource"](this.resources);
            this.dataSource.paginator = this.paginator;
        });
    }
};
GeneralResourcesInnerTableComponent.ctorParameters = () => [
    { type: src_app_core_http_resource_resource_service__WEBPACK_IMPORTED_MODULE_4__["ResourceService"] }
];
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])()
], GeneralResourcesInnerTableComponent.prototype, "resourcesCategoryId", void 0);
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])(_angular_material__WEBPACK_IMPORTED_MODULE_2__["MatPaginator"], { static: true })
], GeneralResourcesInnerTableComponent.prototype, "paginator", void 0);
GeneralResourcesInnerTableComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: "app-general-resources-inner-table",
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./general-resources-inner-table.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/resource/general-resources-tables/general-resources-inner-table/general-resources-inner-table.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./general-resources-inner-table.component.less */ "./src/app/modules/main/pages/resource/general-resources-tables/general-resources-inner-table/general-resources-inner-table.component.less")).default]
    })
], GeneralResourcesInnerTableComponent);



/***/ }),

/***/ "./src/app/modules/main/pages/resource/general-resources-tables/general-resources-table/general-resources-table.component.less":
/*!*************************************************************************************************************************************!*\
  !*** ./src/app/modules/main/pages/resource/general-resources-tables/general-resources-table/general-resources-table.component.less ***!
  \*************************************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".mat-tab-label-content {\n  color: black !important;\n}\n.mat-stroked-button {\n  background-color: #8b9396;\n  margin-left: 15px;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Jlc291cmNlL2dlbmVyYWwtcmVzb3VyY2VzLXRhYmxlcy9nZW5lcmFsLXJlc291cmNlcy10YWJsZS9DOi9Eb2N1bWVudHMvR2l0SHViL3dpdGhvdXQgUGlyYW5oYS9UaGVyYUxhbmcvVGhlcmFMYW5nLldlYi9DbGllbnRBcHAvc3JjL2FwcC9tb2R1bGVzL21haW4vcGFnZXMvcmVzb3VyY2UvZ2VuZXJhbC1yZXNvdXJjZXMtdGFibGVzL2dlbmVyYWwtcmVzb3VyY2VzLXRhYmxlL2dlbmVyYWwtcmVzb3VyY2VzLXRhYmxlLmNvbXBvbmVudC5sZXNzIiwic3JjL2FwcC9tb2R1bGVzL21haW4vcGFnZXMvcmVzb3VyY2UvZ2VuZXJhbC1yZXNvdXJjZXMtdGFibGVzL2dlbmVyYWwtcmVzb3VyY2VzLXRhYmxlL2dlbmVyYWwtcmVzb3VyY2VzLXRhYmxlLmNvbXBvbmVudC5sZXNzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0ksdUJBQUE7QUNDSjtBREVFO0VBQ0UseUJBQUE7RUFDQSxpQkFBQTtBQ0FKIiwiZmlsZSI6InNyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Jlc291cmNlL2dlbmVyYWwtcmVzb3VyY2VzLXRhYmxlcy9nZW5lcmFsLXJlc291cmNlcy10YWJsZS9nZW5lcmFsLXJlc291cmNlcy10YWJsZS5jb21wb25lbnQubGVzcyIsInNvdXJjZXNDb250ZW50IjpbIi5tYXQtdGFiLWxhYmVsLWNvbnRlbnQge1xuICAgIGNvbG9yOiBibGFjayAhaW1wb3J0YW50O1xuICB9XG5cbiAgLm1hdC1zdHJva2VkLWJ1dHRvbiB7XG4gICAgYmFja2dyb3VuZC1jb2xvcjogcmdiKDEzOSwgMTQ3LCAxNTApO1xuICAgIG1hcmdpbi1sZWZ0OiAxNXB4O1xufSIsIi5tYXQtdGFiLWxhYmVsLWNvbnRlbnQge1xuICBjb2xvcjogYmxhY2sgIWltcG9ydGFudDtcbn1cbi5tYXQtc3Ryb2tlZC1idXR0b24ge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjOGI5Mzk2O1xuICBtYXJnaW4tbGVmdDogMTVweDtcbn1cbiJdfQ== */");

/***/ }),

/***/ "./src/app/modules/main/pages/resource/general-resources-tables/general-resources-table/general-resources-table.component.ts":
/*!***********************************************************************************************************************************!*\
  !*** ./src/app/modules/main/pages/resource/general-resources-tables/general-resources-table/general-resources-table.component.ts ***!
  \***********************************************************************************************************************************/
/*! exports provided: GeneralResourcesTableComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "GeneralResourcesTableComponent", function() { return GeneralResourcesTableComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _configs_resources_table__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../../../../configs/resources-table */ "./src/app/configs/resources-table.ts");
/* harmony import */ var _resource_create_resource_create_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../resource-create/resource-create.component */ "./src/app/modules/main/pages/resource/resource-create/resource-create.component.ts");
/* harmony import */ var src_app_core_http_resource_resource_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! src/app/core/http/resource/resource.service */ "./src/app/core/http/resource/resource.service.ts");
/* harmony import */ var src_app_core_services_resource_resource_categories_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! src/app/core/services/resource/resource-categories.service */ "./src/app/core/services/resource/resource-categories.service.ts");
/* harmony import */ var src_app_core_services_dialog_dialog_service__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! src/app/core/services/dialog/dialog.service */ "./src/app/core/services/dialog/dialog.service.ts");
/* harmony import */ var src_app_core_http_resource_resource_create_service__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! src/app/core/http/resource/resource-create.service */ "./src/app/core/http/resource/resource-create.service.ts");








let GeneralResourcesTableComponent = class GeneralResourcesTableComponent {
    constructor(resourceService, resourceCategoriesService, resourceCreateService, dialogService) {
        this.resourceService = resourceService;
        this.resourceCategoriesService = resourceCategoriesService;
        this.resourceCreateService = resourceCreateService;
        this.dialogService = dialogService;
        this.showCategories = false;
    }
    ngOnInit() {
        return tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            this.resourcesCategories = yield this.resourceCategoriesService.getResourceCategories(_configs_resources_table__WEBPACK_IMPORTED_MODULE_2__["ResourcesTableConstants"].WITH_ASSIGNED_RESOURCES);
            this.showCategories = true;
        });
    }
    addResource() {
        this.resourceCreateService.initializeForm();
        this.dialogService.openFormDialog(_resource_create_resource_create_component__WEBPACK_IMPORTED_MODULE_3__["ResourceCreateComponent"]);
    }
};
GeneralResourcesTableComponent.ctorParameters = () => [
    { type: src_app_core_http_resource_resource_service__WEBPACK_IMPORTED_MODULE_4__["ResourceService"] },
    { type: src_app_core_services_resource_resource_categories_service__WEBPACK_IMPORTED_MODULE_5__["ResourceCategoriesService"] },
    { type: src_app_core_http_resource_resource_create_service__WEBPACK_IMPORTED_MODULE_7__["ResourceCreateService"] },
    { type: src_app_core_services_dialog_dialog_service__WEBPACK_IMPORTED_MODULE_6__["DialogService"] }
];
GeneralResourcesTableComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: "app-general-resources-table",
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./general-resources-table.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/resource/general-resources-tables/general-resources-table/general-resources-table.component.html")).default,
        encapsulation: _angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewEncapsulation"].None,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./general-resources-table.component.less */ "./src/app/modules/main/pages/resource/general-resources-tables/general-resources-table/general-resources-table.component.less")).default]
    })
], GeneralResourcesTableComponent);



/***/ }),

/***/ "./src/app/modules/main/pages/resource/general-resources.component.less":
/*!******************************************************************************!*\
  !*** ./src/app/modules/main/pages/resource/general-resources.component.less ***!
  \******************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".mat-tab-label-content {\n  color: black !important;\n}\n#resTabId {\n  max-width: 1230px;\n  margin: 0 auto;\n  min-height: 20rem;\n}\napp-resources-table .resTab {\n  border-radius: 25px ;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Jlc291cmNlL0M6L0RvY3VtZW50cy9HaXRIdWIvd2l0aG91dCBQaXJhbmhhL1RoZXJhTGFuZy9UaGVyYUxhbmcuV2ViL0NsaWVudEFwcC9zcmMvYXBwL21vZHVsZXMvbWFpbi9wYWdlcy9yZXNvdXJjZS9nZW5lcmFsLXJlc291cmNlcy5jb21wb25lbnQubGVzcyIsInNyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Jlc291cmNlL2dlbmVyYWwtcmVzb3VyY2VzLmNvbXBvbmVudC5sZXNzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0ksdUJBQUE7QUNDSjtBRENFO0VBQ0UsaUJBQUE7RUFDQSxjQUFBO0VBQ0EsaUJBQUE7QUNDSjtBRENFO0VBQ0Usb0JBQUE7QUNDSiIsImZpbGUiOiJzcmMvYXBwL21vZHVsZXMvbWFpbi9wYWdlcy9yZXNvdXJjZS9nZW5lcmFsLXJlc291cmNlcy5jb21wb25lbnQubGVzcyIsInNvdXJjZXNDb250ZW50IjpbIi5tYXQtdGFiLWxhYmVsLWNvbnRlbnQge1xuICAgIGNvbG9yOiBibGFjayAhaW1wb3J0YW50O1xuICB9XG4gICNyZXNUYWJJZHtcbiAgICBtYXgtd2lkdGg6IDEyMzBweDtcbiAgICBtYXJnaW46IDAgYXV0bztcbiAgICBtaW4taGVpZ2h0OiAyMHJlbTtcbiAgfVxuICBhcHAtcmVzb3VyY2VzLXRhYmxlIC5yZXNUYWJ7XG4gICAgYm9yZGVyLXJhZGl1czogMjVweCA7XG4gIH0iLCIubWF0LXRhYi1sYWJlbC1jb250ZW50IHtcbiAgY29sb3I6IGJsYWNrICFpbXBvcnRhbnQ7XG59XG4jcmVzVGFiSWQge1xuICBtYXgtd2lkdGg6IDEyMzBweDtcbiAgbWFyZ2luOiAwIGF1dG87XG4gIG1pbi1oZWlnaHQ6IDIwcmVtO1xufVxuYXBwLXJlc291cmNlcy10YWJsZSAucmVzVGFiIHtcbiAgYm9yZGVyLXJhZGl1czogMjVweCA7XG59XG4iXX0= */");

/***/ }),

/***/ "./src/app/modules/main/pages/resource/general-resources.component.ts":
/*!****************************************************************************!*\
  !*** ./src/app/modules/main/pages/resource/general-resources.component.ts ***!
  \****************************************************************************/
/*! exports provided: GeneralResourcesComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "GeneralResourcesComponent", function() { return GeneralResourcesComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var src_app_core_http_resource_resource_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! src/app/core/http/resource/resource.service */ "./src/app/core/http/resource/resource.service.ts");



let GeneralResourcesComponent = class GeneralResourcesComponent {
    constructor(resourceService) {
        this.resourceService = resourceService;
        this.sortedResourcesByCategory = [];
    }
    ngOnInit() {
        return tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            const allResources = yield this.resourceService.getAllResourcesByProjId(null);
            this.sortedResourcesByCategory = this.resourceService.sortAllResourcesByCategories(allResources);
        });
    }
};
GeneralResourcesComponent.ctorParameters = () => [
    { type: src_app_core_http_resource_resource_service__WEBPACK_IMPORTED_MODULE_2__["ResourceService"] }
];
GeneralResourcesComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: "app-general-resources",
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./general-resources.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/resource/general-resources.component.html")).default,
        encapsulation: _angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewEncapsulation"].None,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./general-resources.component.less */ "./src/app/modules/main/pages/resource/general-resources.component.less")).default]
    })
], GeneralResourcesComponent);



/***/ }),

/***/ "./src/app/modules/main/pages/resource/resource-create/resource-create.component.less":
/*!********************************************************************************************!*\
  !*** ./src/app/modules/main/pages/resource/resource-create/resource-create.component.less ***!
  \********************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".submitButton {\n  padding-top: 40px;\n  float: right;\n}\ninput[type=file] {\n  display: none;\n}\n.file-name {\n  padding-left: 15px;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Jlc291cmNlL3Jlc291cmNlLWNyZWF0ZS9DOi9Eb2N1bWVudHMvR2l0SHViL3dpdGhvdXQgUGlyYW5oYS9UaGVyYUxhbmcvVGhlcmFMYW5nLldlYi9DbGllbnRBcHAvc3JjL2FwcC9tb2R1bGVzL21haW4vcGFnZXMvcmVzb3VyY2UvcmVzb3VyY2UtY3JlYXRlL3Jlc291cmNlLWNyZWF0ZS5jb21wb25lbnQubGVzcyIsInNyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Jlc291cmNlL3Jlc291cmNlLWNyZWF0ZS9yZXNvdXJjZS1jcmVhdGUuY29tcG9uZW50Lmxlc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDSSxpQkFBQTtFQUNBLFlBQUE7QUNDSjtBREVBO0VBQ0ksYUFBQTtBQ0FKO0FER0E7RUFDSSxrQkFBQTtBQ0RKIiwiZmlsZSI6InNyYy9hcHAvbW9kdWxlcy9tYWluL3BhZ2VzL3Jlc291cmNlL3Jlc291cmNlLWNyZWF0ZS9yZXNvdXJjZS1jcmVhdGUuY29tcG9uZW50Lmxlc3MiLCJzb3VyY2VzQ29udGVudCI6WyIuc3VibWl0QnV0dG9ue1xuICAgIHBhZGRpbmctdG9wOiA0MHB4O1xuICAgIGZsb2F0OiByaWdodDtcbn1cblxuaW5wdXRbdHlwZT1maWxlXSB7XG4gICAgZGlzcGxheTogbm9uZTtcbn1cblxuLmZpbGUtbmFtZSB7XG4gICAgcGFkZGluZy1sZWZ0OiAxNXB4O1xufSIsIi5zdWJtaXRCdXR0b24ge1xuICBwYWRkaW5nLXRvcDogNDBweDtcbiAgZmxvYXQ6IHJpZ2h0O1xufVxuaW5wdXRbdHlwZT1maWxlXSB7XG4gIGRpc3BsYXk6IG5vbmU7XG59XG4uZmlsZS1uYW1lIHtcbiAgcGFkZGluZy1sZWZ0OiAxNXB4O1xufVxuIl19 */");

/***/ }),

/***/ "./src/app/modules/main/pages/resource/resource-create/resource-create.component.ts":
/*!******************************************************************************************!*\
  !*** ./src/app/modules/main/pages/resource/resource-create/resource-create.component.ts ***!
  \******************************************************************************************/
/*! exports provided: ResourceCreateComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourceCreateComponent", function() { return ResourceCreateComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_material_dialog__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/material/dialog */ "./node_modules/@angular/material/esm2015/dialog.js");
/* harmony import */ var src_app_core_http_resource_resource_create_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! src/app/core/http/resource/resource-create.service */ "./src/app/core/http/resource/resource-create.service.ts");




let ResourceCreateComponent = class ResourceCreateComponent {
    constructor(dialog, service) {
        this.dialog = dialog;
        this.service = service;
    }
    ngOnInit() {
        this.service
            .getCategories()
            .subscribe((categories) => (this.categories = categories));
    }
    onClose() {
        this.service.resourceForm.reset();
        this.service.initializeForm();
        this.dialog.close();
    }
    onFileChange(fileInput) {
        let file = fileInput.target.files[0];
        this.fileName = file.name;
    }
    onSubmit() {
        if (this.service.resourceForm.invalid) {
            const controls = this.service.resourceForm.controls;
            Object.keys(controls).forEach(controlName => controls[controlName].markAsTouched());
            return;
        }
        else {
            const resource = this.service.resourceForm.value;
            if (resource.file != null) {
                resource.file = this.service.resourceForm.value.file.files[0];
            }
            if (this.service.resourceForm.get("url").disabled) {
                resource.url = "";
            }
            this.service.addResource(resource);
            this.onClose();
        }
    }
};
ResourceCreateComponent.ctorParameters = () => [
    { type: _angular_material_dialog__WEBPACK_IMPORTED_MODULE_2__["MatDialogRef"] },
    { type: src_app_core_http_resource_resource_create_service__WEBPACK_IMPORTED_MODULE_3__["ResourceCreateService"] }
];
ResourceCreateComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: "app-resource-create",
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./resource-create.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/main/pages/resource/resource-create/resource-create.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./resource-create.component.less */ "./src/app/modules/main/pages/resource/resource-create/resource-create.component.less")).default]
    })
], ResourceCreateComponent);



/***/ }),

/***/ "./src/app/modules/manager/manager.component.less":
/*!********************************************************!*\
  !*** ./src/app/modules/manager/manager.component.less ***!
  \********************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL21vZHVsZXMvbWFuYWdlci9tYW5hZ2VyLmNvbXBvbmVudC5sZXNzIn0= */");

/***/ }),

/***/ "./src/app/modules/manager/manager.component.ts":
/*!******************************************************!*\
  !*** ./src/app/modules/manager/manager.component.ts ***!
  \******************************************************/
/*! exports provided: ManagerComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ManagerComponent", function() { return ManagerComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let ManagerComponent = class ManagerComponent {
    constructor() { }
    ngOnInit() {
    }
};
ManagerComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-manager',
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./manager.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/manager/manager.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./manager.component.less */ "./src/app/modules/manager/manager.component.less")).default]
    })
], ManagerComponent);



/***/ }),

/***/ "./src/app/modules/manager/page-manager/create-page/create-page.component.less":
/*!*************************************************************************************!*\
  !*** ./src/app/modules/manager/page-manager/create-page/create-page.component.less ***!
  \*************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("form {\n  max-width: 600px;\n  margin: 0 auto;\n}\n.form-control {\n  margin-top: 60px;\n}\ninput {\n  display: block;\n  width: 100%;\n  padding: 0.4rem;\n  font-size: 1.2rem;\n  border: 1px solid #ccc;\n}\n.content {\n  min-height: 30px;\n  min-width: 30px;\n  resize: both;\n  overflow: auto;\n  max-height: -webkit-fit-content;\n  max-height: -moz-fit-content;\n  max-height: fit-content;\n  max-width: -webkit-fit-content;\n  max-width: -moz-fit-content;\n  max-width: fit-content;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvbW9kdWxlcy9tYW5hZ2VyL3BhZ2UtbWFuYWdlci9jcmVhdGUtcGFnZS9DOi9Eb2N1bWVudHMvR2l0SHViL3dpdGhvdXQgUGlyYW5oYS9UaGVyYUxhbmcvVGhlcmFMYW5nLldlYi9DbGllbnRBcHAvc3JjL2FwcC9tb2R1bGVzL21hbmFnZXIvcGFnZS1tYW5hZ2VyL2NyZWF0ZS1wYWdlL2NyZWF0ZS1wYWdlLmNvbXBvbmVudC5sZXNzIiwic3JjL2FwcC9tb2R1bGVzL21hbmFnZXIvcGFnZS1tYW5hZ2VyL2NyZWF0ZS1wYWdlL2NyZWF0ZS1wYWdlLmNvbXBvbmVudC5sZXNzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0ksZ0JBQUE7RUFDQSxjQUFBO0FDQ0o7QURFQTtFQUNFLGdCQUFBO0FDQUY7QURHQTtFQUNFLGNBQUE7RUFDQSxXQUFBO0VBQ0EsZUFBQTtFQUNBLGlCQUFBO0VBQ0Esc0JBQUE7QUNERjtBRElBO0VBQ0UsZ0JBQUE7RUFDQSxlQUFBO0VBQ0EsWUFBQTtFQUNBLGNBQUE7RUFDQSwrQkFBQTtFQUFBLDRCQUFBO0VBQUEsdUJBQUE7RUFDQSw4QkFBQTtFQUFBLDJCQUFBO0VBQUEsc0JBQUE7QUNGRiIsImZpbGUiOiJzcmMvYXBwL21vZHVsZXMvbWFuYWdlci9wYWdlLW1hbmFnZXIvY3JlYXRlLXBhZ2UvY3JlYXRlLXBhZ2UuY29tcG9uZW50Lmxlc3MiLCJzb3VyY2VzQ29udGVudCI6WyJmb3JtIHtcbiAgICBtYXgtd2lkdGg6IDYwMHB4O1xuICAgIG1hcmdpbjogMCBhdXRvO1xuICB9XG4gIFxuLmZvcm0tY29udHJvbCB7XG4gIG1hcmdpbi10b3A6IDYwcHg7XG59XG5cbmlucHV0IHtcbiAgZGlzcGxheTogYmxvY2s7XG4gIHdpZHRoOiAxMDAlO1xuICBwYWRkaW5nOiAwLjRyZW07XG4gIGZvbnQtc2l6ZTogMS4ycmVtO1xuICBib3JkZXI6IDFweCBzb2xpZCAjY2NjO1xufVxuXG4uY29udGVudCB7XG4gIG1pbi1oZWlnaHQ6IDMwcHg7XG4gIG1pbi13aWR0aDogMzBweDtcbiAgcmVzaXplOiBib3RoO1xuICBvdmVyZmxvdzogYXV0bztcbiAgbWF4LWhlaWdodDogZml0LWNvbnRlbnQ7XG4gIG1heC13aWR0aDogZml0LWNvbnRlbnQ7XG59IiwiZm9ybSB7XG4gIG1heC13aWR0aDogNjAwcHg7XG4gIG1hcmdpbjogMCBhdXRvO1xufVxuLmZvcm0tY29udHJvbCB7XG4gIG1hcmdpbi10b3A6IDYwcHg7XG59XG5pbnB1dCB7XG4gIGRpc3BsYXk6IGJsb2NrO1xuICB3aWR0aDogMTAwJTtcbiAgcGFkZGluZzogMC40cmVtO1xuICBmb250LXNpemU6IDEuMnJlbTtcbiAgYm9yZGVyOiAxcHggc29saWQgI2NjYztcbn1cbi5jb250ZW50IHtcbiAgbWluLWhlaWdodDogMzBweDtcbiAgbWluLXdpZHRoOiAzMHB4O1xuICByZXNpemU6IGJvdGg7XG4gIG92ZXJmbG93OiBhdXRvO1xuICBtYXgtaGVpZ2h0OiBmaXQtY29udGVudDtcbiAgbWF4LXdpZHRoOiBmaXQtY29udGVudDtcbn1cbiJdfQ== */");

/***/ }),

/***/ "./src/app/modules/manager/page-manager/create-page/create-page.component.ts":
/*!***********************************************************************************!*\
  !*** ./src/app/modules/manager/page-manager/create-page/create-page.component.ts ***!
  \***********************************************************************************/
/*! exports provided: CreatePageComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CreatePageComponent", function() { return CreatePageComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm2015/forms.js");
/* harmony import */ var src_app_core_http_page_page_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! src/app/core/http/page/page.service */ "./src/app/core/http/page/page.service.ts");




let CreatePageComponent = class CreatePageComponent {
    constructor(pageService) {
        this.pageService = pageService;
    }
    ngOnInit() {
        this.form = new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormGroup"]({
            title: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](null, _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required),
            text: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](null, _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required),
            author: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](null, _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required)
        });
    }
    submit() {
        const page = {
            title: this.form.value.title,
            text: this.form.value.text,
            date: new Date()
        };
        console.log(page);
    }
};
CreatePageComponent.ctorParameters = () => [
    { type: src_app_core_http_page_page_service__WEBPACK_IMPORTED_MODULE_3__["PageService"] }
];
CreatePageComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-create-page',
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./create-page.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/manager/page-manager/create-page/create-page.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./create-page.component.less */ "./src/app/modules/manager/page-manager/create-page/create-page.component.less")).default]
    })
], CreatePageComponent);



/***/ }),

/***/ "./src/app/modules/manager/page-manager/page-manager.component.less":
/*!**************************************************************************!*\
  !*** ./src/app/modules/manager/page-manager/page-manager.component.less ***!
  \**************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL21vZHVsZXMvbWFuYWdlci9wYWdlLW1hbmFnZXIvcGFnZS1tYW5hZ2VyLmNvbXBvbmVudC5sZXNzIn0= */");

/***/ }),

/***/ "./src/app/modules/manager/page-manager/page-manager.component.ts":
/*!************************************************************************!*\
  !*** ./src/app/modules/manager/page-manager/page-manager.component.ts ***!
  \************************************************************************/
/*! exports provided: PageManagerComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PageManagerComponent", function() { return PageManagerComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");



let PageManagerComponent = class PageManagerComponent {
    constructor(router) {
        this.router = router;
    }
    ngOnInit() {
    }
};
PageManagerComponent.ctorParameters = () => [
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"] }
];
PageManagerComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-page-manager',
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./page-manager.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/modules/manager/page-manager/page-manager.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./page-manager.component.less */ "./src/app/modules/manager/page-manager/page-manager.component.less")).default]
    })
], PageManagerComponent);



/***/ }),

/***/ "./src/app/shared/components/confirm-dialog/confirm-dialog.component.less":
/*!********************************************************************************!*\
  !*** ./src/app/shared/components/confirm-dialog/confirm-dialog.component.less ***!
  \********************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3NoYXJlZC9jb21wb25lbnRzL2NvbmZpcm0tZGlhbG9nL2NvbmZpcm0tZGlhbG9nLmNvbXBvbmVudC5sZXNzIn0= */");

/***/ }),

/***/ "./src/app/shared/components/confirm-dialog/confirm-dialog.component.ts":
/*!******************************************************************************!*\
  !*** ./src/app/shared/components/confirm-dialog/confirm-dialog.component.ts ***!
  \******************************************************************************/
/*! exports provided: ConfirmDialogComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ConfirmDialogComponent", function() { return ConfirmDialogComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm2015/material.js");



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
ConfirmDialogComponent.ctorParameters = () => [
    { type: _angular_material__WEBPACK_IMPORTED_MODULE_2__["MatDialogRef"] },
    { type: undefined, decorators: [{ type: _angular_core__WEBPACK_IMPORTED_MODULE_1__["Inject"], args: [_angular_material__WEBPACK_IMPORTED_MODULE_2__["MAT_DIALOG_DATA"],] }] }
];
ConfirmDialogComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-confirm-dialog',
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./confirm-dialog.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/shared/components/confirm-dialog/confirm-dialog.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./confirm-dialog.component.less */ "./src/app/shared/components/confirm-dialog/confirm-dialog.component.less")).default]
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__param"](1, Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Inject"])(_angular_material__WEBPACK_IMPORTED_MODULE_2__["MAT_DIALOG_DATA"]))
], ConfirmDialogComponent);



/***/ }),

/***/ "./src/app/shared/components/error/error.component.less":
/*!**************************************************************!*\
  !*** ./src/app/shared/components/error/error.component.less ***!
  \**************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3NoYXJlZC9jb21wb25lbnRzL2Vycm9yL2Vycm9yLmNvbXBvbmVudC5sZXNzIn0= */");

/***/ }),

/***/ "./src/app/shared/components/error/error.component.ts":
/*!************************************************************!*\
  !*** ./src/app/shared/components/error/error.component.ts ***!
  \************************************************************/
/*! exports provided: ErrorComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ErrorComponent", function() { return ErrorComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");



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
ErrorComponent.ctorParameters = () => [
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"] }
];
ErrorComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-error',
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./error.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/shared/components/error/error.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./error.component.less */ "./src/app/shared/components/error/error.component.less")).default]
    })
], ErrorComponent);



/***/ }),

/***/ "./src/app/shared/components/transaction-result/transaction-result.component.less":
/*!****************************************************************************************!*\
  !*** ./src/app/shared/components/transaction-result/transaction-result.component.less ***!
  \****************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".status-color {\n  color: green;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvc2hhcmVkL2NvbXBvbmVudHMvdHJhbnNhY3Rpb24tcmVzdWx0L0M6L0RvY3VtZW50cy9HaXRIdWIvd2l0aG91dCBQaXJhbmhhL1RoZXJhTGFuZy9UaGVyYUxhbmcuV2ViL0NsaWVudEFwcC9zcmMvYXBwL3NoYXJlZC9jb21wb25lbnRzL3RyYW5zYWN0aW9uLXJlc3VsdC90cmFuc2FjdGlvbi1yZXN1bHQuY29tcG9uZW50Lmxlc3MiLCJzcmMvYXBwL3NoYXJlZC9jb21wb25lbnRzL3RyYW5zYWN0aW9uLXJlc3VsdC90cmFuc2FjdGlvbi1yZXN1bHQuY29tcG9uZW50Lmxlc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDSSxZQUFBO0FDQ0oiLCJmaWxlIjoic3JjL2FwcC9zaGFyZWQvY29tcG9uZW50cy90cmFuc2FjdGlvbi1yZXN1bHQvdHJhbnNhY3Rpb24tcmVzdWx0LmNvbXBvbmVudC5sZXNzIiwic291cmNlc0NvbnRlbnQiOlsiLnN0YXR1cy1jb2xvcntcbiAgICBjb2xvcjogZ3JlZW47XG59IiwiLnN0YXR1cy1jb2xvciB7XG4gIGNvbG9yOiBncmVlbjtcbn1cbiJdfQ== */");

/***/ }),

/***/ "./src/app/shared/components/transaction-result/transaction-result.component.ts":
/*!**************************************************************************************!*\
  !*** ./src/app/shared/components/transaction-result/transaction-result.component.ts ***!
  \**************************************************************************************/
/*! exports provided: TransactionResultComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "TransactionResultComponent", function() { return TransactionResultComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _core_http_donations_donation_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../core/http/donations/donation.service */ "./src/app/core/http/donations/donation.service.ts");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");




let TransactionResultComponent = class TransactionResultComponent {
    constructor(route, donationService) {
        this.route = route;
        this.donationService = donationService;
    }
    ngOnInit() {
        this.route.paramMap.subscribe(params => {
            this.donationId = params.get("donationId");
            this.donationService
                .getDonationTransaction(this.donationId)
                .subscribe((liqpayResponseData) => {
                this.liqpayResponse = liqpayResponseData;
            });
        });
    }
};
TransactionResultComponent.ctorParameters = () => [
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_3__["ActivatedRoute"] },
    { type: _core_http_donations_donation_service__WEBPACK_IMPORTED_MODULE_2__["DonationService"] }
];
TransactionResultComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: "app-transaction-result",
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./transaction-result.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/shared/components/transaction-result/transaction-result.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./transaction-result.component.less */ "./src/app/shared/components/transaction-result/transaction-result.component.less")).default]
    })
], TransactionResultComponent);



/***/ }),

/***/ "./src/app/shared/directives/files/atleastone-form.directive..ts":
/*!***********************************************************************!*\
  !*** ./src/app/shared/directives/files/atleastone-form.directive..ts ***!
  \***********************************************************************/
/*! exports provided: atLeastOne */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "atLeastOne", function() { return atLeastOne; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");

const atLeastOne = (validator, controls = null) => (group) => {
    if (!controls) {
        controls = Object.keys(group.controls);
    }
    const hasAtLeastOne = group &&
        group.controls &&
        controls.some(k => !validator(group.controls[k]));
    return hasAtLeastOne
        ? null
        : {
            atLeastOne: true
        };
};


/***/ }),

/***/ "./src/app/shared/directives/files/forbidden-extension.directive.ts":
/*!**************************************************************************!*\
  !*** ./src/app/shared/directives/files/forbidden-extension.directive.ts ***!
  \**************************************************************************/
/*! exports provided: forbiddenExtensionValidator */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "forbiddenExtensionValidator", function() { return forbiddenExtensionValidator; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");

function forbiddenExtensionValidator(exts) {
    return (control) => {
        try {
            if (control.value == null) {
                return null;
            }
            const filename = control.value.files[0].name;
            const forbidden = exts.test(filename);
            return forbidden ? { forbiddenName: { value: filename } } : null;
        }
        catch (error) { }
    };
}


/***/ }),

/***/ "./src/app/shared/guards/auth-guard.service.ts":
/*!*****************************************************!*\
  !*** ./src/app/shared/guards/auth-guard.service.ts ***!
  \*****************************************************/
/*! exports provided: AuthGuard */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AuthGuard", function() { return AuthGuard; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var _auth0_angular_jwt__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @auth0/angular-jwt */ "./node_modules/@auth0/angular-jwt/index.js");




let AuthGuard = class AuthGuard {
    constructor(jwtHelper, router) {
        this.jwtHelper = jwtHelper;
        this.router = router;
    }
    canActivate() {
        var token = localStorage.getItem("jwt");
        if (token && !this.jwtHelper.isTokenExpired(token)) {
            console.log(this.jwtHelper.decodeToken(token));
            return true;
        }
        this.router.navigate(["login"]);
        return false;
    }
};
AuthGuard.ctorParameters = () => [
    { type: _auth0_angular_jwt__WEBPACK_IMPORTED_MODULE_3__["JwtHelperService"] },
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"] }
];
AuthGuard = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])()
], AuthGuard);



/***/ }),

/***/ "./src/app/shared/models/project-type/project-type.model.ts":
/*!******************************************************************!*\
  !*** ./src/app/shared/models/project-type/project-type.model.ts ***!
  \******************************************************************/
/*! exports provided: ProjectType */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectType", function() { return ProjectType; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");

class ProjectType {
}


/***/ }),

/***/ "./src/app/shared/pipes/custom.datepipe.ts":
/*!*************************************************!*\
  !*** ./src/app/shared/pipes/custom.datepipe.ts ***!
  \*************************************************/
/*! exports provided: CustomDatePipe */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CustomDatePipe", function() { return CustomDatePipe; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm2015/common.js");
/* harmony import */ var src_app_configs_date_formats__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! src/app/configs/date-formats */ "./src/app/configs/date-formats.ts");




let CustomDatePipe = class CustomDatePipe extends _angular_common__WEBPACK_IMPORTED_MODULE_2__["DatePipe"] {
    transform(value, args) {
        return super.transform(value, src_app_configs_date_formats__WEBPACK_IMPORTED_MODULE_3__["LONG_DATE_STRING"]);
    }
};
CustomDatePipe = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Pipe"])({
        name: "customDate"
    })
], CustomDatePipe);



/***/ }),

/***/ "./src/environments/environment.ts":
/*!*****************************************!*\
  !*** ./src/environments/environment.ts ***!
  \*****************************************/
/*! exports provided: environment */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "environment", function() { return environment; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

const environment = {
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


/***/ }),

/***/ "./src/main.ts":
/*!*********************!*\
  !*** ./src/main.ts ***!
  \*********************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

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
    .catch(err => console.error(err));


/***/ }),

/***/ 0:
/*!***************************!*\
  !*** multi ./src/main.ts ***!
  \***************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! C:\Documents\GitHub\without Piranha\TheraLang\TheraLang.Web\ClientApp\src\main.ts */"./src/main.ts");


/***/ })

},[[0,"runtime","vendor"]]]);
//# sourceMappingURL=main-es2016.js.map