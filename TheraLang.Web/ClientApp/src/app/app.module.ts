import { BrowserModule } from "@angular/platform-browser";
import { NgModule, ErrorHandler } from "@angular/core";
import { FlexLayoutModule } from '@angular/flex-layout';
import {
  MatToolbarModule,
  MatButtonModule,
  MatAutocompleteModule,
  MatBadgeModule,
  MatBottomSheetModule,
  MatButtonToggleModule,
  MatCheckboxModule,
  MatChipsModule,
  MatStepperModule,
  MatDatepickerModule,
  MatDialogModule,
  MatDividerModule,
  MatExpansionModule,
  MatIconModule,
  MatInputModule,
  MatListModule,
  MatMenuModule,
  MatNativeDateModule,
  MatProgressBarModule,
  MatRadioModule,
  MatRippleModule,
  MatSelectModule,
  MatSidenavModule,
  MatSliderModule,
  MatSlideToggleModule,
  MatSnackBarModule,
  MatSortModule,
  MatTooltipModule,
  MatTreeModule,
  MatFormField
} from "@angular/material";
import { HttpClient, HttpClientModule } from "@angular/common/http";
import { AppRoutingModule, routingComponents } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { ReactiveFormsModule, FormsModule } from "@angular/forms";
import { MatFormFieldModule } from "@angular/material/form-field";
import { MatTableModule } from "@angular/material/table";
import { MatTabsModule } from "@angular/material/tabs";
import { MatCardModule } from "@angular/material/card";
import { MatGridListModule } from "@angular/material/grid-list";
import { MatProgressSpinnerModule } from "@angular/material";
import { MatPaginatorModule } from "@angular/material/paginator";
import { PortalModule } from "@angular/cdk/portal";
import { A11yModule } from "@angular/cdk/a11y";
import { CdkStepperModule } from "@angular/cdk/stepper";
import { CdkTableModule } from "@angular/cdk/table";
import { CdkTreeModule } from "@angular/cdk/tree";
import { ScrollingModule } from "@angular/cdk/scrolling";
import { DragDropModule } from "@angular/cdk/drag-drop";
import { ConfirmDialogComponent } from "./shared/components/confirm-dialog/confirm-dialog.component";
import { ErrorComponent } from "./shared/components/error/error.component";
import { TranslateLoader, TranslateModule } from "@ngx-translate/core";
import { TranslateHttpLoader } from "@ngx-translate/http-loader";
import { ToolbarComponent } from "./core/toolbar/toolbar.component";
import { ProjectComponent } from "./modules/user/pages/project/project.component";
import { HomeComponent } from "./modules/user/pages/home/home.component";
import { ProjectInfoComponent } from "./modules/user/pages/project/project-info/project-info.component";
import { FooterComponent } from "./core/footer/footer.component";
import { ProjectParticipantsComponent } from "./modules/user/pages/project/project-participants/project-participants.component";
import { CustomDatePipe } from "./shared/pipes/custom.datepipe";
import { ResourcesTableComponent } from "./modules/user/pages/project/project-info/resources-table-for-project/resources-table/resources-table.component";
import { ProjectFormComponent } from "./modules/user/pages/project/project-form/project-form.component";
import { ResourcesInternalTableComponent } from "./modules/user/pages/project/project-info/resources-table-for-project/resources-internal-table/resources-internal-table.component";
import { ToolbarItemComponent } from "./core/toolbar/toolbar-item/toolbar-item.component";
import { DonationComponent } from "./modules/user/pages/donation/donation.component";
import { TransactionResultComponent } from "./shared/components/transaction-result/transaction-result.component";
import { ProjectRequestComponent } from "./modules/user/pages/project/project-request/project-request.component";
import { LoginComponent } from "./modules/user/components/login/login.component";
import { ProfileMenuComponent } from "./core/toolbar/profile-menu/profile-menu.component";
import { ProjectTypeFormComponent } from "./modules/user/pages/project/project-type-form/project-type-form.component";
import { ProjectTypeCreateFormComponent } from "./modules/user/pages/project/project-type-create-form/project-type-create-form.component";
import { LanguageComponent } from "./core/toolbar/language/language.component";
import { ResourceService } from "./core/http/resource/resource.service";
import { HttpService } from "./core/http/http/http.service";
import { EventService } from "./core/services/event/event-service";
import { NotificationService } from "./core/services/notification/notification.service";
import { DialogService } from "./core/services/dialog/dialog.service";
import { ResourceCategoriesService } from "./core/services/resource/resource-categories.service";
import { ProjectParticipationService } from "./core/http/project-participants/project-participation.service";
import { ProjectTypeService } from "./core/services/project-type/project-type.service";
import { DonationService } from "./core/http/donations/donation.service";
import { HttpProjectService } from "./core/http/project/http-project.service";
import { UserService } from "./core/auth/user.service";
import { ResourceCreateService } from "./core/http/resource/resource-create.service";
import { ProjectTypeHttp } from "./core/http/project-type/project-type-Http.service";
import { CmsModule } from "./modules/cms-generic/cms.module";
import { GeneralResourcesTableComponent } from "./modules/user/pages/resource/general-resources-tables/general-resources-table/general-resources-table.component";
import { GeneralResourcesInnerTableComponent } from "./modules/user/pages/resource/general-resources-tables/general-resources-inner-table/general-resources-inner-table.component";
import { ResourceCreateComponent } from "./modules/user/pages/resource/resource-create/resource-create.component";
import { CmsPagesToolbarItemComponent } from './core/toolbar/cms-pages-toolbar-item/cms-pages-toolbar-item.component';

export function HttpLoaderFactory(http: HttpClient) {
  return new TranslateHttpLoader(http);
}

@NgModule({
  declarations: [
    AppComponent,
    routingComponents,
    ToolbarComponent,
    ProjectComponent,
    HomeComponent,
    ProjectInfoComponent,
    FooterComponent,
    ProjectParticipantsComponent,
    CustomDatePipe,
    ResourcesTableComponent,
    ConfirmDialogComponent,
    ErrorComponent,
    ProjectFormComponent,
    ResourcesInternalTableComponent,
    GeneralResourcesTableComponent,
    GeneralResourcesInnerTableComponent,
    ToolbarItemComponent,
    DonationComponent,
    TransactionResultComponent,
    ProjectRequestComponent,
    LoginComponent,
    ProfileMenuComponent,
    ResourceCreateComponent,
    ProjectTypeFormComponent,
    ProjectTypeCreateFormComponent,
    LanguageComponent,
    CmsPagesToolbarItemComponent
  ],
  entryComponents: [
    ResourcesInternalTableComponent,
    ProjectFormComponent,
    ConfirmDialogComponent,
    LoginComponent,
    ResourceCreateComponent,
    ProjectTypeFormComponent,
    ProjectTypeCreateFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    FlexLayoutModule,
    MatToolbarModule,
    MatButtonModule,
    HttpClientModule,
    MatCardModule,
    FormsModule,
    ReactiveFormsModule,
    MatGridListModule,
    MatFormFieldModule,
    MatTabsModule,
    MatTableModule,
    MatProgressSpinnerModule,
    MatPaginatorModule,
    A11yModule,
    CdkStepperModule,
    CdkTableModule,
    CdkTreeModule,
    DragDropModule,
    MatAutocompleteModule,
    MatBadgeModule,
    MatBottomSheetModule,
    MatButtonModule,
    MatButtonToggleModule,
    MatCardModule,
    MatCheckboxModule,
    MatChipsModule,
    MatStepperModule,
    MatDatepickerModule,
    MatDialogModule,
    MatDividerModule,
    MatExpansionModule,
    MatIconModule,
    MatInputModule,
    MatListModule,
    MatMenuModule,
    MatNativeDateModule,
    MatPaginatorModule,
    MatProgressBarModule,
    MatProgressSpinnerModule,
    MatRadioModule,
    MatRippleModule,
    MatSelectModule,
    MatSidenavModule,
    MatSliderModule,
    MatSlideToggleModule,
    MatSnackBarModule,
    MatSortModule,
    MatTableModule,
    MatToolbarModule,
    MatTooltipModule,
    MatTreeModule,
    PortalModule,
    ScrollingModule,
    CmsModule,
    TranslateModule.forRoot({
      loader: {
        provide: TranslateLoader,
        useFactory: HttpLoaderFactory,
        deps: [HttpClient]
      }
    })
  ],
  exports: [ResourcesInternalTableComponent],
  providers: [
    ResourceService,
    HttpService,
    EventService,
    // {provide: ErrorHandler, useClass: ErrorHandlerService},
    NotificationService,
    DialogService,
    ResourceCategoriesService,
    ProjectParticipationService,
    ProjectTypeService,
    DonationService,
    HttpProjectService,
    UserService,
    ResourceCreateService,
    ProjectTypeHttp
  ],
  bootstrap: [AppComponent]
})
export class AppModule {}
