/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { PiranhaPageComponent } from './piranha-page.component';

describe('PiranhaPageComponent', () => {
  let component: PiranhaPageComponent;
  let fixture: ComponentFixture<PiranhaPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PiranhaPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PiranhaPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
