import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PageEntryComponent } from './page-entry.component';

describe('PageEntryComponent', () => {
  let component: PageEntryComponent;
  let fixture: ComponentFixture<PageEntryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PageEntryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PageEntryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
