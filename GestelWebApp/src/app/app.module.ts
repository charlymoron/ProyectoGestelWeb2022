import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './layout/header/header.component';
import { FooterComponent } from './layout/footer/footer.component';
import { SkeletonComponent } from './layout/skeleton/skeleton.component';
import { LocationStrategy, PathLocationStrategy } from '@angular/common';
import { HomeModule } from './modules/home/home.module';
import { SharedModule } from './shared/shared.module';
import { ClienteModule } from './modules/cliente/cliente.module';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {MenubarModule} from 'primeng/menubar';
import { InputTextModule } from 'primeng/inputtext';
import { ButtonModule } from 'primeng/button';
import {ImageModule} from 'primeng/image';
import {TableModule} from 'primeng/table';
import {BreadcrumbModule} from 'primeng/breadcrumb';
import { DashboardModule } from './modules/dashboard/dashboard.module';
import { CardModule } from 'primeng/card';
import {PanelModule} from 'primeng/panel';
import { DashboardComponent } from './modules/dashboard/dashboard.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    SkeletonComponent,
    DashboardComponent
 ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    HttpClientModule,
    HomeModule,
    ClienteModule,
    DashboardModule,
    AppRoutingModule,
    SharedModule,
    MenubarModule,
    InputTextModule,
    ButtonModule,
    TableModule,
    ImageModule,
    BreadcrumbModule,
    DashboardModule,
    CardModule,
    PanelModule
  ],
  providers: [
    {
      provide: LocationStrategy,
      useClass: PathLocationStrategy
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
