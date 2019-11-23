import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TypeProjectFormComponent } from './type-project-form.component';

describe('TypeProjectFormComponent', () => {
  let component: TypeProjectFormComponent;
  let fixture: ComponentFixture<TypeProjectFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TypeProjectFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TypeProjectFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
