import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { HomeComponent } from "./modules/user-module/home/home.component";
import { ProjectParticipantsComponent } from "./modules/project-module/project-participants/project-participants.component";
import { ProjectInfoComponent } from "./modules/project-module/project-info/project-info.component";
import { ProjectComponent } from "./modules/user-module/project/project.component";
import { DonationComponent } from "./modules/user-module/donation/donation.component";
import { GeneralResourcesTableComponent } from "./modules/resource-module/general-resources-tables/general-resources-table/general-resources-table.component";
import { TransactionResultComponent } from "./shared/components/transaction-result/transaction-result.component";
import { ErrorComponent } from "./shared/components/error/error.component";
import { ProjectTypeComponent } from "./modules/project-module/project-info/resources-table-for-project/project-type/project-type.component";
import { ProjectRequestComponent } from "./modules/project-module/project-request/project-request.component";
import { GeneralResourcesComponent } from "./modules/resource-module/general-resources.component";
import { CmsModule } from "./modules/cms-module/cms.module";

const routes: Routes = [
  { path: "", component: HomeComponent },
  { path: "participants", component: ProjectParticipantsComponent },
  { path: "projects/:id", component: ProjectInfoComponent },
  { path: "projects", component: ProjectComponent },
  { path: "donations/:projectId", component: DonationComponent },
  { path: "donations", component: DonationComponent },
  { path: "resources", component: GeneralResourcesTableComponent },
  { path: "transaction/:donationId", component: TransactionResultComponent },
  { path: "error", component: ErrorComponent },
  { path: "projectTypes", component: ProjectTypeComponent },
  { path: "projectRequest", component: ProjectRequestComponent },
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
  ProjectRequestComponent
];
