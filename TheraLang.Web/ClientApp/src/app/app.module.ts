import { BrowserModule } from "@angular/platform-browser";
import { NgModule, ErrorHandler } from "@angular/core";
import { FlexLayoutModule } from "@angular/flex-layout";
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
import { InfiniteScrollModule } from 'ngx-infinite-scroll';
import { DragDropModule } from "@angular/cdk/drag-drop";
import { ConfirmDialogComponent } from "./shared/components/confirm-dialog/confirm-dialog.component";
import { TranslateLoader, TranslateModule } from "@ngx-translate/core";
import { TranslateHttpLoader } from "@ngx-translate/http-loader";
import { ToolbarComponent } from "./modules/main/toolbar/toolbar.component";

import { LanguageComponent } from "./modules/main/toolbar/language/language.component";
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
import { AuthService } from "./core/auth/auth.service";
import { ResourceCreateService } from "./core/http/resource/resource-create.service";
import { ProjectTypeHttp } from "./core/http/project-type/project-type-Http.service";
import { CmsPagesToolbarItemComponent } from "./modules/main/toolbar/cms-pages-toolbar-item/cms-pages-toolbar-item.component";
import { ProjectComponent } from "./modules/main/pages/project/project.component";
import { HomeComponent } from "./modules/main/pages/home/home.component";
import { ProjectInfoComponent } from "./modules/main/pages/project/project-info/project-info.component";
import { FooterComponent } from "./modules/main/footer/footer.component";
import { ProjectParticipantsComponent } from "./modules/main/pages/project/project-participants/project-participants.component";
import { CustomDatePipe } from "./shared/pipes/custom.datepipe";
import { ResourcesTableComponent } from "./modules/main/pages/project/project-info/resources-table-for-project/resources-table/resources-table.component";
import { ResourcesInternalTableComponent } from "./modules/main/pages/project/project-info/resources-table-for-project/resources-internal-table/resources-internal-table.component";
import { GeneralResourcesTableComponent } from "./modules/main/pages/resource/general-resources-tables/general-resources-table/general-resources-table.component";
import { GeneralResourcesInnerTableComponent } from "./modules/main/pages/resource/general-resources-tables/general-resources-inner-table/general-resources-inner-table.component";
import { ToolbarItemComponent } from "./modules/main/toolbar/toolbar-item/toolbar-item.component";
import { DonationComponent } from "./modules/main/pages/donation/donation.component";
import { TransactionResultComponent } from "./shared/components/transaction-result/transaction-result.component";
import { ProjectRequestComponent } from "./modules/main/pages/project/project-request/project-request.component";
import { LoginComponent } from "./modules/login/login.component";
import { ProfileMenuComponent } from "./modules/main/toolbar/profile-menu/profile-menu.component";
import { ResourceCreateComponent } from "./modules/main/pages/resource/resource-create/resource-create.component";
import { ProjectTypeFormComponent } from "./modules/main/pages/project/project-type-form/project-type-form.component";
import { ProjectTypeCreateFormComponent } from "./modules/main/pages/project/project-type-create-form/project-type-create-form.component";
import { MainComponent } from "./modules/main/main.component";
import { MaterialFileInputModule } from "ngx-material-file-input";
import { SortablejsModule } from "ngx-sortablejs";
import { JwtModule } from "@auth0/angular-jwt";
import { DaysLeftPipe } from "./modules/main/pages/project/days-left.pipe";
import { NewsPageComponent } from './modules/main/pages/news/news-page.component';
import { NewsCardComponent } from './modules/main/pages/news/news-card/news-card.component';
import { NewsCreateComponent } from './modules/main/pages/news/news-create/news-create.component';
import { NewsDetailsComponent } from './modules/main/pages/news/news-details/news-details.component';
import { NgImageSliderModule } from 'ng-image-slider';
import { ProjectCreationComponent } from './modules/main/pages/project/project-creation/project-creation.component';
import { ProjectEditingComponent } from './modules/main/pages/project/project-editing/project-editing.component';
import { NotFoundComponent } from './shared/components/not-found/not-found.component';
import { AuthGuard } from "./shared/guards/auth-guard.service";
import { AdminGuard } from "./shared/guards/admin-guard.service";
import { PageComponent } from "./modules/main/pages/page/page.component";
import { PageService } from "./core/http/manager/page.service";
import { SharedModule} from "./modules/shared/shared.module";
import { RegistrationComponent } from "./modules/registration/registration.component";
import { UserPageComponent } from "./modules/user-page/user-page.component";
import { UsersListComponent } from "./modules/users_list/users-list.component";
import { UserService } from "./core/services/user/user.service";
import { ChangeRoleComponent } from "./modules/users_list/change-role/change-role.component";
import { ProfileComponent } from "./modules/profile/profile.component";
import { QuillModule } from "ngx-quill";
import { CommentsBlockComponent } from './modules/main/comments-block/comments-block.component';
import { CommentCreateComponent } from './modules/main/comments-block/comment-create/comment-create.component';
import { CommentComponent } from './modules/main/comments-block/comment/comment.component';
import { CommentEditComponent } from './modules/main/comments-block/comment-edit/comment-edit.component';
import {NgxPaginationModule} from 'ngx-pagination';
import {PaginationComponent} from './modules/paginationg/pagination.component';
import {ProfileEditComponent} from './modules/profile/edit/profile-edit.component';

export function tokenGetter() {
  return localStorage.getItem("jwt");
}
export function HttpLoaderFactory(http: HttpClient) {
  return new TranslateHttpLoader(http);
}

@NgModule({
  declarations: [
    AppComponent,
    routingComponents,
    ToolbarComponent,
    ProjectComponent,
    ProfileEditComponent,
    HomeComponent,
    ProjectInfoComponent,
    FooterComponent,
    ProjectParticipantsComponent,
    CustomDatePipe,
    ResourcesTableComponent,
    ConfirmDialogComponent,
    ProjectCreationComponent,
    ResourcesInternalTableComponent,
    GeneralResourcesTableComponent,
    GeneralResourcesInnerTableComponent,
    ToolbarItemComponent,
    DonationComponent,
    TransactionResultComponent,
    ProjectRequestComponent,
    LoginComponent,
    RegistrationComponent,
    UserPageComponent,
    UsersListComponent,
    ChangeRoleComponent,
    ProfileComponent,
    ProfileMenuComponent,
    ResourceCreateComponent,
    ProjectTypeFormComponent,
    ProjectTypeCreateFormComponent,
    LanguageComponent,
    MainComponent,
    CmsPagesToolbarItemComponent,
    DaysLeftPipe,
    NewsPageComponent,
    NewsCardComponent,
    NewsCreateComponent,
    NewsDetailsComponent,
    PageComponent,
    ProjectEditingComponent,
    NotFoundComponent,
    CommentsBlockComponent,
    CommentCreateComponent,
    CommentComponent,
    CommentEditComponent
    PaginationComponent
  ],
  entryComponents: [
    ResourcesInternalTableComponent,
    ProjectCreationComponent,
    ConfirmDialogComponent,
    ChangeRoleComponent,
    LoginComponent,
    ResourceCreateComponent,
    ProjectTypeFormComponent,
    ProjectTypeCreateFormComponent,
    CommentEditComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    NgxPaginationModule,
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
    InfiniteScrollModule,
    TranslateModule.forRoot({
      loader: {
        provide: TranslateLoader,
        useFactory: HttpLoaderFactory,
        deps: [HttpClient]
      }
    }),
    MaterialFileInputModule,
    JwtModule.forRoot({
      config: {
        tokenGetter,
        whitelistedDomains: ["localhost:5000"],
        blacklistedRoutes: []
      }
    }),
    NgImageSliderModule,
    SortablejsModule.forRoot({ animation: 400 }),
    SharedModule
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
    AuthService,
    UserService,
    ResourceCreateService,
    ProjectTypeHttp,
    PageService,
    AuthGuard,
    AdminGuard
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
