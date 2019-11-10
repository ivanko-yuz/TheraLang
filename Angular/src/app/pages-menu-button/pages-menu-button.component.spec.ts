import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PagesMenuButtonComponent } from './pages-menu-button.component';

describe('PagesMenuButtonComponent', () => {
  let component: PagesMenuButtonComponent;
  let fixture: ComponentFixture<PagesMenuButtonComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PagesMenuButtonComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PagesMenuButtonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
