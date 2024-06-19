import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { DataSharingService } from 'src/app/services/data-sharing.service';

@Component({
  selector: 'app-experienced-qualification',
  templateUrl: './experienced-qualification.component.html',
  styleUrls: ['./experienced-qualification.component.scss']
})
export class ExperiencedQualificationComponent {
  experiencedInfo = new FormGroup({
    yearsOfExperience: new FormControl("", [Validators.required, Validators.pattern("[0-9]+")]),
    currentCTC: new FormControl("", [Validators.required, Validators.pattern("[0-9]+")]),
    expectedCTC: new FormControl("", [Validators.required, Validators.pattern("[0-9]+")]),
    javascriptE: new FormControl(false),
    angularJSE: new FormControl(false),
    reactE: new FormControl(false),
    nodeJSE: new FormControl(false),
    otherE: new FormControl(false),
    otherTechE: new FormControl(""),
    javascriptF: new FormControl(false),
    angularJSF: new FormControl(false),
    reactF: new FormControl(false),
    nodeJSF: new FormControl(false),
    otherF: new FormControl(false),
    otherTechF: new FormControl(""),
    onNoticePeriod: new FormControl(false, [Validators.required]),
    noticePeriodEnd: new FormControl(""),
    noticePeriodLength: new FormControl(""),
    appearedZeusTest: new FormControl(false, [Validators.required]),
    roleApplied: new FormControl(""),
  })

  get YearsOfExperience(): FormControl {
    return this.experiencedInfo.get('yearsOfExperience') as FormControl;
  }
  get CurrentCTC(): FormControl {
    return this.experiencedInfo.get('currentCTC') as FormControl;
  }
  get ExpectedCTC(): FormControl {
    return this.experiencedInfo.get('expectedCTC') as FormControl;
  }

  constructor(private datasharingService: DataSharingService) {
    this.experiencedInfo = this.datasharingService.experiencedInfo || new FormGroup({
      yearsOfExperience: new FormControl("", [Validators.required, Validators.pattern("[0-9]+")]),
      currentCTC: new FormControl("", [Validators.required, Validators.pattern("[0-9]+")]),
      expectedCTC: new FormControl("", [Validators.required, Validators.pattern("[0-9]+")]),
      javascriptE: new FormControl(false),
      angularJSE: new FormControl(false),
      reactE: new FormControl(false),
      nodeJSE: new FormControl(false),
      otherE: new FormControl(false),
      otherTechE: new FormControl(""),
      javascriptF: new FormControl(false),
      angularJSF: new FormControl(false),
      reactF: new FormControl(false),
      nodeJSF: new FormControl(false),
      otherF: new FormControl(false),
      otherTechF: new FormControl(""),
      onNoticePeriod: new FormControl(false, [Validators.required]),
      noticePeriodEnd: new FormControl(""),
      noticePeriodLength: new FormControl(""),
      appearedZeusTest: new FormControl(false, [Validators.required]),
      roleApplied: new FormControl(""),
    });
    this.datasharingService.experiencedInfo = this.experiencedInfo;
  }
  setOnNoticePeriod(value: boolean) {
    this.experiencedInfo?.get('onNoticePeriod')?.setValue(value);
  }
  setAppearedZeusTest(value: boolean) {
    this.experiencedInfo?.get('appearedZeusTest')?.setValue(value);
  }
  updateData(){
    this.datasharingService.experiencedInfo = this.experiencedInfo;
  }
}
