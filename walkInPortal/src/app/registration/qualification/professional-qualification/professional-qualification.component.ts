import { Component, EventEmitter, Output } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { DataSharingService } from 'src/app/services/data-sharing.service';

@Component({
  selector: 'app-professional-qualification',
  templateUrl: './professional-qualification.component.html',
  styleUrls: ['./professional-qualification.component.scss']
})
export class ProfessionalQualificationComponent {
  isFresher: boolean = false;
  isExperienced: boolean = false;
  hideProf: boolean = true;

  constructor(private datasharingService: DataSharingService,) {
    this.professionalQualificationInfo = this.datasharingService.professionalQualificationInfo || new FormGroup({
      applicantType: new FormControl("", [Validators.required])
    });
    if (this.professionalQualificationInfo.get('applicantType')?.value == 'Fresher') {
      this.showFresher();
    } else if (this.professionalQualificationInfo.get('applicantType')?.value == 'Experienced') {
      this.showExperienced();
    }
    this.datasharingService.professionalQualificationInfo = this.professionalQualificationInfo;
   }

   ngOnInit(){
    // if (!this.professionalQualificationInfo) {
    //   this.datasharingService.professionalQualificationInfo = this.professionalQualificationInfo;
    // }
   }

  //  private initProfQualFormGroup(): void {
  //   this.professionalQualificationInfo = new FormGroup({

  //   })
  //   this.datasharingService.professionalQualificationInfo = this.professionalQualificationInfo;
  //  }

  showFresher() {
    this.isFresher = true;
    this.isExperienced = false;
  }

  showExperienced() {
    this.isExperienced = true;
    this.isFresher = false;
  }

  showHideProf(){
    this.hideProf = !this.hideProf;
  }

  professionalQualificationInfo = null || new FormGroup({
    applicantType: new FormControl("", [Validators.required])
  })

  get ApplicantType(): FormControl {
    return this.professionalQualificationInfo.get('applicantType') as FormControl;
  }
  updateData(){
    this.datasharingService.professionalQualificationInfo = this.professionalQualificationInfo;
  }

  // @Output() showFresherQualification = new EventEmitter<boolean>();
  // @Output() showExperiencedQualification = new EventEmitter<boolean>();

  // showFresher() {
  //   this.showFresherQualification.emit(true);
  //   this.showExperiencedQualification.emit(false);
  // }

  // showExperienced() {
  //   this.showExperiencedQualification.emit(true);
  //   this.showFresherQualification.emit(false);
  // }
}
