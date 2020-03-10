import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SliderRowComponent } from './slider-row.component';

describe('SliderRowComponent', () => {
  let component: SliderRowComponent;
  let fixture: ComponentFixture<SliderRowComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SliderRowComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SliderRowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
