import { Component, OnInit } from '@angular/core';
import { Student } from '../../model/student';
import { ActivatedRoute, Router, ParamMap } from '@angular/router';
import { StudentService } from '../../services/student.service';
import { Observable } from 'rxjs/Observable';

@Component({
  selector: 'app-form-student',
  templateUrl: './form-student.component.html',
  styleUrls: ['./form-student.component.css']
})
export class FormStudentComponent implements OnInit {
  submitted = false;
  model: Student;
  typePublicities = ['Facebook', 'Amigos',
    'Concursos', 'Youtube', 'Instagram'];
  onSubmit() {
    this.submitted = true;
    this.newStudent();
    alert('Registro Completo');
  }
  newStudent() {
     this.model = new Student(0, '', 0, '', '', 0, '', '');
  }
  // TODO: Remove this when we're done
  get diagnostic() { return JSON.stringify(this.model); }

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private service: StudentService
  ) {
    this.service = service;
  }
  ngOnInit() {
    this.newStudent();
    const id = +this.route.snapshot.paramMap.get('id');
    console.log(id);
    if (id !== 0) {
      this.service.get(id).subscribe(student => this.model = student);
      console.log('entro');
    }

  }

}
