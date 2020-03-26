import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PreSelectionModule } from './pre-selection/pre-selection.module';
import { ListCandidaturesComponent } from './pre-selection/list-candidatures/list-candidatures.component';
import { DetailCandidatureComponent } from './pre-selection/detail-candidature/detail-candidature.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';

const routes: Routes = [
  { path: '', redirectTo: '/candidatures', pathMatch: 'full' },

  { path:'candidatures', component:ListCandidaturesComponent },
  {path:'candidature/:id', component:DetailCandidatureComponent},

  {path: '**' ,component:PageNotFoundComponent}
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes),PreSelectionModule],
  exports: [RouterModule]
})
export class AppRoutingModule { }
