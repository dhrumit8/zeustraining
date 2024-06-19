import { Component } from '@angular/core';
import { JobRoles } from 'src/app/interfaces/interfaces';
import { DataSharingService } from 'src/app/services/data-sharing.service';

@Component({
  selector: 'app-walkin-details',
  templateUrl: './walkin-details.component.html',
  styleUrls: ['./walkin-details.component.scss']
})
export class WalkinDetailsComponent {
  hidePreRequisite = true;
  hideRoleID = true;
  hideRoleSE = true;
  hideRoleSQE = true;
  items = [1,2];
  togglePreRequisite() {
    this.hidePreRequisite = !this.hidePreRequisite;
  }
  toggleHideRoleID() {
    this.hideRoleID = !this.hideRoleID;
  }
  toggleHideRoleSE() {
    this.hideRoleSE = !this.hideRoleSE;
  }
  toggleHideRoleSQE() {
    this.hideRoleSQE = !this.hideRoleSQE;
  }

  job: JobRoles = {
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

  constructor(private dataSharingService: DataSharingService){
    this.job = this.dataSharingService.getSelectedItem();
  }
}
