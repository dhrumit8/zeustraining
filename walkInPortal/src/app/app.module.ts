import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from "@angular/forms";
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from "@angular/common/http";

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { LoginComponent } from './login/login.component';
import { RegistrationComponent } from './registration/registration.component';
import { WalkinComponent } from './walkin/walkin.component';
import { PersonalInfoComponent } from './registration/personal-info/personal-info.component';
import { ProgressBarComponent } from './registration/progress-bar/progress-bar.component';
import { QualificationComponent } from './registration/qualification/qualification.component';
import { RegistrationHeaderComponent } from './registration/registration-header/registration-header.component';
import { ReviewComponent } from './registration/review/review.component';
import { EducationalQualificationComponent } from './registration/qualification/educational-qualification/educational-qualification.component';
import { ExperiencedQualificationComponent } from './registration/qualification/experienced-qualification/experienced-qualification.component';
import { FresherQualificationComponent } from './registration/qualification/fresher-qualification/fresher-qualification.component';
import { ProfessionalQualificationComponent } from './registration/qualification/professional-qualification/professional-qualification.component';
import { HallticketComponent } from './walkin/hallticket/hallticket.component';
import { WalkinDetailsComponent } from './walkin/walkin-details/walkin-details.component';
import { WalkinJobRolesComponent } from './walkin/walkin-job-roles/walkin-job-roles.component';
import { AuthService } from './services/auth.service';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    LoginComponent,
    RegistrationComponent,
    WalkinComponent,
    PersonalInfoComponent,
    ProgressBarComponent,
    QualificationComponent,
    RegistrationHeaderComponent,
    ReviewComponent,
    EducationalQualificationComponent,
    ExperiencedQualificationComponent,
    FresherQualificationComponent,
    ProfessionalQualificationComponent,
    HallticketComponent,
    WalkinDetailsComponent,
    WalkinJobRolesComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [
    AuthService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
