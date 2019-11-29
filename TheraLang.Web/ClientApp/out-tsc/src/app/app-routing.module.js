import { __decorate } from "tslib";
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ProjectComponent } from './project/project.component';
import { HomeComponent } from './home/home.component';
import { ProjectInfoComponent } from './project-info/project-info.component';
import { ProjectParticipantsComponent } from './project-participants/project-participants.component';
import { CmsModule } from './cms/cms.module';
import { GeneralResourcesTableComponent } from './general-resources/general-resources-tables/general-resources-table/general-resources-table.component';
import { ErrorComponent } from './shared/components/error/error.component';
import { ProjectTypeComponent } from './project-info/resources-table-for-project/project-type/project-type.component';
import { GeneralResourcesComponent } from './general-resources/general-resources.component';
const routes = [
    { path: '', component: HomeComponent },
    { path: 'projectParticipants', component: ProjectParticipantsComponent },
    { path: 'project/:id', component: ProjectInfoComponent },
    { path: 'project', component: ProjectComponent },
    { path: 'resources', component: GeneralResourcesTableComponent },
    { path: 'error', component: ErrorComponent },
    { path: '**', loadChildren: () => CmsModule },
    { path: 'projectTypes', component: ProjectTypeComponent }
];
let AppRoutingModule = class AppRoutingModule {
};
AppRoutingModule = __decorate([
    NgModule({
        imports: [RouterModule.forRoot(routes)],
        exports: [RouterModule],
    })
], AppRoutingModule);
export { AppRoutingModule };
export const routingComponents = [
    ProjectParticipantsComponent, ProjectComponent, HomeComponent, ProjectInfoComponent,
    GeneralResourcesComponent, ErrorComponent, ProjectTypeComponent
];
//# sourceMappingURL=app-routing.module.js.map