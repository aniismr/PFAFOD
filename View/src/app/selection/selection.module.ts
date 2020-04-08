import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TestTechniqueComponent } from './test-technique/test-technique.component';
import { QuestionTestComponent } from './question-test/question-test.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { LayoutModule } from '@angular/cdk/layout';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { MatDialogModule } from '@angular/material/dialog';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { CategorieSelectorComponent } from './categorie-selector/categorie-selector.component';
import { ListTestComponent } from './list-test/list-test.component';



@NgModule({
  declarations: [TestTechniqueComponent, QuestionTestComponent, CategorieSelectorComponent, ListTestComponent],
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
export class SelectionModule { }
