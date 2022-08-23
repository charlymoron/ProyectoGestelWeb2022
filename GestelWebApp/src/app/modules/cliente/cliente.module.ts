import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClienteRoutingModule } from './cliente-routing.module';
import { ListaComponent } from './component/lista/lista.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { TableModule } from 'primeng/table';
import { ButtonModule } from 'primeng/button';
import {ToastModule} from 'primeng/toast';
import { ClienteDetalleComponent } from './component/cliente-detalle/cliente-detalle.component';





@NgModule({
  declarations: [
    ListaComponent,
    ClienteDetalleComponent
  ],
  imports: [
    CommonModule,
    ClienteRoutingModule,
    SharedModule,
    TableModule,
    ButtonModule,
    ToastModule
  ],
  exports: []
})
export class ClienteModule { }
