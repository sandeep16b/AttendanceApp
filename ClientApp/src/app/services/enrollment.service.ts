import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';

@Injectable()
export class EnrollmentService {

  constructor(private http: Http) { }

  getEnrollments(){
    return this.http.get('/api/enrollments')
    .map(res => res.json());
  }
}
