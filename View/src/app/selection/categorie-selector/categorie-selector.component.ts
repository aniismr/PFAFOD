import { Component,EventEmitter , OnInit, Output } from '@angular/core';
import { Categorie } from 'src/app/model/categorie';
import { DbSelectionService } from '../db-selection.service';
import { FormControl, FormGroup } from '@angular/forms';

import { TestCategorie } from 'src/app/model/test-categorie';

@Component({
  selector: 'app-categorie-selector',
  templateUrl: './categorie-selector.component.html',
  styleUrls: ['./categorie-selector.component.scss']
})

export class CategorieSelectorComponent implements OnInit {
  categories:Categorie[];
  testCategorie:TestCategorie;
  @Output() messageEvent = new EventEmitter<TestCategorie>();
  constructor(private dbOps:  DbSelectionService) { }
  addCategorie=new FormGroup({
    categorieID:new FormControl(),
    nbQuestion:new FormControl()
  })
  ngOnInit(): void {
    
    this.dbOps.getCategories().subscribe((data:any)=>{this.categories=data})

  }
  register(){
    this.testCategorie=this.addCategorie.value;
    this.messageEvent.emit(this.testCategorie);
  }

  
}
