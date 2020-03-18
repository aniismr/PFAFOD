import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap' ;  
import { FlexLayoutModule } from '@angular/flex-layout'; 
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';

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

import { IdentificationModule } from './identification/identification.module';


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
  ],
  imports: [
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    FlexLayoutModule,
    NgbModule,

    BrowserModule,
    AppRoutingModule,
    IdentificationModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
