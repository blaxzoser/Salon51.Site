import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormTeachersComponent } from './form-teachers/form-teachers.component';
import { RouterModule } from '@angular/router';
import { ListTeachersComponent } from './list-teachers/list-teachers.component';

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(
      [
        { path: 'teachers', component: ListTeachersComponent },
        { path: 'teachers/:id', component: FormTeachersComponent }
      ])
  ],
  declarations: [FormTeachersComponent, ListTeachersComponent]
})
export class TeachersModule { }
