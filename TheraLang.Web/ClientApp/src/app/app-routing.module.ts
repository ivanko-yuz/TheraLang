import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { ProjectComponent } from "./modules/main/pages/project/project.component";
import { MainComponent } from "./modules/main/main.component";
import { HomeComponent } from "./modules/main/pages/home/home.component";
import { ProjectParticipantsComponent } from "./modules/main/pages/project/project-participants/project-participants.component";
import { ProjectInfoComponent } from "./modules/main/pages/project/project-info/project-info.component";
import { DonationComponent } from "./modules/main/pages/donation/donation.component";
import { TransactionResultComponent } from "./shared/components/transaction-result/transaction-result.component";
import { LoginComponent } from "./modules/login/login.component";
import { ProjectCreationComponent } from "./modules/main/pages/project/project-creation/project-creation.component";
import { ProjectEditingComponent } from "./modules/main/pages/project/project-editing/project-editing.component";
import { NotFoundComponent } from "./shared/components/not-found/not-found.component";
import { AuthGuard } from "./shared/guards/auth-guard.service";
import { NewsPageComponent } from "./modules/main/pages/news/news-page.component";
import { NewsCreateComponent } from "./modules/main/pages/news/news-create/news-create.component";
import { NewsDetailsComponent } from "./modules/main/pages/news/news-details/news-details.component";
import { AdminGuard } from "./shared/guards/admin-guard.service";
import { PageComponent } from "./modules/main/pages/page/page.component";
import { ResourcesComponent } from "./modules/main/pages/resource/resources.component";
import { ResourceCreateComponent } from "./modules/main/pages/resource/resource-create/resource-create.component";
import {ResourceEditComponent} from "./modules/main/pages/resource/resource-edit/resource-edit.component";
import {ResourcesTableComponent} from "./modules/main/pages/resource/resources-table/resources-table.component";

import {RegistrationComponent} from "./modules/registration/registration.component";
import {UserPageComponent} from "./modules/user-page/user-page.component";
import {ProfileComponent} from "./modules/profile/profile.component";
import {ProfileEditComponent} from "./modules/profile/edit/profile-edit.component";
import {ConfirmationComponent} from "./modules/registration/confirmation/confirmation.component";
import {ResetPasswordComponent} from "./modules/password/reset-password.component";
import {ForgotPasswordComponent} from "./modules/password/email/forgot-password.component";
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
        component: ProjectCreationComponent,
        canActivate: [AuthGuard]
      },
      {
        path: "projects/edit/:id",
        component: ProjectEditingComponent,
        canActivate: [AuthGuard]
      },
      { path: "projects/:id", component: ProjectInfoComponent },
      { path: "projects", component: ProjectComponent },
      { path: "donations/:projectId", component: DonationComponent },
      { path: "donations", component: DonationComponent },
      {
        path: "resources",
        component: ResourcesComponent,
        canActivate: [AuthGuard],
        children: [
          {path: "create", component: ResourceCreateComponent},
          {path: "", pathMatch: "full", component: ResourcesTableComponent},
          {path: ":categoryId", component: ResourcesTableComponent},
          {path: "edit/:resourceId", component: ResourceEditComponent}
        ]
      },
      {
        path: "transaction/:donationId",
        component: TransactionResultComponent
      },
      {
        path: "users/:userID",
        component: UserPageComponent,
        canActivate: [AdminGuard],
      },
      {
        path: "profile",
        component: ProfileComponent,
        canActivate: [AuthGuard],
      },
      {
        path: "profile/edit",
        component: ProfileEditComponent
      },
      { path: "news", component: NewsPageComponent },
      { path: "news/create", component: NewsCreateComponent },
      { path: "news/details/:newsId", component: NewsDetailsComponent },
      {
        component: PageComponent,
        path: "pages/:pageRoute",
      },
      {
        path: "registration/confirm",
        component: ConfirmationComponent,
      },
    ],
  },
  { path: "login", component: LoginComponent },
  { path: "registration", component: RegistrationComponent },
  {
    path: "admin",
    loadChildren: () => import("src/app/modules/manager/manager.module").then(m => m.ManagerModule),
    canActivate: [AdminGuard],
  },
  {
    path: "page-not-found",
    component: NotFoundComponent,
    pathMatch: "full"
  },
  {
    path: "password/forgot",
    component: ForgotPasswordComponent,
  },
  {
    path: "password/reset",
    component: ResetPasswordComponent,
  },
  {
    path: "**",
    redirectTo: "page-not-found",
    pathMatch: "full"
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
export class AppRoutingModule { }

export const routingComponents = [
  ProjectEditingComponent,
  ProjectCreationComponent,
  ProjectParticipantsComponent,
  ProjectComponent,
  HomeComponent,
  ProjectInfoComponent,
  TransactionResultComponent,
  DonationComponent,
  LoginComponent,
  MainComponent
];
