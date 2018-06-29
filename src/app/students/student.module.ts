import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormStudentComponent } from './form-student/form-student.component';
import { StudentListComponent } from './student-list/student-list.component';
import { StudentService } from '../services/student.service';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';


@NgModule({
  declarations: [
    FormStudentComponent,
    StudentListComponent,
  ],
  imports: [
    CommonModule,
    FormsModule,
    RouterModule.forChild(
      [
        { path: 'students', component: StudentListComponent },
        { path: 'students/:id', component: FormStudentComponent }
      ])
  ],
  providers: [StudentService],
})
export class StudentModule { }
