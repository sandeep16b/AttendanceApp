import { Injectable } from '@angular/core';
import { Http } from '@angular/http';

@Injectable()
export class ClassService {

  constructor(private http: Http) { }

  getClasses(){
    return this.http.get('/api/classes')
    .map(res => res.json());
  }

}
