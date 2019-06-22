import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PerguntasListaComponent } from './perguntas-lista/perguntas-lista.component';
import { PerguntasCadastroComponent } from './perguntas-cadastro/perguntas-cadastro.component';


const routes: Routes = [  
  {path: '' , component:PerguntasListaComponent},
  {path: 'nova', component: PerguntasCadastroComponent},
  {path: 'editar/:id', component: PerguntasCadastroComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PerguntasRoutingModule { }
