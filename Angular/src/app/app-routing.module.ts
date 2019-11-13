import { GeneralResourcesComponent } from './ui/resources/general-resources/general-resources.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProjectListComponent } from './core/projects/project-list/project-list.component';
import { HomeComponent } from './home/home.component';
import {ProjectInfoComponent} from './project-info/project-info.component';
import { ProjectParticipantsComponent } from './project-participants/project-participants.component';
import { HomeComponent } from './ui/home/home.component';
import {ProjectInfoComponent} from './core/projects/project-info/project-info.component';
import { HomeComponent } from './ui/home/home.component';
import {ProjectInfoComponent} from './core/projects/project-info/project-info.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'projectParticipants', component:ProjectParticipantsComponent },
  { path: 'project/:id', component: ProjectInfoComponent },
  { path: 'project', component: ProjectListComponent },
  { path: 'resources', component: GeneralResourcesComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],

})
export class AppRoutingModule { }

export const routingComponents = [
  ProjectParticipantsComponent, ProjectComponent, HomeComponent, ProjectInfoComponent,
  GeneralResourcesComponent
];

export const routingComponents = [ProjectListComponent, HomeComponent, ProjectInfoComponent,
   GeneralResourcesComponent];
