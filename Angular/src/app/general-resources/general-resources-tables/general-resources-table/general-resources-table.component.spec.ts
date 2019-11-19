import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GeneralResourcesTableComponent } from './general-resources-table.component';

describe('GeneralResourcesTableComponent', () => {
  let component: GeneralResourcesTableComponent;
  let fixture: ComponentFixture<GeneralResourcesTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GeneralResourcesTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GeneralResourcesTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
