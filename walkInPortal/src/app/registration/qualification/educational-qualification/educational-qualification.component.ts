import { Component } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { QualificationData } from 'src/app/interfaces/interfaces';
import { DataSharingService } from 'src/app/services/data-sharing.service';

@Component({
  selector: 'app-educational-qualification',
  templateUrl: './educational-qualification.component.html',
  styleUrls: ['./educational-qualification.component.scss']
})
export class EducationalQualificationComponent {
  hideEducational = true;
  toggleEducational() {
    this.hideEducational = !this.hideEducational;
  }
  //   qualificationInfo: QualificationData = {
  //     percentage: 0,
  //     yearOfPassing: 0,
  //     qualification: '',
  //     stream: '',
  //     college: '',
  //     otherCollege: '',
  //     location: '',
  //     fresher: false,
  //     experienced: false,
  // }
  qualificationInfo = null || new FormGroup({
    percentage: new FormControl("", [Validators.required, Validators.minLength(1), Validators.pattern("[0-9]{1,2}")]),
    yearOfPassing: new FormControl("", [Validators.required, Validators.minLength(4), Validators.pattern("[0-9]{4}")]),
    qualification: new FormControl("", [Validators.required]),
    stream: new FormControl("", [Validators.required]),
    college: new FormControl("", [Validators.required]),
    otherCollege: new FormControl(""),
    collegeLocation: new FormControl("", [Validators.required]),
  })

  get Percentage(): FormControl {
    return this.qualificationInfo.get('percentage') as FormControl;
  }
  get YearOfPassing(): FormControl {
    return this.qualificationInfo.get('yearOfPassing') as FormControl;
  }
  get Qualification(): FormControl {
    return this.qualificationInfo.get('qualification') as FormControl;
  }
  get Stream(): FormControl {
    return this.qualificationInfo.get('stream') as FormControl;
  }
  get College(): FormControl {
    return this.qualificationInfo.get('college') as FormControl;
  }
  get CollegeLocation(): FormControl {
    return this.qualificationInfo.get('collegeLocation') as FormControl;
  }

  ngOnInit(): void {
    if (!this.qualificationInfo) {
      this.initQualificationInfoFormGroup();
    }
  }
  private initQualificationInfoFormGroup(): void {
    this.qualificationInfo = new FormGroup({
      percentage: new FormControl("", [Validators.required, Validators.minLength(1), Validators.pattern("[0-9]{1,2}")]),
      yearOfPassing: new FormControl("", [Validators.required, Validators.minLength(4), Validators.pattern("[0-9]{4}")]),
      qualification: new FormControl("", [Validators.required]),
      stream: new FormControl("", [Validators.required]),
      college: new FormControl("", [Validators.required]),
      otherCollege: new FormControl(""),
      collegeLocation: new FormControl("", [Validators.required]),
    });
    this.datasharingService.qualificationInfo = this.qualificationInfo;
  }

  constructor(private datasharingService: DataSharingService) {
    // this.qualificationInfo = this.datasharingService.getQualificationData();
    this.qualificationInfo = this.datasharingService.qualificationInfo!;
    // this.qualificationInfo = this.datasharingService.qualificationInfo || new FormGroup({
    //   percentage: new FormControl(this.qualificationInfo?.get('percentage')?.value, [Validators.required, Validators.minLength(1), Validators.pattern("[0-9]{1,2}")]),
    //   yearOfPassing: new FormControl(this.qualificationInfo?.get('stream')?.value, [Validators.required, Validators.minLength(4), Validators.pattern("[0-9]{4}")]),
    //   qualification: new FormControl("", [Validators.required]),
    //   stream: new FormControl("", [Validators.required]),
    //   college: new FormControl("", [Validators.required]),
    //   otherCollege: new FormControl(""),
    //   collegeLocation: new FormControl("", [Validators.required]),
    // })
    this.datasharingService.qualificationInfo = this.qualificationInfo;

  }

  updateData(){
    this.datasharingService.qualificationInfo = this.qualificationInfo;
  }
}
