import { HttpClient } from '@angular/common/http';
import { delay, tap, take } from 'rxjs/operators';

export class CrudService<T> {

    constructor( protected http: HttpClient, private API_URL ){}

    
  list() {
    return this.http.get<T[]>(this.API_URL).pipe(
      delay(2000),
      tap(console.log)
    );
  }

  create(record: T){
    return this.http.post(this.API_URL, record).pipe(take(1));
  }
}


