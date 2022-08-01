import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SkeletonComponent } from 'src/app/layout/skeleton/skeleton.component';
import { HomeComponent } from './components/home/home.component';

const routes: Routes = [
  {
    path: 'home', component: SkeletonComponent, children: [
      {
        path: '', component: HomeComponent
      }
    ]
  }
];







@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HomeRoutingModule { }
