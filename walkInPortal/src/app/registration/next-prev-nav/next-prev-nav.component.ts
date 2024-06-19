import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-next-prev-nav',
  standalone: true,
  imports: [],
  templateUrl: './next-prev-nav.component.html',
  styleUrls: ['./next-prev-nav.component.scss']
})
export class NextPrevNavComponent {
  @Output() stepChange = new EventEmitter<number>();

  currentStep = 0; // Initial step index

  constructor() { }

  nextStep() {
    if (this.currentStep < 2) { // Assuming 8 steps in the registration process
      this.currentStep++;
      this.stepChange.emit(this.currentStep);
    }
  }

  prevStep() {
    if (this.currentStep > 0) {
      this.currentStep--;
      this.stepChange.emit(this.currentStep);
    }
  }
}

