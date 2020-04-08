import { Component, OnInit, Input } from '@angular/core';
import { Test } from 'src/app/model/test';
import { DbSelectionService } from '../db-selection.service';
import { Categorie } from 'src/app/model/categorie';
import { FormGroup, FormControl } from '@angular/forms';
import { TestCategorie } from 'src/app/model/test-categorie';

@Component({
  selector: 'app-question-test',
  templateUrl: './question-test.component.html',
  styleUrls: ['./question-test.component.scss']
})
export class QuestionTestComponent implements OnInit {
  @Input() test:Test;
  categories:Categorie[];
  tstcat=new Array<TestCategorie>();
  addTest=new FormGroup({
  testCategorie:new FormControl()
  })
  constructor(private dbOps:  DbSelectionService) { }

  ngOnInit(): void {
    this.dbOps.getCategories().subscribe((data:any)=>{this.categories=data})
  }
  register(){
    this.dbOps.randomCandidature(this.test.type,this.test.nbCandidature).subscribe((data:any)=>{this.test.testCandidature=data,    this.test.testCategorie=this.tstcat,
      this.dbOps.addTest(this.test).subscribe(),
      console.log(this.test);})

  }
  arrayOne(n: number): any[] {
    return Array(n);
  }
  receiveMessage($event){
    
    this.tstcat.push($event);
    console.log(this.tstcat);

  }

}
