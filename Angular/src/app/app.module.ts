import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { MatToolbarModule,MatButtonModule,MatCardModule } from '@angular/material';
import {HttpClientModule} from '@angular/common/http';
import { AppRoutingModule, routingComponents  } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToolbarComponent } from './toolbar/toolbar.component';
import { ProjectComponent } from './project/project.component';
import { HomeComponent } from './home/home.component';
import { ProjectInfoComponent } from './project-info/project-info.component';

@NgModule({
  declarations: [
    AppComponent,
    routingComponents,
    ToolbarComponent,
    ProjectComponent,
    HomeComponent,
    ProjectInfoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatButtonModule,
    HttpClientModule,
    MatCardModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
