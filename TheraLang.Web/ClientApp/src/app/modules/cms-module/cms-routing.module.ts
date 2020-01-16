import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { CmsGenericPageComponent } from "./cms-generic-page/cms-generic-page.component";

const routes: Routes = [{ path: "**", component: CmsGenericPageComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CmsRoutingModule {}
