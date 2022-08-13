import { Component, OnInit } from '@angular/core';

import {MenuItem} from 'primeng/api';



@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

    items!: MenuItem[];
    home!: MenuItem ;

  constructor() { }

  ngOnInit(): void {

    this.items = [
      {
          label: 'Home' ,
          routerLink : '/home'
      },
      {
          label: 'Cliente',
          routerLink: '/cliente'
      },
      {
        label: 'Administración',
        items: [{
          label: 'Tablas Referenciales',
        //  icon: 'pi pi-fw pi-plus',
          items: [
                  {label: 'Tipo Estadistica'},
                  {label: 'Tipo Objeto'},
                 ]
               }]
      }
    ]

    this.home = {icon: 'pi pi-home'};
  }

}
