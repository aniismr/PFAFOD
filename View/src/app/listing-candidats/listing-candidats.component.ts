import { Component, OnInit ,ViewChild} from '@angular/core';
import  {DbOperationsService} from '../db-operations.service';
import { Candidat} from '../model/candidat';
import  {Observable} from 'rxjs';
import { Candidature } from '../model/candidature';
import {MatPaginator} from '@angular/material/paginator';
import {MatTableDataSource} from '@angular/material/table'
import { MatSort } from '@angular/material/sort';


@Component({
  selector: 'app-listing-condidats',
  templateUrl: './listing-candidats.component.html',
  styleUrls: ['./listing-candidats.component.scss']
})
export class ListingCondidatsComponent implements OnInit {
  displayedColumns: string[] = ['id', 'nom', 'prenom', 'email',"type","datepostulation","status","detail"];
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
    this.dbOps.getCandidatures().subscribe((data:any) =>{ data.forEach(candidature => {
      this.listArr.push(new Candidature(candidature.id,candidature.datepostulation,candidature.type,candidature.candidat[0],candidature.cv,candidature.status)),console.log(candidature.candidat[0].id)
    }),this.loaded=true}); 
    this.dbOps.getCandidatures().subscribe((data:any)=>{this.ELEMENT_DATA=data, this.dataSource = new MatTableDataSource<Candidature>(this.ELEMENT_DATA),this.dataSource.paginator = this.paginator, this.dataSource.sort = this.sort;});
   


}
showListing(listing){
  this.isViewPage = true;
  this.dbOps.viewCandidature(listing.id).subscribe((data:any) => {this.viewList = (data),console.log(data)} );

}
}
    