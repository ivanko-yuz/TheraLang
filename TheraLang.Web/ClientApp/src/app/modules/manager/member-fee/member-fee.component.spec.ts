import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MemberFeeComponent } from './member-fee.component';

describe('MemberFeeComponent', () => {
  let component: MemberFeeComponent;
  let fixture: ComponentFixture<MemberFeeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MemberFeeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MemberFeeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
