import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GeneralResourcesInnerTableComponent } from './general-resources-inner-table.component';

describe('GeneralResourcesInnerTableComponent', () => {
  let component: GeneralResourcesInnerTableComponent;
  let fixture: ComponentFixture<GeneralResourcesInnerTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GeneralResourcesInnerTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GeneralResourcesInnerTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
