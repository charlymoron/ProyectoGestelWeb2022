import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SkeletonComponent } from 'src/app/layout/skeleton/skeleton.component';
import { ClienteDetalleComponent } from './component/cliente-detalle/cliente-detalle.component';
import { ListaComponent } from './component/lista/lista.component';

const routes: Routes = [
  {
    path: 'cliente', component: SkeletonComponent, children: [
      {
        path: '', component: ListaComponent
      },
      {
        path:':id', component: ClienteDetalleComponent
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ClienteRoutingModule { }
