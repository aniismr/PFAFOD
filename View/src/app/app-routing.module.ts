import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {HomeComponent} from './home/home.component';


import { ListingCondidatsComponent } from './listing-candidats/listing-candidats.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';

import { DetailCandidatComponent } from './detail-candidat/detail-candidat.component';
import { LoginPageModule } from './login-page/login-page.module';
import { SigninComponent } from './login-page/signin/signin.component';
import { AuthGuard } from './login-page/auth.guard';


const routes: Routes = [
  { path: 'home', component: HomeComponent },
  { path: '', redirectTo: '/candidatures', pathMatch: 'full' },
  { path: 'login', component: SigninComponent },
  { path:'candidatures', component:ListingCondidatsComponent },
  {path:'candidature/:id', component:DetailCandidatComponent},

  {path: '**' ,component:PageNotFoundComponent}
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes),LoginPageModule],
  exports: [RouterModule]
})
export class AppRoutingModule { }
