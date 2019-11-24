import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProjectComponent } from './project/project.component';
import { HomeComponent } from './home/home.component';
import { ProjectInfoComponent } from './project-info/project-info.component';
import { ProjectParticipantsComponent } from './project-participants/project-participants.component';
import { GeneralResourcesTableComponent } from './general-resources/general-resources-tables/general-resources-table/general-resources-table.component';
import { ErrorComponent } from './shared/components/error/error.component';
import { ResultComponent } from './result/result.component';
import { DonationComponent } from './donation/donation.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'participants', component:ProjectParticipantsComponent },
  { path: 'project/:id', component: ProjectInfoComponent },
  { path: 'projects', component: ProjectComponent },
  { path: 'donation/:projectId', component: DonationComponent },
  { path: 'resources', component: GeneralResourcesComponent },
  { path: 'result/:donationId', component:ResultComponent },
  { path: 'error', component: ErrorComponent }
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

