import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ICliente } from '../../shared/models/ICliente';




@Injectable({
  providedIn: 'root'
})





export class ClienteService {
  rootURL = 'https://localhost:7176/api/v1/';


  constructor(private http : HttpClient) {  }

  public getClientes() {
    return this.http.get<ICliente[]>(this.rootURL + 'cliente');
  }



}
