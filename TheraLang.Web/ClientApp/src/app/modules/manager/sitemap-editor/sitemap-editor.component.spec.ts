import { async, ComponentFixture, TestBed } from "@angular/core/testing";

import { SitemapEditorComponent } from "./sitemap-editor.component";

describe("SitemapEditorComponent", () => {
  let component: SitemapEditorComponent;
  let fixture: ComponentFixture<SitemapEditorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [SitemapEditorComponent]
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SitemapEditorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it("should create", () => {
    expect(component).toBeTruthy();
  });
});
