import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CmsPagesToolbarItemComponent } from './cms-pages-toolbar-item.component';

describe('CmsPagesToolbarItemComponent', () => {
  let component: CmsPagesToolbarItemComponent;
  let fixture: ComponentFixture<CmsPagesToolbarItemComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CmsPagesToolbarItemComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CmsPagesToolbarItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
