import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { InputTextModule } from 'primeng/inputtext';
import { ButtonModule } from 'primeng/button';
import {ImageModule} from 'primeng/image';
import {TableModule} from 'primeng/table';
import {BreadcrumbModule} from 'primeng/breadcrumb';
import { CardModule } from 'primeng/card';
import {PanelModule} from 'primeng/panel';
import {MenubarModule} from 'primeng/menubar';
import {ToolbarModule} from 'primeng/toolbar';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    InputTextModule,
    ButtonModule,
    ImageModule,
    TableModule,
    BreadcrumbModule,
    CardModule,
    PanelModule,
    ToolbarModule,
    MenubarModule
  ],
  exports:[
    InputTextModule,
    ButtonModule,
    ImageModule,
    TableModule,
    BreadcrumbModule,
    CardModule,
    PanelModule,
    MenubarModule,
    ToolbarModule
  ]
})
export class PrimengModule { }
