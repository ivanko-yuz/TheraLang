import { async, ComponentFixture, TestBed } from "@angular/core/testing";

import { ResourceEntryComponent } from "./resource-entry.component";

describe("ResourceEntryComponent", () => {
  let component: ResourceEntryComponent;
  let fixture: ComponentFixture<ResourceEntryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResourceEntryComponent ],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResourceEntryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it("should create", () => {
    expect(component).toBeTruthy();
  });
});
