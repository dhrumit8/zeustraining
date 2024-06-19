import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ExperiencedQualificationComponent } from './experienced-qualification.component';

describe('ExperiencedQualificationComponent', () => {
  let component: ExperiencedQualificationComponent;
  let fixture: ComponentFixture<ExperiencedQualificationComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ExperiencedQualificationComponent]
    });
    fixture = TestBed.createComponent(ExperiencedQualificationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
