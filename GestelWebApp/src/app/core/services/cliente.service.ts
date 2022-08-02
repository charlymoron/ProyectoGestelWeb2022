import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ICliente } from '../../shared/models/ICliente';




@Injectable({
  providedIn: 'root'
})





export class ClienteService {
  rootURL = '/api';


  constructor(private http : HttpClient) {  }

  getClientes() {
    return this.http.get(this.rootURL + '/cliente');
  }



}
