import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WalkinJobRolesComponent } from './walkin-job-roles.component';

describe('WalkinJobRolesComponent', () => {
  let component: WalkinJobRolesComponent;
  let fixture: ComponentFixture<WalkinJobRolesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [WalkinJobRolesComponent]
    });
    fixture = TestBed.createComponent(WalkinJobRolesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
