import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ResourcesInternalTableComponent } from './resources-internal-table.component';

describe('ResourcesInternalTableComponent', () => {
  let component: ResourcesInternalTableComponent;
  let fixture: ComponentFixture<ResourcesInternalTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResourcesInternalTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResourcesInternalTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
