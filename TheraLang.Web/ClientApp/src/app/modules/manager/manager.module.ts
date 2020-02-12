import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";

import { ManagerRoutingModule } from "./manager-routing.module";
import { CreatePageComponent } from "./page-manager/create-page/create-page.component";
import { ManagerComponent } from "./manager.component";
import { ReactiveFormsModule } from "@angular/forms";
import { QuillModule } from "ngx-quill";
import { MatButtonModule, MatFormFieldModule, MatRippleModule, MatInputModule, MatCardModule, MatIconModule } from '@angular/material';
import { SitemapEditorComponent } from "./sitemap-editor/sitemap-editor.component";
import { SortablejsModule } from "ngx-sortablejs";
import { PageEntryComponent } from "./sitemap-editor/page-entry/page-entry.component";
import { MatSidenav, MatSidenavModule } from "@angular/material";
import { TranslateModule, TranslateLoader, TranslateService } from "@ngx-translate/core";
import { HttpClient } from "@angular/common/http";
import { TranslateHttpLoader } from "@ngx-translate/http-loader";
import { PageManagerComponent } from "./page-manager/page-manager.component";
import { SideBarComponent } from './side-bar/side-bar.component';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatListModule } from '@angular/material/list';
import { MatTooltipModule } from "@angular/material/tooltip";
import { QuillMaterialComponent } from './shared/components/quill-material/quill-material.component';
import { EditPageComponent } from './page-manager/edit-page/edit-page.component';
import { PageService } from 'src/app/core/http/manager/page.service';
import { SlugifyPipe } from 'src/app/shared/pipes/slugify';

@NgModule({
  declarations: [
    SitemapEditorComponent,
    CreatePageComponent,
    ManagerComponent,
    SitemapEditorComponent,
    PageEntryComponent,
    SideBarComponent,
    PageManagerComponent,
    QuillMaterialComponent,
    EditPageComponent
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
    MatToolbarModule,
    MatSidenavModule,
    MatListModule,
    MatTooltipModule,
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
  ],
  providers: [
    PageService,
    SlugifyPipe
  ]
})
export class ManagerModule {}
