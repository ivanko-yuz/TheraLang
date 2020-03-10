import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectFiltersComponent } from './project-filters.component';

describe('ProjectFiltersComponent', () => {
  let component: ProjectFiltersComponent;
  let fixture: ComponentFixture<ProjectFiltersComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProjectFiltersComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProjectFiltersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
