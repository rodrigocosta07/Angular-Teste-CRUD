import { Injectable } from '@angular/core';
import { TipoDificuldade } from './TipoDificuldade';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { CrudService } from 'src/shared/crud-service';

@Injectable({
  providedIn: 'root'
})
export class TipoDificuldadeService extends CrudService<TipoDificuldade> {

  constructor(protected http: HttpClient) {
    super(http, `${environment.API}TipoDificuldades`);
  }
}
