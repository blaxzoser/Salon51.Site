import { Injectable } from '@angular/core';
import { Student } from '../model/student';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';

@Injectable()
export class StudentService {
    private _studentURL = 'http://localhost:52280/api/student/';
    constructor(private _http: HttpClient) { }

    getStudent(): Observable<Student[]> {
        return this._http.get<Student[]>(this._studentURL);

    }

    private handleError(err: HttpErrorResponse) {

    }

    get(idStudent: number): Observable<Student> {
        return this._http.get<Student>(this._studentURL + String(idStudent));
        //  return new Student(idStudent, 'Miguel', 54, 'strato.beto@gmailcom', '13/12/2012', 12233, 'Facebook', 'Disctrito Federal');
    }
}
