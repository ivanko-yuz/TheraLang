import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddResourcesToProjectComponent } from './add-resources-to-project.component';

describe('AddResourcesToProjectComponent', () => {
  let component: AddResourcesToProjectComponent;
  let fixture: ComponentFixture<AddResourcesToProjectComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddResourcesToProjectComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddResourcesToProjectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
