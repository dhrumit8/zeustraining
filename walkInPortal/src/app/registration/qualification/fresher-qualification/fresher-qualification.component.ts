import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { DataSharingService } from 'src/app/services/data-sharing.service';

@Component({
  selector: 'app-fresher-qualification',
  templateUrl: './fresher-qualification.component.html',
  styleUrls: ['./fresher-qualification.component.scss']
})
export class FresherQualificationComponent {
  fresherInfo = new FormGroup({
    javascript: new FormControl(false),
    angularJS: new FormControl(false),
    react: new FormControl(false),
    nodeJS: new FormControl(false),
    other: new FormControl(false),
    otherTech: new FormControl(""),
    appearedZeusTest: new FormControl(false,[Validators.required]),
    roleApplied: new FormControl(""),
  })

  constructor(private datasharingService : DataSharingService) {
    this.fresherInfo = this.datasharingService.fresherInfo || new FormGroup({
      javascript: new FormControl(false),
      angularJS: new FormControl(false),
      react: new FormControl(false),
      nodeJS: new FormControl(false),
      other: new FormControl(false),
      otherTech: new FormControl(""),
      appearedZeusTest: new FormControl(false,[Validators.required]),
      roleApplied: new FormControl(""),
    });
    this.datasharingService.fresherInfo = this.fresherInfo;
  }
  setAppearedZeusTest(value: boolean) {
    this.fresherInfo?.get('appearedZeusTest')?.setValue(value);
  }
  updateData(){
    this.datasharingService.fresherInfo = this.fresherInfo;
  }
}
