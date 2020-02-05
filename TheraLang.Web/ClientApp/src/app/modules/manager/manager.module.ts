import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";

import { ManagerRoutingModule } from "./manager-routing.module";
import { CreatePageComponent } from "./page-manager/create-page/create-page.component";
import { ManagerComponent } from "./manager.component";
import { ReactiveFormsModule } from "@angular/forms";
import { QuillModule } from "ngx-quill";
import { SitemapEditorComponent } from "./sitemap-editor/sitemap-editor.component";
import { SortablejsModule } from "ngx-sortablejs";
import { PageEntryComponent } from "./sitemap-editor/page-entry/page-entry.component";
import { MatIconModule, MatButtonModule, MatSidenav, MatSidenavModule } from "@angular/material";
import { TranslateModule, TranslateLoader } from "@ngx-translate/core";
import { HttpClient } from "@angular/common/http";
import { MatCardModule } from "@angular/material/card";
import { TranslateHttpLoader } from "@ngx-translate/http-loader";
import { PageManagerComponent } from "./page-manager/page-manager.component";
import { SideBarComponent } from './side-bar/side-bar.component';
import { MatToolbarModule } from '@angular/material/toolbar';
import {MatListModule} from '@angular/material/list';

@NgModule({
  declarations: [
    SitemapEditorComponent,
    CreatePageComponent,
    ManagerComponent,
    SitemapEditorComponent,
    PageEntryComponent,
    SideBarComponent,
    PageManagerComponent,
    
  ],
  imports: [
    CommonModule,
    ManagerRoutingModule,
    ReactiveFormsModule,
    QuillModule.forRoot(),
    SortablejsModule,
    MatIconModule,
    MatCardModule,
    MatButtonModule,
    MatToolbarModule,
    MatSidenavModule,
    MatListModule,
    TranslateModule.forRoot({
      loader: {
        provide: TranslateLoader,
        useFactory: (http: HttpClient) => new TranslateHttpLoader(http),
        deps: [HttpClient]
      }
    })
  ]
})
export class ManagerModule {}
