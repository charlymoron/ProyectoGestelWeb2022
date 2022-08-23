import { Component, OnInit } from '@angular/core';
import { ICliente } from 'src/app/shared/models/ICliente';
import { Router } from '@angular/router';
import { ActivatedRoute } from '@angular/router';
import { ClienteService } from 'src/app/core/services/cliente.service';
import { MessageService } from 'primeng/api';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';




@Component({
  selector: 'app-cliente-detalle',
  templateUrl: './cliente-detalle.component.html',
  styleUrls: ['./cliente-detalle.component.css'],
  providers:[MessageService]
})
export class ClienteDetalleComponent implements OnInit {

   cliente : any  ;
   idCliente : any;;
   routerC : Router;
    clientName : string = "";
    clienteForm: FormGroup | undefined;

  constructor( private clienteService : ClienteService ,
    private router: Router,
    private ruta: ActivatedRoute,
    private messageService: MessageService,
    private fb: FormBuilder) {

   this.routerC = router;

   this.clienteForm = this.fb.group({
       razonSocial: ['', [Validators.required]],
       fechaAlta: ['', [Validators.required]]
      });
  }

  ngOnInit(): void {

    this.ruta.paramMap
    .subscribe(params => {
      this.idCliente = params.get("id");
    });

    this.clienteService.get(this.idCliente).subscribe(data => this.cliente = data);

  }

}
