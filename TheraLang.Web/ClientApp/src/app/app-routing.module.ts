import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { ProjectComponent } from "./modules/main/pages/project/project.component";
import { MainComponent } from "./modules/main/main.component";
import { HomeComponent } from "./modules/main/pages/home/home.component";
import { ProjectParticipantsComponent } from "./modules/main/pages/project/project-participants/project-participants.component";
import { ProjectInfoComponent } from "./modules/main/pages/project/project-info/project-info.component";
import { DonationComponent } from "./modules/main/pages/donation/donation.component";
import { GeneralResourcesTableComponent } from "./modules/main/pages/resource/general-resources-tables/general-resources-table/general-resources-table.component";
import { TransactionResultComponent } from "./shared/components/transaction-result/transaction-result.component";
import { ProjectTypeComponent } from "./modules/main/pages/project/project-info/resources-table-for-project/project-type/project-type.component";
import { ProjectRequestComponent } from "./modules/main/pages/project/project-request/project-request.component";
import { LoginComponent } from "./modules/login/login.component";
import { GeneralResourcesComponent } from "./modules/main/pages/resource/general-resources.component";
import { ProjectFormComponent } from "./modules/main/pages/project/project-form/project-form.component";
import { NotFoundComponent } from './shared/components/not-found/not-found.component';
import { AuthGuard } from "./shared/guards/auth-guard.service";
import { AdminGuard } from "./shared/guards/admin-guard.service";

const routes: Routes = [
  {
    path: "",
    component: MainComponent,
    children: [
      { path: "", component: HomeComponent },
      {
        path: "participants",
        component: ProjectParticipantsComponent,
        canActivate: [AuthGuard]
      },
      {
        path: "projects/create",
        component: ProjectFormComponent,
        canActivate: [AuthGuard]
      },
      {
        path: "projects/:id",
        component: ProjectInfoComponent,
        canActivate: [AuthGuard]
      },
      { path: "projects", component: ProjectComponent },
      { path: "donations/:projectId", component: DonationComponent },
      { path: "donations", component: DonationComponent },
      {
        path: "resources",
        component: GeneralResourcesTableComponent,
        canActivate: [AuthGuard]
      },
      {
        path: "transaction/:donationId",
        component: TransactionResultComponent
      },
      {
        path: "projectTypes",
        component: ProjectTypeComponent,
        canActivate: [AdminGuard]
      },
      {
        path: "projectRequest",
        component: ProjectRequestComponent,
        canActivate: [AdminGuard]
      }
    ]
  },
  { path: "login", component: LoginComponent },
  {
    path: "admin",
    loadChildren: () =>
      import("src/app/modules/manager/manager.module").then(
        m => m.ManagerModule
      ),
    canActivate: [AdminGuard]
  },
  {
    path: 'page-not-found',
    component: NotFoundComponent,
    pathMatch: 'full'
  },
  {
    path: '**',
    redirectTo: 'page-not-found',
    pathMatch: 'full'
  }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, {
      onSameUrlNavigation: "reload"
    })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule {}

export const routingComponents = [
  ProjectFormComponent,
  ProjectParticipantsComponent,
  ProjectComponent,
  HomeComponent,
  ProjectInfoComponent,
  GeneralResourcesComponent,
  ProjectTypeComponent,
  TransactionResultComponent,
  DonationComponent,
  ProjectRequestComponent,
  LoginComponent,
  MainComponent
];
