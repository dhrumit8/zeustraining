import { Component, EventEmitter, Output } from '@angular/core'
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Route, Router } from '@angular/router';
import { PersonalData } from 'src/app/interfaces/interfaces';
import { ProgressService } from 'src/app/services/current-step.service';
import { DataSharingService } from 'src/app/services/data-sharing.service';

@Component({
  selector: 'app-personal-info',
  templateUrl: './personal-info.component.html',
  styleUrls: ['./personal-info.component.scss']
})

export class PersonalInfoComponent {
  // @Output() stepChange = new EventEmitter<number>();

  // currentStep = 0; 
  // name:string='';
  // personalInfo: PersonalData = {
  //   firstName: '',
  //   lastName: '',
  //   email: '',
  //   phoneCode: 91,
  //   phoneNumber: '',
  //   resume: '',
  //   portfolio: '',
  //   referral: '',
  //   industrialDesigner: false,
  //   softwareEngineer: false,
  //   softwareQualityEngineer: false,
  //   jobRelatedEmail: false,
  // };

  personalInfo = new FormGroup({
    firstName: new FormControl("", [Validators.required, Validators.minLength(2), Validators.pattern("[a-zA-Z]+")]),
    lastName: new FormControl("", [Validators.required, Validators.minLength(2), Validators.pattern("[a-zA-Z]+")]),
    email: new FormControl("", [Validators.required, Validators.email]),
    phoneCode: new FormControl("", [Validators.required, Validators.minLength(2), Validators.pattern("[0-9]+")]),
    phoneNumber: new FormControl("", [Validators.required, Validators.minLength(10), Validators.pattern("[0-9]+")]),
    resume: new FormControl(""),
    portfolio: new FormControl(""),
    profileImage: new FormControl(""),
    referral: new FormControl(""),
    industrialDesigner: new FormControl(false),
    softwareEngineer: new FormControl(false),
    softwareQualityEngineer: new FormControl(false),
    jobRelatedEmail: new FormControl(false),
    password: new FormControl(""),
  })

  get FirstName(): FormControl {
    return this.personalInfo.get('firstName') as FormControl;
  }
  get LastName(): FormControl {
    return this.personalInfo.get('lastName') as FormControl;
  }
  get Email(): FormControl {
    return this.personalInfo.get('email') as FormControl;
  }
  get PhoneCode(): FormControl {
    return this.personalInfo.get('phoneCode') as FormControl;
  }
  get PhoneNumber(): FormControl {
    return this.personalInfo.get('phoneNumber') as FormControl;
  }

  // roles = [
  //   'industrial Designer',
  //   'software Engineer',
  //   'software Quality Engineer',
  // ];
  // updateRole(role: string) {
  //   const propertyName = role.toLowerCase().replace(/ /g, '') as keyof PersonalData;
  //   if (this.personalInfo.hasOwnProperty(propertyName)) {
  //     this.personalInfo[propertyName] = !this.personalInfo[propertyName];
  //   }
  // }


  constructor(private progressService: ProgressService,
    private datasharingService: DataSharingService,
    private route: ActivatedRoute,
    private router: Router
  ) {
    this.personalInfo = this.datasharingService.personalInfo || new FormGroup({
      firstName: new FormControl("", [Validators.required, Validators.minLength(2), Validators.pattern("[a-zA-Z]+")]),
      lastName: new FormControl("", [Validators.required, Validators.minLength(2), Validators.pattern("[a-zA-Z]+")]),
      email: new FormControl("", [Validators.required, Validators.email]),
      phoneCode: new FormControl("", [Validators.required, Validators.minLength(2), Validators.pattern("[0-9]+")]),
      phoneNumber: new FormControl("", [Validators.required, Validators.minLength(10), Validators.pattern("[0-9]+")]),
      resume: new FormControl(""),
      portfolio: new FormControl(""),
      profileImage: new FormControl(""),
      referral: new FormControl(""),
      industrialDesigner: new FormControl(false),
      softwareEngineer: new FormControl(false),
      softwareQualityEngineer: new FormControl(false),
      jobRelatedEmail: new FormControl(false),
      password: new FormControl(""),
    });
    // this.personalInfo = this.datasharingService.personalInfo;
    // this.route.queryParams.subscribe(params => {
    //   if (params['personalInfo']) {
    //     this.personalInfo = JSON.parse(params['personalInfo']);
    //     // console.log('hii')
    //   }
    // });
    // this.personalInfo = this.datasharingService.getPersonalData();
  }
  // constructor(private currentStepService: CurrentStepService) { }

  ngOnInit(): void {
    this.progressService.setCurrentStepIndex(0);
    // this.name=this.datasharingService.getFirstName();
    // this.route?.data?.subscribe(data => {
    //   this.personalInfo = data?.['data'];
    // });
  }

  nextStep() {
    if (this.personalInfo.valid) {
      this.datasharingService.personalInfo = this.personalInfo;
      this.router.navigate(['registration/qualification']);
    }
    // this.datasharingService.setFirstName(formData);
    // this.datasharingService.setPersonalData(this.personalInfo);
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

// this.datasharingService.setlol(this.personalForm.value);
// console.log(this.personalForm.value);



// personalForm = new FormGroup({
//   lol: new FormControl(""),
// });