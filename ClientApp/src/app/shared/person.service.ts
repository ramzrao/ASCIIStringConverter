import { Injectable } from '@angular/core';
import { HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ApiService } from './api.service';
import { Person } from '../core/models/person.model';
import { map } from 'rxjs/operators';

@Injectable()
export class PersonService {
  constructor (
    private apiService: ApiService
  ) {}

  save(person): Observable<Person> {
      return this.apiService.post('/Person', person)
        .pipe(map(data => data));
  }




}
