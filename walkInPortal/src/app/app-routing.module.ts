import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { RegistrationComponent } from './registration/registration.component';
import { PersonalInfoComponent } from './registration/personal-info/personal-info.component';
import { QualificationComponent } from './registration/qualification/qualification.component';
import { ReviewComponent } from './registration/review/review.component';
import { WalkinComponent } from './walkin/walkin.component';
import { HallticketComponent } from "./walkin/hallticket/hallticket.component";
import { WalkinDetailsComponent } from "./walkin/walkin-details/walkin-details.component";
import { WalkinJobRolesComponent } from "./walkin/walkin-job-roles/walkin-job-roles.component";


const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'registration', component: RegistrationComponent,
  children: [
    {
      path: 'personalInfo',
      component: PersonalInfoComponent,
    },
    {
      path: 'qualification',
      component: QualificationComponent,
    },
    {
      path: 'review',
      component: ReviewComponent,
    },
    {
      path: '',
      component: PersonalInfoComponent,
    }
  ], },
  { path: 'walkin', component: WalkinComponent,
  children: [
    {
      path: 'job-roles',
      component: WalkinJobRolesComponent,
    },
    {
      path: 'job-details',
      component: WalkinDetailsComponent,
    },
    {
      path: 'hallticket',
      component: HallticketComponent,
    },
    {
      path: '',
      component: WalkinJobRolesComponent,
    }
  ], },
  { path: '', redirectTo: '/login', pathMatch: 'full' },
  { path: '**', redirectTo: '/login' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
