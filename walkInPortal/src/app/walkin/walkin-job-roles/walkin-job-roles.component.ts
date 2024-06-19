import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { JobRoles } from 'src/app/interfaces/interfaces';
import { AuthService } from 'src/app/services/auth.service';
import { DataSharingService } from 'src/app/services/data-sharing.service';

@Component({
  selector: 'app-walkin-job-roles',
  templateUrl: './walkin-job-roles.component.html',
  styleUrls: ['./walkin-job-roles.component.scss']
})
export class WalkinJobRolesComponent {
  jobs: JobRoles[] = [
    // {
    //   id: 1,
    //   title: 'WalkIn for Designer Job Role',
    //   expires: 5,
    //   startDate: '10-Jul-2024',
    //   endDate: '11-Jul-2024',
    //   location: 'Mumbai',
    //   industrialDesigner: true,
    //   softwareEngineer: false,
    //   softwareQualityEngineer: false,
    //   opportunity: null,
    // },
    // {
    //   title: 'WalkIn for Multiple Job Roles',
    //   expires: null,
    //   startDate: '03-Jul-2024',
    //   endDate: '03-Jul-2024',
    //   location: 'Mumbai',
    //   industrialDesigner: true,
    //   softwareEngineer: true,
    //   softwareQualityEngineer: true,
    //   opportunity: 'Internship Opportunity for MCA Students',
    // },
    // {
    //   title: 'WalkIn for Software Roles',
    //   expires: null,
    //   startDate: '10-Jul-2024',
    //   endDate: '11-Jul-2024',
    //   location: 'Mumbai',
    //   industrialDesigner: true,
    //   softwareEngineer: true,
    //   softwareQualityEngineer: false,
    //   opportunity: null,
    // },

  ]
  
  constructor(private dataService: DataSharingService, private authService: AuthService) {}
  
  ngOnInit(): void {
    this.authService.getJobDetails().subscribe(res => {
    //   console.log(res);
      const parsedResponse: any = JSON.parse(res);
      console.log("parsed : ", parsedResponse);
      this.jobs = parsedResponse.map((job: any) => {
        return {
          id: job.id,
          title: job.jobTitle,
          expires: job.expires || null,
          startDate: job.startDate,
          endDate: job.endDate,
          location: job.location,
          // industrialDesigner: job.roles.includes('Industrial Designer'),
          // softwareEngineer: job.roles.includes('Software Engineer'),
          // softwareQualityEngineer: job.roles.includes('Software Quality Engineer'),
          opportunity: job.specialOpportunity || null,
        };
      });
    });
    console.log(this.jobs);
    this.authService.getJobRoles().subscribe(res => {
      const parsedResponse: any = JSON.parse(res);
      this.jobs.forEach((item)=>{
        for (let index = 0; index < parsedResponse.length; index++) {
          if (item.id == parsedResponse[index].jobId && parsedResponse[index].jobRolesId == 1) {
            item.industrialDesigner = true
          }
          else if (item.id == parsedResponse[index].jobId && parsedResponse[index].jobRolesId == 2) {
            item.softwareEngineer = true
          }
          else if (item.id == parsedResponse[index].jobId && parsedResponse[index].jobRolesId == 3) {
            item.softwareQualityEngineer = true
          }
        }
      })
    });
  }
  
  viewDetails(job: JobRoles){
    this.dataService.setSelectedItem(job);
  }
}