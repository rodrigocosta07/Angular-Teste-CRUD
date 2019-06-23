import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import {PerguntasService} from '../perguntas.service';
import { Location } from '@angular/common';
import { TipoDificuldade } from 'src/app/tipo-dificuldade/TipoDificuldade';
import { TipoDificuldadeService } from 'src/app/tipo-dificuldade/tipo-dificuldade.service';
import { Observable } from 'rxjs/internal/Observable';

@Component({
  selector: 'app-perguntas-cadastro',
  templateUrl: './perguntas-cadastro.component.html',
  styleUrls: ['./perguntas-cadastro.component.css'],
  providers : [TipoDificuldadeService]

})
export class PerguntasCadastroComponent implements OnInit {

 dificuldades: Observable<TipoDificuldade[]>;

form: FormGroup;
submitted = false;

  constructor(private fb: FormBuilder, private service: PerguntasService,private _DificuldadeService: TipoDificuldadeService, location: Location) { }

 
  ngOnInit() {
    //this._DificuldadeService.list().subscribe(dados => this.dificuldade$ = dados); 
    this.dificuldades = this._DificuldadeService.list();
    this.form = this.fb.group({
      enunciado: [null, [Validators.required]],
      comentario: [null, [Validators.required]],
      disciplina: [null, [Validators.required]],
      TipoDificuldadeId: [null, [Validators.required]],
    })
    

  }

hasError(field: string){
  return this.form.get(field).errors;
  
}

  onSubmit(){
    this.submitted = true;
    console.log(this.form.value);
    //if(this.form.valid){
      console.log('submit');
      this.service.create(this.form.value).subscribe(
        success => {
          console.log('sucesso');
          //this.location.back();
        },
        error => console.error(error),
        () => console.log('request Completo')
      );
   // }
  }

  onCancel(){
    this.submitted = true;
    this.form.reset();
    console.log('cancel');
  }



}
