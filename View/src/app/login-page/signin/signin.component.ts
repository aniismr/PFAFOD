import { Component, OnInit } from '@angular/core';
import {ToastrService} from 'ngx-toastr';
import { Title } from '@angular/platform-browser';
import { FormGroup, FormControl,FormBuilder, Validators } from '@angular/forms';
import { LogindbService } from '../logindb.service';
import { Router } from '@angular/router';

@Component({
  
  selector: 'app-signin',
  templateUrl: './signin.component.html',
  styleUrls: ['./signin.component.scss']
})
export class SigninComponent implements OnInit {

  form=new FormGroup({
    username: new FormControl('',Validators.required),
    password : new FormControl('',Validators.required)
  })
  
  constructor(private fb:FormBuilder,private title:Title, private authService : LogindbService,private router: Router) { }

  ngOnInit(): void {

    this.title.setTitle("Login page");
  }
  loginUser() {
    this.authService.login(this.form.value)
  }

  
  
}
