import { Component, OnInit } from '@angular/core';
import { Teacher } from '../../model/teacher';
import {TEACHERS} from '../../mokes/mokes-teachers';

@Component({
  selector: 'app-list-teachers',
  templateUrl: './list-teachers.component.html',
  styleUrls: ['./list-teachers.component.css']
})
export class ListTeachersComponent implements OnInit {
  teachers = TEACHERS;
  constructor() { }

  ngOnInit() {

  }

}
