import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [  {
  path: '', pathMatch: 'full' , redirectTo:'perguntas'
},
  {
    path: 'perguntas',
    loadChildren: './perguntas/perguntas.module#PerguntasModule',
  }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
