import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectTypeComponent } from './project-type.component';

describe('ProjectTypeComponent', () => {
  let component: ProjectTypeComponent;
  let fixture: ComponentFixture<ProjectTypeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProjectTypeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProjectTypeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
