import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateFeeComponent } from './create-fee.component';

describe('CreateFeeComponent', () => {
  let component: CreateFeeComponent;
  let fixture: ComponentFixture<CreateFeeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CreateFeeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateFeeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
