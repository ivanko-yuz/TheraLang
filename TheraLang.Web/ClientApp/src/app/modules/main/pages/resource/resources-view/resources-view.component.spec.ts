import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ResourcesViewComponent } from './resources-view.component';

describe('ResourcesViewComponent', () => {
  let component: ResourcesViewComponent;
  let fixture: ComponentFixture<ResourcesViewComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResourcesViewComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResourcesViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
