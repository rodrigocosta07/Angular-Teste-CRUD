import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PerguntasRoutingModule } from './perguntas-routing.module';
import { PerguntasListaComponent } from './perguntas-lista/perguntas-lista.component';

@NgModule({
  declarations: [PerguntasListaComponent],
  imports: [
    CommonModule,
    PerguntasRoutingModule
  ]
})
export class PerguntasModule { }
