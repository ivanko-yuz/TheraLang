import { BrowserModule } from '@angular/platform-browser';
import { NgModule, ErrorHandler } from '@angular/core';
import {
  MatToolbarModule, MatButtonModule, MatAutocompleteModule, MatBadgeModule,
  MatBottomSheetModule, MatButtonToggleModule, MatCheckboxModule, MatChipsModule,
  MatStepperModule, MatDatepickerModule, MatDialogModule, MatDividerModule, MatExpansionModule,
  MatIconModule, MatInputModule, MatListModule, MatMenuModule, MatNativeDateModule, MatProgressBarModule,
  MatRadioModule, MatRippleModule, MatSelectModule, MatSidenavModule, MatSliderModule, MatSlideToggleModule,
  MatSnackBarModule, MatSortModule, MatTooltipModule, MatTreeModule, MatFormField
} from '@angular/material';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule, routingComponents } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToolbarComponent } from './toolbar/toolbar.component';
import { ProjectComponent } from './project/project.component';
import { HomeComponent } from './home/home.component';
import { ProjectInfoComponent } from './project-info/project-info.component';
import { ProjectFormComponent } from './project-form/project-form.component';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatTableModule } from '@angular/material/table';
import { MatTabsModule } from '@angular/material/tabs';
import { MatCardModule } from '@angular/material/card';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatProgressSpinnerModule } from '@angular/material';
import { MatPaginatorModule } from '@angular/material/paginator';
import { PortalModule } from '@angular/cdk/portal';
import { A11yModule } from '@angular/cdk/a11y';
import { CdkStepperModule } from '@angular/cdk/stepper';
import { CdkTableModule } from '@angular/cdk/table';
import { CdkTreeModule } from '@angular/cdk/tree';
import { ScrollingModule } from '@angular/cdk/scrolling';
import { DragDropModule } from '@angular/cdk/drag-drop';
import { FooterComponent } from './footer/footer.component';
import { ProjectParticipantsComponent } from './project-participants/project-participants.component';
import { EventService } from './project-participants/event-service';
import { HttpService } from './project/http.service';
import { CustomDatePipe } from './shared/pipes/custom.datepipe';
import { ResourcesInternalTableComponent } from './project-info/resources-table-for-project/resources-internal-table/resources-internal-table.component';
import { ResourceService } from './project-info/resources-table-for-project/resources-table/resource.service';
import { GeneralResourcesTableComponent } from './general-resources/general-resources-tables/general-resources-table/general-resources-table.component';
import { GeneralResourcesInnerTableComponent } from './general-resources/general-resources-tables/general-resources-inner-table/general-resources-inner-table.component';
import { ResourceCategoriesService } from './project-info/resources-table-for-project/resources-table/resource-categories.service';
import { ConfirmDialogComponent } from './shared/components/confirm-dialog/confirm-dialog.component';
import { ErrorComponent } from './shared/components/error/error.component';
import { ErrorHandlerService } from './shared/services/error-handler.service';
import { NotificationService } from './shared/services/notification.service';
import { DialogService } from './shared/services/dialog.service';
import { ResourcesTableComponent } from './project-info/resources-table-for-project/resources-table/resources-table.component';
import {CmsModule} from './cms/cms.module';
import { ToolbarItemComponent } from './toolbar/toolbar-item/toolbar-item.component';
import { DonationComponent } from './donation/donation.component';
import { TransactionResultComponent } from './transaction-result/transaction-result.component';
import { ProjectParticipationService } from './project-participants/project-participation.service';
import { ProjectTypeService } from './project-info/resources-table-for-project/project-type/project-type.service';
import { DonationService } from './donation/donation.service';
import { UserComponent } from './user/user.component';
import { LoginComponent } from './user/login/login.component';
import { UserService } from './user/user.service';
import { ProfileMenuComponent } from './toolbar/profile-menu/profile-menu.component';
import { ResourceCreateComponent } from './general-resources/resource-create/resource-create.component';
import { ResourceCreateService } from './general-resources/resource-create/resource-create.service';

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
      UserComponent,
      LoginComponent,
      ProfileMenuComponent,
      ResourceCreateComponent,
   ],
   entryComponents: [
      ResourcesInternalTableComponent,
      ProjectFormComponent,
      ConfirmDialogComponent,
      LoginComponent,
      ResourceCreateComponent,
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      BrowserAnimationsModule,
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
   ],
   exports: [
       ResourcesInternalTableComponent,
   ],
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
      UserService,
      ResourceCreateService,
   ],
   bootstrap: [
      AppComponent,
   ]
})
export class AppModule { }
