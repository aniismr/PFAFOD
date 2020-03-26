import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { User } from '../model/user';
import { DbOperationsService } from '../db-operations.service';
import { AuthenticationService } from '../authentication.service';

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.scss']
})
export class AddUserComponent implements OnInit {

  constructor(private dbOps:AuthenticationService) { }
  user:User;
  addUser=new FormGroup({
    nom:new FormControl(),
    prenom:new FormControl(),
    email:new FormControl(),
    password:new FormControl(),
    role:new FormControl()
  })
  ngOnInit(): void {
  }
  register(){
    this.user=this.addUser.value;
    this.dbOps.addUser(this.user).subscribe();  }
}
