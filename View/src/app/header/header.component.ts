import { Component, OnInit } from '@angular/core';
import { User } from '../model/user';
import { AuthenticationService } from '../authentication.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  constructor(private authenticationService: AuthenticationService,
    private router: Router
    ) { 
    
  }
  isAdmin=false;
  currentUser:User;
  ngOnInit(): void {
    this.authenticationService.currentUser.subscribe(x => {this.currentUser = x,this.currentUser.role==="Admin"?this.isAdmin=true:""});
  }

}
