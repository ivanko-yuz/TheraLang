import { __decorate } from "tslib";
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CmsGenericPageComponent } from './components/cms-generic-page/cms-generic-page.component';
const routes = [
    { path: '**', component: CmsGenericPageComponent }
];
let CmsRoutingModule = class CmsRoutingModule {
};
CmsRoutingModule = __decorate([
    NgModule({
        imports: [RouterModule.forChild(routes)],
        exports: [RouterModule]
    })
], CmsRoutingModule);
export { CmsRoutingModule };
//# sourceMappingURL=cms-routing.module.js.map