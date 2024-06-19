import { Component } from '@angular/core';
import { ProgressService } from '../services/current-step.service';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.scss']
})
export class RegistrationComponent {
//   @Input() currentStepIndex: number = 2;

// onStepChange(step: number) {
//   this.currentStepIndex = step;
// }
// showFresher: boolean = false;
// showExperienced: boolean = false;
// currentStep = 0; // Initial step index

constructor(private progressService: ProgressService) {}

ngOnInit(): void {
  this.progressService.setCurrentStepIndex(2);
}
}
