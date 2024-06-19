import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { JobRoles, PersonalData, QualificationData } from "../interfaces/interfaces";
import { FormGroup } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class DataSharingService {
  private personalData: PersonalData = {
    firstName: '',
    lastName: '',
    email: '',
    phoneCode: 91,
    phoneNumber: '',
    resume: '',
    portfolio: '-',
    referral: '-',
    industrialDesigner: false,
    softwareEngineer: false,
    softwareQualityEngineer: false,
    password: '',
  };
  private qualificationData: QualificationData = {
    percentage: 0,
    yearOfPassing: 0,
    qualification: '',
    stream: '',
    college: '',
    otherCollege: '-',
    location: '',
    fresher: false,
    experienced: false,
  }

  setQualificationData(data: QualificationData) {
    this.qualificationData = data;
  }
  getQualificationData() {
    return this.qualificationData;
  }


  setPersonalData(data: PersonalData) {
    this.personalData = data;
  }

  getPersonalData(): PersonalData {
    return this.personalData;
  }
  // private firstName: string = '';

  // setFirstName(data: any) {
  //   this.firstName = data;
  // }

  // getFirstName() {
  //   return this.firstName;
  // }

  private selectedJobRole: JobRoles = {
    id: 0,
    title: null,
    expires: null,
    startDate: null,
    endDate: null,
    location: null,
    industrialDesigner: false,
    softwareEngineer: false,
    softwareQualityEngineer: false,
    opportunity: null,
  };

  setSelectedItem(data: any) {
    this.selectedJobRole = data;
  }

  getSelectedItem() {
    return this.selectedJobRole;
  }
  per = {

    lol: '',
  };
  setlol(data: any){
    this.per = data;
  }
  getlol(){
    return this.per;
  }

  private _personalInfo: FormGroup | null = null;

  get personalInfo(): FormGroup |null {
    return this._personalInfo;
  }

  set personalInfo(value: FormGroup | null) {
    this._personalInfo = value;
  }
  private _qualificationInfo: FormGroup | null = null;

  get qualificationInfo(): FormGroup | null {
    return this._qualificationInfo;
  }

  set qualificationInfo(value: FormGroup | null) {
    this._qualificationInfo = value;
  }
  private _professionalQualificationInfo: FormGroup | null = null;

  get professionalQualificationInfo(): FormGroup | null {
    return this._professionalQualificationInfo;
  }

  set professionalQualificationInfo(value: FormGroup | null) {
    this._professionalQualificationInfo = value;
  }
  private _fresherInfo: FormGroup | null = null;

  get fresherInfo(): FormGroup | null {
    return this._fresherInfo;
  }

  set fresherInfo(value: FormGroup | null) {
    this._fresherInfo = value;
  }
  private _experiencedInfo: FormGroup | null = null;

  get experiencedInfo(): FormGroup | null {
    return this._experiencedInfo;
  }

  set experiencedInfo(value: FormGroup | null) {
    this._experiencedInfo = value;
  }
}
