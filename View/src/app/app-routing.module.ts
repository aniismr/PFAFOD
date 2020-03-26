import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PreSelectionModule } from './pre-selection/pre-selection.module';
import { ListCandidaturesComponent } from './pre-selection/list-candidatures/list-candidatures.component';
import { DetailCandidatureComponent } from './pre-selection/detail-candidature/detail-candidature.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { AddCandidatComponent } from './pre-selection/add-candidat/add-candidat.component';
import { DetailCandidatComponent } from './pre-selection/detail-candidat/detail-candidat.component';
import { AuthGuard } from './auth.guard';
import { SignInComponent } from './sign-in/sign-in.component';
import { AddCandidatureComponent } from './pre-selection/add-candidature/add-candidature.component';
import {AddUserComponent} from './add-user/add-user.component';
import { ListCandidatComponent } from './pre-selection/list-candidat/list-candidat.component';
const routes: Routes = [
  { path: '', redirectTo: '/candidatures', pathMatch: 'full' ,canActivate: [AuthGuard]},
  {path :'login' ,component:SignInComponent},
  { path:'candidatures', component:ListCandidaturesComponent ,canActivate: [AuthGuard]},
  {path:'candidature/:id', component:DetailCandidatureComponent,canActivate: [AuthGuard]},
  {path :'ajoutCandidat', component:AddCandidatComponent,canActivate: [AuthGuard]},
  {path :'ajoutCandidature',component:AddCandidatureComponent,canActivate: [AuthGuard]},
  {path:'candidat/:id',component:DetailCandidatComponent,canActivate: [AuthGuard]},
  {path:'addUser',component:AddUserComponent,canActivate: [AuthGuard]},
  {path:'candidats',component:ListCandidatComponent,canActivate: [AuthGuard]},
  {path: '**' ,component:PageNotFoundComponent}
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes),PreSelectionModule],
  exports: [RouterModule]
})
export class AppRoutingModule { }
