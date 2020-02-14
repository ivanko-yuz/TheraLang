import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { CreatePageComponent } from "./page-manager/create-page/create-page.component";
import { ManagerComponent } from "./manager.component";
import { SitemapEditorComponent } from "./sitemap-editor/sitemap-editor.component";
import { PageManagerComponent } from "./page-manager/page-manager.component";
import { EditPageComponent } from "./page-manager/edit-page/edit-page.component";
import { MemberFeeComponent } from './member-fee/member-fee.component';

const routes: Routes = [
  {
    path: "pages",
    component: PageManagerComponent,
    children: [
      { path: "create", component: CreatePageComponent },
      { path: "edit/:id", component: EditPageComponent },
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
    path: "fee",
    component: MemberFeeComponent
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
