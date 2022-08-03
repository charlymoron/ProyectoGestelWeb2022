import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClienteRoutingModule } from './cliente-routing.module';
import { ListaComponent } from './component/lista/lista.component';
import { SharedModule } from 'src/app/shared/shared.module';


@NgModule({
  declarations: [
    ListaComponent
  ],
  imports: [
    CommonModule,
    ClienteRoutingModule,
    SharedModule
  ],
  exports: []
})
export class ClienteModule { }
