import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProgressService {
//   private currentStep = 0;

//   setCurrentStep(step: number) {
//     this.currentStep = step;
//   }

//   getCurrentStep() {
//     return this.currentStep;
//   }
  private currentStepIndexSubject = new BehaviorSubject<number>(0);
  currentStepIndex$ = this.currentStepIndexSubject.asObservable();

  setCurrentStepIndex(index: number) {
    this.currentStepIndexSubject.next(index);
  }
//   getCurrentStep(){
//     return this.currentStepIndexSubject.value;
//   }
}
