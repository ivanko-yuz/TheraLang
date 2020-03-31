import { async, ComponentFixture, TestBed } from "@angular/core/testing";

import { ResourceCategoryComponent } from "./resource-category.component";

describe("ResourceCategoryComponent", () => {
  let component: ResourceCategoryComponent;
  let fixture: ComponentFixture<ResourceCategoryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResourceCategoryComponent ],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResourceCategoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it("should create", () => {
    expect(component).toBeTruthy();
  });
});
