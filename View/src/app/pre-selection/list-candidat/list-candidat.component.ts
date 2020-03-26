import { Component, OnInit, ViewChild } from '@angular/core';
import { Candidat } from 'src/app/model/candidat';
import { DbOperationsService } from 'src/app/db-operations.service';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'app-list-candidat',
  templateUrl: './list-candidat.component.html',
  styleUrls: ['./list-candidat.component.scss']
})
export class ListCandidatComponent implements OnInit {
  displayedColumns: string[] = ['id', 'photo','nom', 'prenom', 'email','detail'];
  ELEMENT_DATA: Candidat[] ;
  dataSource;
  loaded:boolean=false;
  constructor(private dbOps: DbOperationsService) { }
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  @ViewChild(MatSort, {static: true}) sort: MatSort;
  ngOnInit(): void {
    this.dbOps.getCandidats().subscribe((data:any)=>{this.ELEMENT_DATA=data, this.dataSource = new MatTableDataSource<Candidat>(this.ELEMENT_DATA),this.dataSource.paginator = this.paginator, this.dataSource.sort = this.sort,console.log(this.ELEMENT_DATA),this.loaded=true});

  }
  photoPath(serverPath: string){
    return this.dbOps.createImgPath(serverPath);
  }
}
