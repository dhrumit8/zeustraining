import { Component, EventEmitter, Output } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { PersonalData, QualificationData } from 'src/app/interfaces/interfaces';
import { ProgressService } from 'src/app/services/current-step.service';
import { DataSharingService } from 'src/app/services/data-sharing.service';

@Component({
  selector: 'app-review',
  templateUrl: './review.component.html',
  styleUrls: ['./review.component.scss']
})
export class ReviewComponent {
//   constructor(private router: Router) { }
// goToPersonalInfo() {
//   this.router.navigate(['/personal-info']);
// }

@Output() stepChange = new EventEmitter<number>();

currentStep = 1; // Initial step index
personalInfo : FormGroup | null ;
qualificationInfo : FormGroup | null ;
professionalQualificationInfo : FormGroup | null ;
fresherInfo : FormGroup | null ;
experiencedInfo : FormGroup | null ;
constructor(private progressService: ProgressService, private dataSharingService: DataSharingService, private router: Router) {
  
  // this.personalInfo = this.dataSharingService.getPersonalData();
  this.personalInfo = this.dataSharingService.personalInfo;
  this.qualificationInfo = this.dataSharingService.qualificationInfo;
  this.professionalQualificationInfo = this.dataSharingService.professionalQualificationInfo;
  this.fresherInfo = this.dataSharingService.fresherInfo;
  this.experiencedInfo = this.dataSharingService.experiencedInfo;
  // this.qualificationInfo = this.dataSharingService.getQualificationData();
}
// firstName:string='';
// personalInfo: PersonalData = {
//   firstName: '',
//   lastName: '',
//   email: '',
//   phoneCode: 91,
//   phoneNumber: '',
//   resume: '',
//   portfolio: '',
//   referral: '',
//   jobRelatedEmail: false,
//   industrialDesigner: false,
//   softwareEngineer: false,
//   softwareQualityEngineer: false,
// };
// qualificationInfo: QualificationData = {
//   percentage: 0,
//   yearOfPassing: 0,
//   qualification: '',
//   stream: '',
//   college: '',
//   otherCollege: '-',
//   location: '',
//   fresher: false,
//   experienced: false,
// }

// constructor(private currentStepService: CurrentStepService) { }

ngOnInit(): void {
  this.progressService.setCurrentStepIndex(2);
  console.log(this.experiencedInfo?.get('noticePeriodEnd')?.value);
}

editPersonal() {
  this.router.navigate(['/registration']);
}

editQualification(){
  this.router.navigate(['/registration/qualification']);
}



// nextStep() {
  //   if (this.currentStep < 2) { // Assuming 8 steps in the registration process
  //     this.currentStep++;
  //     this.stepChange.emit(this.currentStep);
  //   }
  // }
  
  // prevStep() {
    //   if (this.currentStep > 0) {
      //     this.currentStep--;
      //     this.stepChange.emit(this.currentStep);
      //   }
      // }
      
    }


    // IMPORTANT
    
    // per = {
    //   lol: 's',
    // }
    // this.per = this.dataSharingService.getlol();