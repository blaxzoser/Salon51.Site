import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FormTeachersComponent } from './form-teachers.component';

describe('FormTeachersComponent', () => {
  let component: FormTeachersComponent;
  let fixture: ComponentFixture<FormTeachersComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FormTeachersComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FormTeachersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
