import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ICliente } from '../../shared/models/ICliente';




@Injectable({
  providedIn: 'root'
})





export class ClienteService {
  rootURL = 'https://localhost:7176/api/v1/cliente/';


  constructor(private http : HttpClient) {  }

  public getClientes() {
    return this.http.get<ICliente[]>(this.rootURL);
  }

  public get (id: string | null) : Observable<ICliente>  {
    console.log("service " + id);
    return this.http.get <ICliente> (this.rootURL+ id);
  }
}
