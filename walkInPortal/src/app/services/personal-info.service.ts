import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class PersonalInfoService {
//   private personalInfo: any;

//   setPersonalInfo(info: any) {
//     this.personalInfo = info;
//   }

//   getPersonalInfo() {
//     return this.personalInfo;
//   }
firstName: string = '';

  constructor() {}
}