import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JobRolesCardComponent } from './job-roles-card.component';

describe('JobRolesCardComponent', () => {
  let component: JobRolesCardComponent;
  let fixture: ComponentFixture<JobRolesCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [JobRolesCardComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(JobRolesCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
