import { Injectable } from '@angular/core';
import { Disciplina } from './disciplina';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { CrudService } from 'src/shared/crud-service';

@Injectable({
  providedIn: 'root'
})
export class DisciplinaService extends CrudService<Disciplina> {

  constructor(protected http: HttpClient) {
    super(http, `${environment.API}disciplinas`);
   }
}
