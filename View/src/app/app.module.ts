import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap' ;  
import { FlexLayoutModule } from '@angular/flex-layout'; 
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import {MatTableModule} from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import {MatSortModule} from '@angular/material/sort';
import {MatDialogModule} from '@angular/material/dialog';
import {MatSnackBarModule} from '@angular/material/snack-bar';

import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import {FormsModule} from '@angular/forms';
import {ReactiveFormsModule} from '@angular/forms';

import { ListingCondidatsComponent } from './listing-candidats/listing-candidats.component';

import { HttpClientModule } from '@angular/common/http';
import { FooterComponent } from './footer/footer.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { LogoutComponent } from './logout/logout.component';

import { DetailCandidatComponent } from './detail-candidat/detail-candidat.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { PopupModalComponent } from './popup-modal/popup-modal.component';
import { LoginPageModule } from './login-page/login-page.module';
import { AddUserComponent } from './add-user/add-user.component';





@NgModule({
  declarations: [
    LoginComponent,
    HeaderComponent,
    ListingCondidatsComponent,
    AppComponent,
    HeaderComponent,
    HomeComponent,
    ListingCondidatsComponent,
    FooterComponent,
    PageNotFoundComponent,
    LogoutComponent,
    DetailCandidatComponent,
    PopupModalComponent,
    AddUserComponent,


  ],
  imports: [
    LoginPageModule,
    MatSnackBarModule,
    MatDialogModule,
    MatSortModule,
    MatPaginatorModule,
    MatTableModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    FlexLayoutModule,
    NgbModule,
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
