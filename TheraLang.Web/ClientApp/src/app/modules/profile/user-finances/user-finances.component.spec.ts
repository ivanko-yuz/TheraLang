import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UserFinancesComponent } from './user-finances.component';

describe('UserFinancesComponent', () => {
  let component: UserFinancesComponent;
  let fixture: ComponentFixture<UserFinancesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UserFinancesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UserFinancesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
