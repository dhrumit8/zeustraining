import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FresherQualificationComponent } from './fresher-qualification.component';

describe('FresherQualificationComponent', () => {
  let component: FresherQualificationComponent;
  let fixture: ComponentFixture<FresherQualificationComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [FresherQualificationComponent]
    });
    fixture = TestBed.createComponent(FresherQualificationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
