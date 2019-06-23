import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Pergunta } from "./pergunta";
import { environment } from "src/environments/environment";
import { CrudService } from 'src/shared/crud-service';

@Injectable({
  providedIn: "root"
})
export class PerguntasService extends CrudService<Pergunta> {
 
  constructor(protected http: HttpClient) {
    super(http, `${environment.API}perguntas`);
  }
}
