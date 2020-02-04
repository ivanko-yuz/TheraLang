import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";

import { ManagerRoutingModule } from "./manager-routing.module";
import { CreatePageComponent } from "./page-manager/create-page/create-page.component";
import { ManagerComponent } from "./manager.component";
import { ReactiveFormsModule } from "@angular/forms";
import { QuillModule } from "ngx-quill";
import { MatButtonModule, MatFormFieldModule, MatRippleModule, MatInputModule, MatCardModule, MatIconModule } from '@angular/material';
import { EditorComponent } from './shared/components/editor/editor.component';
import { SitemapEditorComponent } from "./sitemap-editor/sitemap-editor.component";
import { SortablejsModule } from "ngx-sortablejs";
import { PageEntryComponent } from "./sitemap-editor/page-entry/page-entry.component";
import { TranslateModule, TranslateLoader } from "@ngx-translate/core";
import { HttpClient } from "@angular/common/http";
import { TranslateHttpLoader } from "@ngx-translate/http-loader";
import { PageManagerComponent } from "./page-manager/page-manager.component";

@NgModule({
  declarations: [
    SitemapEditorComponent,
    CreatePageComponent,
    ManagerComponent,
    SitemapEditorComponent,
    PageEntryComponent,
    PageManagerComponent,
    EditorComponent
  ],
  imports: [
    CommonModule,
    ManagerRoutingModule,
    ReactiveFormsModule,
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,
    MatRippleModule,
    MatCardModule,
    QuillModule.forRoot(),
    SortablejsModule,
    MatIconModule,
    MatCardModule,
    MatButtonModule,
    TranslateModule.forRoot({
      loader: {
        provide: TranslateLoader,
        useFactory: (http: HttpClient) => new TranslateHttpLoader(http),
        deps: [HttpClient]
      }
    })
  ],
  exports: [
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,
    MatRippleModule
  ]
})
export class ManagerModule {}
