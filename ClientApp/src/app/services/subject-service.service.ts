import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';
@Injectable()
export class SubjectServiceService {

  constructor(private http: Http) { }

  getSubjects(){
    return this.http.get('/api/subjects')
    .map(res => res.json());
  }

}
