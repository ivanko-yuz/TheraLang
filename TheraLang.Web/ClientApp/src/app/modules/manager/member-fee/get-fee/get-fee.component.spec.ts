import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GetFeeComponent } from './get-fee.component';

describe('GetFeeComponent', () => {
  let component: GetFeeComponent;
  let fixture: ComponentFixture<GetFeeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GetFeeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GetFeeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
