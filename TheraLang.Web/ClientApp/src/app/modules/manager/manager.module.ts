import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";

import { ManagerRoutingModule } from "./manager-routing.module";
import { PageManagerComponent } from "./page-manager/page-manager.component";
import { CreatePageComponent } from "./page-manager/create-page/create-page.component";
import { ManagerComponent } from "./manager.component";
import { ReactiveFormsModule } from "@angular/forms";
import { QuillModule } from "ngx-quill";
import { MatButtonModule, MatFormFieldModule, MatRippleModule, MatInputModule, MatCardModule } from '@angular/material';
import { EditorComponent } from './shared/components/editor/editor.component';

@NgModule({
  declarations: [PageManagerComponent, CreatePageComponent, ManagerComponent, EditorComponent],
  imports: [
    CommonModule,
    ManagerRoutingModule,
    ReactiveFormsModule,
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,
    MatRippleModule,
    MatCardModule,
    QuillModule.forRoot()
  ],
  exports: [
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,
    MatRippleModule
  ]
})
export class ManagerModule {}
