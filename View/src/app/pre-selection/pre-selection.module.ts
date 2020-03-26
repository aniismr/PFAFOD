import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListCandidaturesComponent } from './list-candidatures/list-candidatures.component';
import { DetailCandidatureComponent } from './detail-candidature/detail-candidature.component';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { MatTableModule } from '@angular/material/table';
import { MatDialogModule } from '@angular/material/dialog';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { LayoutModule } from '@angular/cdk/layout';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import {FormsModule} from '@angular/forms';
import {ReactiveFormsModule} from '@angular/forms';
import { PopupModalComponent } from './popup-modal/popup-modal.component';
import { AddCandidatComponent } from './add-candidat/add-candidat.component';
import { DetailCandidatComponent } from './detail-candidat/detail-candidat.component';
import { AddCandidatureComponent } from './add-candidature/add-candidature.component';
import { ListCandidatComponent } from './list-candidat/list-candidat.component';


@NgModule({
  declarations: [ListCandidaturesComponent, DetailCandidatureComponent, PopupModalComponent, AddCandidatComponent, DetailCandidatComponent, AddCandidatureComponent, ListCandidatComponent],
  imports: [
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    RouterModule,
    LayoutModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule,
    MatDialogModule,
    MatSnackBarModule,
    CommonModule
  ]
})
export class PreSelectionModule { }
