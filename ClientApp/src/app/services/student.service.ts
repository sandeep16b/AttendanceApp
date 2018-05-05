import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';

@Injectable()
export class StudentService {

  constructor(private http: Http) { }

  getStudents(){
    return this.http.get('/api/students')
    .map(res => res.json());
  }
}
