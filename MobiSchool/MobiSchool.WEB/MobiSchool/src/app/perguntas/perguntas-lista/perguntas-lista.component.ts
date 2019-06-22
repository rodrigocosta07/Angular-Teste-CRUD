import { Component, OnInit } from '@angular/core';
import { PerguntasService } from '../perguntas.service';
import { Pergunta } from '../pergunta';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-perguntas-lista',
  templateUrl: './perguntas-lista.component.html',
  styleUrls: ['./perguntas-lista.component.css']
})
export class PerguntasListaComponent implements OnInit {


  //perguntas: Pergunta[];
  
  perguntas$: Observable<Pergunta[]>;

  constructor(private service: PerguntasService) { }

  ngOnInit() {
    //this.service.list().subscribe(dados => this.perguntas = dados); 
    this.perguntas$ = this.service.list();
  }

}
