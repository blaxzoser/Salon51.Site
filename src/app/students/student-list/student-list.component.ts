import { Component, OnInit } from '@angular/core';
import { StudentService } from '../../services/student.service';
import { Student } from '../../model/student';
import { Observable } from 'rxjs/Observable';
@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.css']
})
export class StudentListComponent implements OnInit {
  private _studentService;
  students: Student[] = [];
  errorMessage: string;
  constructor(private studentService: StudentService) { this._studentService = studentService; }

  ngOnInit() {
    this.studentService.getStudent()
      .subscribe(students => this.students = students,
        error => this.errorMessage = <any>this.errorMessage);

  }

}
