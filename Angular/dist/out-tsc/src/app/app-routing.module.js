import * as tslib_1 from "tslib";
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ProjectComponent } from './project/project.component';
import { HomeComponent } from './home/home.component';
import { ProjectInfoComponent } from './project-info/project-info.component';
import { ResourcesComponent } from './resources/resources.component';
const routes = [
    { path: '', component: HomeComponent },
    { path: 'project/:id', component: ProjectInfoComponent },
    { path: 'project', component: ProjectComponent },
    { path: 'resources', component: ResourcesComponent },
];
let AppRoutingModule = class AppRoutingModule {
};
AppRoutingModule = tslib_1.__decorate([
    NgModule({
        imports: [RouterModule.forRoot(routes)],
        exports: [RouterModule]
    })
], AppRoutingModule);
export { AppRoutingModule };
export const routingComponents = [ProjectComponent, HomeComponent, ResourcesComponent];
//# sourceMappingURL=app-routing.module.js.map