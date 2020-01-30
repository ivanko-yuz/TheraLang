import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";

import { ManagerRoutingModule } from "./manager-routing.module";
import { PageManagerComponent } from "./page-manager/page-manager.component";
import { CreatePageComponent } from "./page-manager/create-page/create-page.component";
import { ManagerComponent } from "./manager.component";
import { ReactiveFormsModule } from "@angular/forms";
import { QuillModule } from "ngx-quill";

@NgModule({
  declarations: [PageManagerComponent, CreatePageComponent, ManagerComponent],
  imports: [
    CommonModule,
    ManagerRoutingModule,
    ReactiveFormsModule,
    QuillModule.forRoot()
  ]
})
export class ManagerModule {}
