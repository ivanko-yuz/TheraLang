import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PageViewComponent } from './page-view/page-view.component';
import {QuillModule} from "ngx-quill";
import {MatCardModule} from '@angular/material/card';



@NgModule({
  declarations: [
    PageViewComponent
  ],
  imports: [
    CommonModule,
    QuillModule.forRoot(),
    MatCardModule
  ],
  exports: [
    PageViewComponent,
    QuillModule
  ]
})
export class CmsGenericModule { }
