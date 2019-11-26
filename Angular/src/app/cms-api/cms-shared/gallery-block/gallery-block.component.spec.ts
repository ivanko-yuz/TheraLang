import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GalleryBlockComponent } from './gallery-block.component';

describe('GalleryBlockComponent', () => {
  let component: GalleryBlockComponent;
  let fixture: ComponentFixture<GalleryBlockComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GalleryBlockComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GalleryBlockComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
