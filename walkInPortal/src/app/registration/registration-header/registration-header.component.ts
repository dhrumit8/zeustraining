import { Component } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Route, Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';
import { ProgressService } from 'src/app/services/current-step.service';
import { DataSharingService } from 'src/app/services/data-sharing.service';

@Component({
  selector: 'app-registration-header',
  templateUrl: './registration-header.component.html',
  styleUrls: ['./registration-header.component.scss']
})
export class RegistrationHeaderComponent {
  constructor (private progressService: ProgressService,
    private dataSharingService: DataSharingService,
    private authService: AuthService,
    private route: Router
    ){
    this.qualificationInfo = this.dataSharingService.qualificationInfo;
    this.personalInfo = this.dataSharingService.personalInfo;
    this.experiencedInfo = this.dataSharingService.experiencedInfo;
    this.fresherInfo = this.dataSharingService.fresherInfo;
    this.professionalQualificationInfo = this.dataSharingService.professionalQualificationInfo;
  }
  stepIndex = 2;

  qualificationInfo: FormGroup | null;
  personalInfo: FormGroup | null;
  experiencedInfo: FormGroup | null;
  fresherInfo: FormGroup | null;
  professionalQualificationInfo: FormGroup | null;
  displayMessage: string = "";
  isAccountCreated: boolean = false;

  ngOnInit(): void {
    this.progressService.currentStepIndex$.subscribe(index => {
      this.stepIndex = index;
      this.qualificationInfo = this.dataSharingService.qualificationInfo;
      this.personalInfo = this.dataSharingService.personalInfo;
      this.experiencedInfo = this.dataSharingService.experiencedInfo;
      this.fresherInfo = this.dataSharingService.fresherInfo;
      this.professionalQualificationInfo = this.dataSharingService.professionalQualificationInfo;
    });
    console.log(this)
  }

  registerSubmitted(){
    console.log(this.personalInfo);
    this.authService.registerUser([
      this.personalInfo?.get('firstName')?.value,
      this.personalInfo?.get('lastName')?.value,
      this.personalInfo?.get('email')?.value,
      this.personalInfo?.get('phoneCode')?.value,
      this.personalInfo?.get('phoneNumber')?.value,
      this.personalInfo?.get('resume')?.value,
      this.personalInfo?.get('profileImage')?.value,
      this.personalInfo?.get('portfolio')?.value,
      this.personalInfo?.get('referral')?.value,
      this.personalInfo?.get('jobRelatedEmail')?.value
    ],
    this.personalInfo?.get('industrialDesigner')?.value,
    this.personalInfo?.get('softwareEngineer')?.value,
    this.personalInfo?.get('softwareQualityEngineer')?.value,
    this.personalInfo?.get('password')?.value,
    [this.qualificationInfo?.get('percentage')?.value,
      this.qualificationInfo?.get('yearOfPassing')?.value,
      this.qualificationInfo?.get('qualification')?.value,
      this.qualificationInfo?.get('stream')?.value,
      this.qualificationInfo?.get('college')?.value,
      this.qualificationInfo?.get('otherCollege')?.value,
      this.qualificationInfo?.get('collegeLocation')?.value,
      this.qualificationInfo?.get('fresher')?.value,
      this.qualificationInfo?.get('experienced')?.value
    ],
    this.professionalQualificationInfo?.get('applicantType')?.value,
    [
      this.fresherInfo?.get('appearedZeusTest')?.value,
      this.fresherInfo?.get('roleApplied')?.value,
      this.fresherInfo?.get('otherTech')?.value,
    ],
    this.fresherInfo?.get('javascript')?.value,
    this.fresherInfo?.get('angularJS')?.value,
    this.fresherInfo?.get('react')?.value,
    this.fresherInfo?.get('nodeJS')?.value,
    [
      this.experiencedInfo?.get('yearsOfExperience')?.value,
      this.experiencedInfo?.get('currentCTC')?.value,
      this.experiencedInfo?.get('expectedCTC')?.value,
      this.experiencedInfo?.get('onNoticePeriod')?.value,
      this.experiencedInfo?.get('noticePeriodEnd')?.value,
      this.experiencedInfo?.get('noticePeriodLength')?.value,
      this.experiencedInfo?.get('appearedZeusTest')?.value,
      this.experiencedInfo?.get('roleApplied')?.value,
      this.experiencedInfo?.get('otherTechF')?.value,
      this.experiencedInfo?.get('otherTechE')?.value,
    ],
    this.experiencedInfo?.get('javascriptF')?.value,
    this.experiencedInfo?.get('angularJSF')?.value,
    this.experiencedInfo?.get('reactF')?.value,
    this.experiencedInfo?.get('nodeJSF')?.value,
    this.experiencedInfo?.get('javascriptE')?.value,
    this.experiencedInfo?.get('angularJSE')?.value,
    this.experiencedInfo?.get('reactE')?.value,
    this.experiencedInfo?.get('nodeJSE')?.value
  ).subscribe(res => {
      console.log(this.personalInfo?.get('firstName')?.value);
      console.log(this.personalInfo?.get('jobRelatedEmail')?.value);
      console.log(this.personalInfo?.get('industrialDesigner')?.value);
      console.log("prodessional info: ", this.professionalQualificationInfo?.get('applicantType')?.value);
      console.log(res);
      if (res == "Already Exists") {
        this.displayMessage = "Use Another Email. Email already Exists!!";
        this.isAccountCreated = false;
      } else {
        this.displayMessage = "Account Created Successfully";
        this.isAccountCreated = true;
        this.route.navigate(['walkin']);
      }
    });
  }
}
