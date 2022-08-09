import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ClienteService } from 'src/app/core/services/cliente.service';
import { ICliente } from 'src/app/shared/models/ICliente';


@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  private _clienteService : ClienteService;
  public  clienteName = '';

  constructor( private route: ActivatedRoute , private clienteService : ClienteService) {
    this._clienteService = clienteService;
  }



  ngOnInit(): void {
    var id = this.route.snapshot.paramMap.get('id');
     this.clienteService.get(id).subscribe(
      (data) => {
        this.clienteName = data.RazonSocial;
      }
     );
  }

}
