import { Component, ViewChild } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Route, Router } from '@angular/router';
import { ProgressService } from 'src/app/services/current-step.service';
import { DataSharingService } from 'src/app/services/data-sharing.service';
import { EducationalQualificationComponent } from './educational-qualification/educational-qualification.component';
import { ExperiencedQualificationComponent } from './experienced-qualification/experienced-qualification.component';
import { FresherQualificationComponent } from './fresher-qualification/fresher-qualification.component';
import { ProfessionalQualificationComponent } from './professional-qualification/professional-qualification.component';

@Component({
  selector: 'app-qualification',
  templateUrl: './qualification.component.html',
  styleUrls: ['./qualification.component.scss']
})
export class QualificationComponent {
  // currentStepIndex=1;
  // @Output() stepChange = new EventEmitter<number>();

  // currentStep = 1; 

  @ViewChild(EducationalQualificationComponent)
  educationalQualificationComponent!: EducationalQualificationComponent;
  @ViewChild(ExperiencedQualificationComponent)
  experiencedQualificationComponent!: ExperiencedQualificationComponent;
  @ViewChild(FresherQualificationComponent)
  fresherQualificationComponent!: FresherQualificationComponent;
  @ViewChild(ProfessionalQualificationComponent)
  professionalQualificationComponent!: ProfessionalQualificationComponent;

  qualificationInfo: FormGroup | null;
  professionalQualificationInfo: FormGroup | null;
  fresherInfo: FormGroup | null;
  experiencedInfo: FormGroup | null;
  constructor(private progressService: ProgressService,
    private dataSharingService: DataSharingService,
    private router: Router
    ) {
    this.qualificationInfo = this.dataSharingService.qualificationInfo;
  this.professionalQualificationInfo = this.dataSharingService.professionalQualificationInfo;
  this.fresherInfo = this.dataSharingService.fresherInfo;
  this.experiencedInfo = this.dataSharingService.experiencedInfo;
   }


  ngOnInit(): void {
    this.progressService.setCurrentStepIndex(1);
  }


  nextStep() {
    this.educationalQualificationComponent.updateData();
    this.professionalQualificationComponent.updateData();
    this.qualificationInfo = this.dataSharingService.qualificationInfo;
    this.professionalQualificationInfo = this.dataSharingService.professionalQualificationInfo;
    if (this.professionalQualificationInfo?.get('applicantType')?.value === 'Fresher') {
      this.fresherQualificationComponent?.updateData();
      this.fresherInfo = this.dataSharingService.fresherInfo;
      console.log('fresher');
      if (this.qualificationInfo?.valid && this.fresherInfo?.valid && this.professionalQualificationInfo?.valid) {
        this.router.navigate(['registration/review']);
      }
      else {

        console.log('not valid');
      }
    }
    else if (this.professionalQualificationInfo?.get('applicantType')?.value === 'Experienced') {
      this.experiencedQualificationComponent?.updateData();
      this.experiencedInfo = this.dataSharingService.experiencedInfo;
      console.log('Experienced');
      if (this.qualificationInfo?.valid && this.experiencedInfo?.valid && this.professionalQualificationInfo?.valid) {
        this.router.navigate(['registration/review']);
      }
      else {
        console.log('not valid');
      }
    }
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
