import { Component, OnInit, ViewChild } from '@angular/core';
import { Test } from 'src/app/model/test';
import { DbSelectionService } from '../db-selection.service';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'app-list-test',
  templateUrl: './list-test.component.html',
  styleUrls: ['./list-test.component.scss']
})
export class ListTestComponent implements OnInit {
  displayedColumns: string[] = ['id', 'Date', 'Heure', 'NbCandidature',"Demande","Detail"];
  ELEMENT_DATA: Test[] ;
  dataSource;
  constructor(private dbOps:DbSelectionService) { }
  loaded:boolean=false;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  @ViewChild(MatSort, {static: true}) sort: MatSort;
  ngOnInit(): void {
    this.dbOps.getTests().subscribe((data:any)=>{this.ELEMENT_DATA=data, this.dataSource = new MatTableDataSource<Test>(this.ELEMENT_DATA),this.dataSource.paginator = this.paginator, this.dataSource.sort = this.sort,console.log(this.ELEMENT_DATA),this.loaded=true});
  }

}
