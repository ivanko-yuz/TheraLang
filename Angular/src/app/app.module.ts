import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {
  MatToolbarModule, MatButtonModule, MatAutocompleteModule, MatBadgeModule,
  MatBottomSheetModule, MatButtonToggleModule, MatCheckboxModule, MatChipsModule,
  MatStepperModule, MatDatepickerModule, MatDialogModule, MatDividerModule, MatExpansionModule,
  MatIconModule, MatInputModule, MatListModule, MatMenuModule, MatNativeDateModule, MatProgressBarModule,
  MatRadioModule, MatRippleModule, MatSelectModule, MatSidenavModule, MatSliderModule, MatSlideToggleModule,
  MatSnackBarModule, MatSortModule, MatTooltipModule, MatTreeModule, MatFormField,
} from '@angular/material';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule, routingComponents } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToolbarComponent } from './toolbar/toolbar.component';
import { ProjectComponent } from './project/project.component';
import { HomeComponent } from './home/home.component';
import { ProjectInfoComponent } from './project-info/project-info.component';
import { CreateProjectComponent } from './create-project/create-project.component';
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
import { CustomDatePipe } from './project-info/custom.datepipe';
import { ResourcesTableComponent } from './resources-table/resources-table.component';
import { ResourcesInternalTableComponent } from './resources-internal-table/resources-internal-table.component';
import { ResourceService } from './resources-table/resource.service';
import { GeneralResourcesComponent } from './general-resources/general-resources.component';
import { PiranhaPageComponent } from './cms-api/piranha-page/piranha-page.component';
import { BlockComponent } from './cms-api/cms-shared/block/block.component';


@NgModule({
   declarations: [
      AppComponent,
      routingComponents,
      ToolbarComponent,
      ProjectComponent,
      HomeComponent,
      ProjectInfoComponent,
      CreateProjectComponent,
      FooterComponent,
      ProjectParticipantsComponent,
      CustomDatePipe,
      ResourcesTableComponent,
      ResourcesInternalTableComponent,
      GeneralResourcesComponent,
      PiranhaPageComponent,
      BlockComponent
   ],
   entryComponents: [
      CreateProjectComponent,
      ResourcesInternalTableComponent
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
   ],
   exports: [
      ResourcesInternalTableComponent,
      BlockComponent
   ],
   providers: [
      ResourceService,
      HttpService,
      EventService,
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
