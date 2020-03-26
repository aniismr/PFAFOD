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


@NgModule({
  declarations: [ListCandidaturesComponent, DetailCandidatureComponent, PopupModalComponent],
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
