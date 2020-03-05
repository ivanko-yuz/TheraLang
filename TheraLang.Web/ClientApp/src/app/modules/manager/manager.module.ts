import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";

import { ManagerRoutingModule } from "./manager-routing.module";
import { CreatePageComponent } from "./page-manager/create-page/create-page.component";
import { ManagerComponent } from "./manager.component";
import { ReactiveFormsModule, FormsModule } from "@angular/forms";
import { QuillModule } from "ngx-quill";
import { MatButtonModule, MatFormFieldModule, MatRippleModule, MatInputModule, MatCardModule, MatIconModule, MatDatepickerModule, MatDialogModule, MatTableModule } from "@angular/material";
import { SitemapEditorComponent } from "./sitemap-editor/sitemap-editor.component";
import { SortablejsModule } from "ngx-sortablejs";
import { PageEntryComponent } from "./sitemap-editor/page-entry/page-entry.component";
import { MatTabsModule, MatSidenavModule } from "@angular/material";
import { TranslateModule, TranslateLoader, TranslateService } from "@ngx-translate/core";
import { HttpClient } from "@angular/common/http";
import { TranslateHttpLoader } from "@ngx-translate/http-loader";
import { PageManagerComponent } from "./page-manager/page-manager.component";
import { SideBarComponent } from "./side-bar/side-bar.component";
import { MatToolbarModule } from "@angular/material/toolbar";
import { MatListModule } from "@angular/material/list";
import { MatTooltipModule } from "@angular/material/tooltip";
import { QuillMaterialComponent } from './shared/components/quill-material/quill-material.component';
import { EditPageComponent } from './page-manager/edit-page/edit-page.component';
import { SlugifyPipe } from 'src/app/shared/pipes/slugify';
import { SharedModule } from "../shared/shared.module";
import { MatMenuModule } from "@angular/material/menu";
import { MemberFeeComponent } from "./member-fee/member-fee.component";
import { CreateFeeComponent } from "./member-fee/create-fee/create-fee.component";
import { GetFeeComponent } from "./member-fee/get-fee/get-fee.component";
import { PageService } from "src/app/core/http/manager/page.service";
import { MemberFeeService } from 'src/app/core/http/manager/fee.service';
import { PageViewComponent } from '../shared/page-view/page-view.component';
import { PagePreviewComponent } from './page-manager/page-preview/page-preview.component';
import { UsersListComponent } from '../users_list/users-list.component';
import { ProjectTypeComponent } from '../main/pages/project/project-info/resources-table-for-project/project-type/project-type.component';
import { ProjectTypeFormComponent } from '../main/pages/project/project-type-form/project-type-form.component';
import { ProjectTypeCreateFormComponent } from '../main/pages/project/project-type-create-form/project-type-create-form.component';
import { ProjectRequestComponent } from '../main/pages/project/project-request/project-request.component';

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
    EditPageComponent,
    SlugifyPipe,
    MemberFeeComponent,
    CreateFeeComponent,
    GetFeeComponent,
    PagePreviewComponent,
    UsersListComponent,
    ProjectTypeComponent,
    ProjectTypeFormComponent,
    ProjectTypeCreateFormComponent,
    ProjectRequestComponent
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
    SortablejsModule,
    MatIconModule,
    MatDialogModule,
    MatCardModule,
    MatButtonModule,
    MatToolbarModule,
    MatSidenavModule,
    MatTabsModule,
    MatListModule,
    MatTooltipModule,
    FormsModule,
    MatDatepickerModule,
    TranslateModule.forRoot({
      loader: {
        provide: TranslateLoader,
        useFactory: (http: HttpClient) => new TranslateHttpLoader(http),
        deps: [HttpClient]
      }
    }),
    SharedModule,
    MatMenuModule,
    MatTableModule
  ],
  entryComponents:[
    PagePreviewComponent,
    ProjectTypeFormComponent,
    ProjectTypeCreateFormComponent
  ],
  exports: [
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,
    MatRippleModule
  ],
  providers: [
    PageService,
    SlugifyPipe,
    MemberFeeService
  ]
})
export class ManagerModule { }
