import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { MatToolbarModule, MatButtonModule, MatAutocompleteModule, MatBadgeModule,
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
import { ToolbarComponent } from './ui/toolbar/toolbar.component';
import { ProjectListComponent } from './ui/projects/project-list/project-list.component';
import { HomeComponent } from './ui/home/home.component';
import { ProjectInfoComponent } from './ui/projects/project-info/project-info.component';
import { ProjectFormComponent } from './ui/projects/project-form/project-form.component';
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
import { FooterComponent } from './ui/footer/footer.component';
import { HttpProjectService } from './ui/projects/shared/http-project.service';
import { ProjectService } from './ui/projects/shared/project.service';
import { CustomDatePipe } from './ui/projects/project-info/custom.datepipe';
import { ResourcesTableComponent } from './ui/resources/resources-table/resources-table.component';
import { ResourcesInternalTableComponent } from './ui/resources/resources-internal-table/resources-internal-table.component';
import { ResourceService } from './ui/resources/resources-table/resource.service';
import { GeneralResourcesComponent } from './ui/resources/general-resources/general-resources.component';
import { PagesMenuButtonComponent } from './ui/pages-menu-button/pages-menu-button.component';
import { ProjectsComponent } from './ui/projects/projects.component';
import { ResourcesComponent } from './ui/resources/resources.component';


@NgModule({
  declarations: [
    AppComponent,
    routingComponents,
    ToolbarComponent,
    ProjectListComponent,
    HomeComponent,
    ProjectInfoComponent,
    ProjectFormComponent,
    FooterComponent,
    ProjectParticipantsComponent,
    CustomDatePipe,
    ResourcesTableComponent,
    ResourcesInternalTableComponent,
    GeneralResourcesComponent,
    ProjectsComponent,
    PagesMenuButtonComponent,
    ResourcesComponent
  ],
  entryComponents: [ProjectFormComponent, ResourcesInternalTableComponent],
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

  ],

  exports: [ResourcesInternalTableComponent],
  providers: [ResourceService, HttpProjectService,ProjectService],
  bootstrap: [AppComponent, ]
})
export class AppModule { }
