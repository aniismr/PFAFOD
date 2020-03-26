import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { Candidature } from 'src/app/model/candidature';
import { Observable } from 'rxjs';
import { DbOperationsService } from 'src/app/db-operations.service';
import { Candidat } from 'src/app/model/candidat';
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'app-list-candidatures',
  templateUrl: './list-candidatures.component.html',
  styleUrls: ['./list-candidatures.component.scss']
})
export class ListCandidaturesComponent implements OnInit {

  displayedColumns: string[] = ['id', 'nom', 'prenom', 'email',"type","datepostulation","reponse","detail"];
  ELEMENT_DATA: Candidature[] ;
  dataSource;



  listArr: Array<Candidature>=new Array<Candidature>();
  viewList:Observable<Candidat[]>;
  isViewPage: boolean = false;
  constructor(private dbOps: DbOperationsService) { }
  loaded:boolean=false;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  @ViewChild(MatSort, {static: true}) sort: MatSort;
  ngOnInit() {


    this.dbOps.getCandidatures().subscribe((data:any)=>{this.ELEMENT_DATA=data, this.dataSource = new MatTableDataSource<Candidature>(this.ELEMENT_DATA),this.dataSource.paginator = this.paginator, this.dataSource.sort = this.sort,console.log(this.ELEMENT_DATA),this.loaded=true});
   


}
showListing(listing){
  this.isViewPage = true;
  this.dbOps.viewCandidature(listing.id).subscribe((data:any) => {this.viewList = (data),console.log(data)} );

}

}
