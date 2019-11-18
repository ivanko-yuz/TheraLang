import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TypeProjectComponent } from './type-project.component';

describe('TypeProjectComponent', () => {
  let component: TypeProjectComponent;
  let fixture: ComponentFixture<TypeProjectComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TypeProjectComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TypeProjectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
