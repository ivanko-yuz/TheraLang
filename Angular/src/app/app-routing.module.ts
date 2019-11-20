import { GeneralResourcesComponent } from './general-resources/general-resources.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProjectComponent } from './project/project.component';
import { HomeComponent } from './home/home.component';
import {ProjectInfoComponent} from './project-info/project-info.component';
import { ResourcesComponent } from './resources/resources.component';
import { ProjectParticipantsComponent } from './project-participants/project-participants.component';
import { ResultComponent } from './result/result.component';
import { DonationComponent } from './donation/donation.component';
import { ErrorComponent } from './shared/components/error/error.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'projectParticipants', component: ProjectParticipantsComponent },
  { path: 'donation/:projectId', component: DonationComponent },
  { path: 'project/:id', component:ProjectInfoComponent },
  { path: 'project', component:ProjectComponent },
  { path: 'resources', component:ResourcesComponent },
  { path: 'result/:donationId', component:ResultComponent },
  { path: 'error', component: ErrorComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],

})
export class AppRoutingModule { }

export const routingComponents = [
  ProjectParticipantsComponent, ProjectComponent, HomeComponent, ProjectInfoComponent,
    GeneralResourcesComponent, ErrorComponent, ResultComponent, DonationComponent  
];
