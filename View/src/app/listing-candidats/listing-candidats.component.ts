import { Component, OnInit } from '@angular/core';
import  {DbOperationsService} from '../db-operations.service';
import { Condidats} from '../model/condidats';
import  {Observable} from 'rxjs';
@Component({
  selector: 'app-listing-condidats',
  templateUrl: './listing-candidats.component.html',
  styleUrls: ['./listing-candidats.component.scss']
})
export class ListingCondidatsComponent implements OnInit {
  listArr: Observable<any[]>;
  viewList:Observable<Condidats>;
  isViewPage: boolean = false;
  constructor(private dbOps: DbOperationsService) { }

  ngOnInit() {
    this.dbOps.getListings().subscribe((data:any) => {this.listArr = (data)});

}
showListing(listing){
  this.isViewPage = true;
  this.dbOps.viewListing(listing.id).subscribe((data:any) => {this.viewList = (data)});

}
}
