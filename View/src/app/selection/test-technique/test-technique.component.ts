import { Component, OnInit } from '@angular/core';
import { Test } from 'src/app/model/test';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-test-technique',
  templateUrl: './test-technique.component.html',
  styleUrls: ['./test-technique.component.scss']
})
export class TestTechniqueComponent implements OnInit {

  constructor() { }
  test:Test;
  next=false;
  newTest=new FormGroup({
    date:new FormControl(),
    heure: new FormControl(),
    nbCandidature:new FormControl(),
    nbPartie:new FormControl(),
    type:new FormControl()
  })
  ngOnInit(): void {
  }
  register(){
    this.test=this.newTest.value;
    this.next=true;
  }

}
