import { GeneralResourcesComponent } from './general-resources/general-resources.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProjectComponent } from './project/project.component';
import { HomeComponent } from './home/home.component';
import {ProjectInfoComponent} from './project-info/project-info.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'project/:id', component: ProjectInfoComponent },
  { path: 'project', component: ProjectComponent },
  { path: 'resources', component: GeneralResourcesComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],

})
export class AppRoutingModule { }
export const routingComponents = [ProjectComponent, HomeComponent, ProjectInfoComponent,
   GeneralResourcesComponent];
