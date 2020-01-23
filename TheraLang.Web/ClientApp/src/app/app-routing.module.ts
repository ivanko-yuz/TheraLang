import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { HomeComponent } from "./modules/user/pages/home/home.component";
import { ProjectParticipantsComponent } from "./modules/user/pages/project/project-participants/project-participants.component";
import { ProjectInfoComponent } from "./modules/user/pages/project/project-info/project-info.component";
import { ProjectComponent } from "./modules/user/pages/project/project.component";
import { DonationComponent } from "./modules/user/pages/donation/donation.component";
import { TransactionResultComponent } from "./shared/components/transaction-result/transaction-result.component";
import { ErrorComponent } from "./shared/components/error/error.component";
import { ProjectTypeComponent } from "./modules/user/pages/project/project-info/resources-table-for-project/project-type/project-type.component";
import { ProjectRequestComponent } from "./modules/user/pages/project/project-request/project-request.component";
import { CmsModule } from "./modules/cms-generic/cms.module";
import { LoginComponent}  from "./modules/user/pages/login/login.component"
import { GeneralResourcesComponent } from "./modules/user/pages/resource/general-resources.component";
import { GeneralResourcesTableComponent } from "./modules/user/pages/resource/general-resources-tables/general-resources-table/general-resources-table.component";
import { MainComponent } from './modules/user/pages/main/main.component';

const routes: Routes = [
  { path: "", component: MainComponent, children:[
      {path: "", component: HomeComponent},
      { path: "participants", component: ProjectParticipantsComponent },
      { path: "projects/:id", component: ProjectInfoComponent },
      { path: "projects", component: ProjectComponent },
      { path: "donations/:projectId", component: DonationComponent },
      { path: "donations", component: DonationComponent },
      { path: "resources", component: GeneralResourcesTableComponent },
      { path: "transaction/:donationId", component: TransactionResultComponent },
      { path: "projectTypes", component: ProjectTypeComponent },
      { path: "projectRequest", component: ProjectRequestComponent }
  ]},
  { path: "login", component: LoginComponent },
  { path: "error", component: ErrorComponent },
  { path: "**", loadChildren: () => CmsModule }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}

export const routingComponents = [
  ProjectParticipantsComponent,
  ProjectComponent,
  HomeComponent,
  ProjectInfoComponent,
  GeneralResourcesComponent,
  ErrorComponent,
  ProjectTypeComponent,
  TransactionResultComponent,
  DonationComponent,
  ProjectRequestComponent,
  LoginComponent,
  MainComponent
];
