import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NextPrevNavComponent } from './next-prev-nav.component';

describe('NextPrevNavComponent', () => {
  let component: NextPrevNavComponent;
  let fixture: ComponentFixture<NextPrevNavComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NextPrevNavComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(NextPrevNavComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
