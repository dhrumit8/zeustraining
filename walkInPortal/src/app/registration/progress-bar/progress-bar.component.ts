import { Component } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { ProgressService } from 'src/app/services/current-step.service';
import { DataSharingService } from 'src/app/services/data-sharing.service';

@Component({
  selector: 'app-progress-bar',
  templateUrl: './progress-bar.component.html',
  styleUrls: ['./progress-bar.component.scss']
})
export class ProgressBarComponent {
  // @Input() currentStepIndex: number = 0;
  currentStepIndex: number = 0;

  constructor(private progressService: ProgressService, private dataSharingService: DataSharingService,) {
    
  }

  ngOnInit(): void {
    // Subscribe to the current step index changes
    this.progressService.currentStepIndex$.subscribe(index => {
      this.currentStepIndex = index;
      
    });
  }
}
