import { Component, OnInit } from '@angular/core';
import { ClienteService } from 'src/app/core/services/cliente.service';
import { ICliente } from 'src/app/shared/models/ICliente';

@Component({
  selector: 'app-lista',
  templateUrl: './lista.component.html',
  styleUrls: ['./lista.component.css']
})
export class ListaComponent implements OnInit {

  public listaClientes: ICliente[] = [];

  constructor(private clienteService : ClienteService) { }

  ngOnInit(): void {

     this.clienteService.getClientes().subscribe((data: ICliente[])=>{
      this.listaClientes=data;
      console.log(data);

    } );
  }
}
