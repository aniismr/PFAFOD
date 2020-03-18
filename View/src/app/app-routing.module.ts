import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';



import { ListingCondidatsComponent } from './listing-candidats/listing-candidats.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { LoginPageComponent } from './identification/login-page/login-page.component';
import { DetailCandidatComponent } from './detail-candidat/detail-candidat.component';
import { IdentificationModule } from './identification/identification.module';
import { BrowserModule } from '@angular/platform-browser';
const routes: Routes = [
  { path:'listCandidats', component:ListingCondidatsComponent },
  { path: '', redirectTo: '/listCandidats', pathMatch: 'full' },
  {path:'candidat/:id', component:DetailCandidatComponent},
  {path: '**' ,component:PageNotFoundComponent}
  
];
const loginRoute: Routes = [  {path:'login' , component:LoginPageComponent}
]

@NgModule({
  imports: [RouterModule.forRoot(routes),IdentificationModule],
  exports: [RouterModule]
})
export class AppRoutingModule { }
