import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';
@Injectable()
export class ClassTypeService {

  constructor(private http: Http) { }

  getClassTypes(){
    return this.http.get('/api/classtypes')
    .map(res => res.json());
  }

}
