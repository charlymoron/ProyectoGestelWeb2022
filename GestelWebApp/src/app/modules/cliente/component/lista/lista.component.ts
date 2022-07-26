import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ClienteService } from 'src/app/core/services/cliente.service';
import { ICliente } from 'src/app/shared/models/ICliente';
import { MenuItem, MessageService } from 'primeng/api';

@Component({
  selector: 'app-lista',
  templateUrl: './lista.component.html',
  styleUrls: ['./lista.component.css'],
  providers:[MessageService]
})

export class ListaComponent implements OnInit {

  itemsMenu!: MenuItem[];


  public listaClientes: ICliente[] = [];
   selectedCliente: any = null;;
   loading = false;
   routerC : Router;





  constructor(private clienteService : ClienteService ,
    private router: Router,
    private messageService: MessageService) {
   this.routerC = router;
    this.isRowSelectable = this.isRowSelectable.bind(this);
  }

  ngOnInit(): void {
      this.loading = true;

      this.itemsMenu = [
        {
          label: 'Nuevo',
          icon: 'pi pi-fw pi-plus'
        }
      ];

      setTimeout(() => {
        this.clienteService.getClientes().subscribe((data: ICliente[]) =>
      {
        this.listaClientes = data;
        this.loading = false;
      } );
        this.loading = false;
    }, 1000);


  }

 goDashboardCliente(idCliente: number)
 {
  this.routerC.navigateByUrl("/dashboard/"+idCliente);
 }

  goDashboard(id: number) {

    this.routerC.navigateByUrl("/dashboard/"+id);
  }

  edit(id: number) {
    this.routerC.navigateByUrl("/cliente/"+id);
  }




  selectCliente(cliente: ICliente) {
    this.messageService.add({severity:'info', summary:'CLiente Selected', detail: cliente.RazonSocial});
   }

    onRowSelect(event:  any ) {
        console.log(event);
        this.selectedCliente = event.data.Id;
        console.log(this.selectedCliente);
        this.messageService.add({severity:'info', summary:'Product Selected', detail: event.data.RazonSocial});
    }

    onRowUnselect(event: any) {
        this.selectedCliente = null;
        this.messageService.add({severity:'info', summary:'Product Unselected',  detail: event.data.RazonSocial});
    }

    isRowSelectable(event: any ) {

        return this.isClienteConBaja(event.data.FechaBaja) == false;
    }

    isClienteConBaja( fechaBaja : any ) {
        return fechaBaja == null;
    }

}
