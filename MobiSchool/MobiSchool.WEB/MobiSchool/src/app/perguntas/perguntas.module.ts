import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';

import { PerguntasRoutingModule } from './perguntas-routing.module';
import { PerguntasListaComponent } from './perguntas-lista/perguntas-lista.component';
import { PerguntasCadastroComponent } from './perguntas-cadastro/perguntas-cadastro.component';

@NgModule({
  declarations: [PerguntasListaComponent, PerguntasCadastroComponent],
  imports: [
    CommonModule,
    PerguntasRoutingModule,
    ReactiveFormsModule
  ]
})
export class PerguntasModule { }
