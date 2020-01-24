import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GeneralResourcesComponent } from './general-resources.component';

describe('GeneralResourcesComponent', () => {
  let component: GeneralResourcesComponent;
  let fixture: ComponentFixture<GeneralResourcesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GeneralResourcesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GeneralResourcesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
