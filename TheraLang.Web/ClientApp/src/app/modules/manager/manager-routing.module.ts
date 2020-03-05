import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { CreatePageComponent } from "./page-manager/create-page/create-page.component";
import { ManagerComponent } from "./manager.component";
import { SitemapEditorComponent } from "./sitemap-editor/sitemap-editor.component";
import { PageManagerComponent } from "./page-manager/page-manager.component";
import { EditPageComponent } from "./page-manager/edit-page/edit-page.component";
import { MemberFeeComponent } from './member-fee/member-fee.component';
import { CreateFeeComponent } from './member-fee/create-fee/create-fee.component';
import { GetFeeComponent } from './member-fee/get-fee/get-fee.component';
import { ProjectTypeComponent } from './project-type/project-type.component';
import { ProjectRequestComponent } from './project-request/project-request.component';
import { UsersListComponent } from './users_list/users-list.component';

const routes: Routes = [
  {
    path: "pages",
    component: PageManagerComponent,
    children: [
      { path: "create", component: CreatePageComponent },
      { path: "edit/:route", component: EditPageComponent },
      {
        path: "",
        pathMatch: "full",
        redirectTo: "/admin/sitemap"
      }
    ]
  },
  {
    path: "sitemap",
    component: SitemapEditorComponent
  },
  {
    path: "",
    pathMatch: "full",
    redirectTo: "sitemap"
  },
  {
    path: "fee", component: MemberFeeComponent,
    children: [
      { path: "create", component: CreateFeeComponent },
      { path: "get", component: GetFeeComponent },
      {
        path: "",
        pathMatch: "full",
        redirectTo: "/admin/fee/get"
      }
    ]
  },
  { 
    path: "projectTypes",
    component: ProjectTypeComponent
  },
  {
    path: "users",
    component: UsersListComponent
  },
  { 
    path: "projectRequest",
    component: ProjectRequestComponent
  }
];

@NgModule({
  imports: [
    RouterModule.forChild([
      {
        path: "",
        component: ManagerComponent,
        children: routes
      }
    ])
  ],
  exports: [RouterModule]
})
export class ManagerRoutingModule {}
