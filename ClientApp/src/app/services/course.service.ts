import { Injectable } from '@angular/core';
import { Http } from '@angular/http';

@Injectable()
export class CourseService {

  constructor(private http: Http) { }

  getCourses(){
    return this.http.get('/api/courses')
    .map(res => res.json());
  }

}
