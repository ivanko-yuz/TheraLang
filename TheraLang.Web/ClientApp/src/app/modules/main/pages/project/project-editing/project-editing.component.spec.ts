import { async, ComponentFixture, TestBed } from "@angular/core/testing";

import { ProjectEditingComponent } from "./project-editing.component";

describe("ProjectEditingComponent", () => {
  let component: ProjectEditingComponent;
  let fixture: ComponentFixture<ProjectEditingComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProjectEditingComponent ],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProjectEditingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it("should create", () => {
    expect(component).toBeTruthy();
  });
});
