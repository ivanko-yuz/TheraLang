import { async, ComponentFixture, TestBed } from "@angular/core/testing";
import { ProjectTypeCreateFormComponent } from "./project-type-create-form.component";

describe("ProjectTypeCreateFormComponent", () => {
  let component: ProjectTypeCreateFormComponent;
  let fixture: ComponentFixture<ProjectTypeCreateFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ProjectTypeCreateFormComponent],
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProjectTypeCreateFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it("should create", () => {
    expect(component).toBeTruthy();
  });
});
