import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PerguntasListaComponent } from './perguntas-lista/perguntas-lista.component';


const routes: Routes = [  {path: '' , component:PerguntasListaComponent}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PerguntasRoutingModule { }
