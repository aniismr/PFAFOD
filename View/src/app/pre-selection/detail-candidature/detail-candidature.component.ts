import { Component, OnInit } from '@angular/core';
import { Candidature } from 'src/app/model/candidature';
import { ActivatedRoute, Router } from '@angular/router';
import { DbOperationsService } from 'src/app/db-operations.service';
import { MatDialog } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { PopupModalComponent } from '../popup-modal/popup-modal.component';
export interface Dialog {
  modifier: boolean;

}
@Component({
  selector: 'app-detail-candidature',
  templateUrl: './detail-candidature.component.html',
  styleUrls: ['./detail-candidature.component.scss']
})

export class DetailCandidatureComponent implements OnInit {
  listId;
  candidature : Candidature;
  loaded:boolean=false;
  modifier:boolean=false;
  
  successMsg = false;
  constructor(private route:ActivatedRoute, private dbOps:DbOperationsService,public dialog: MatDialog,private _snackBar: MatSnackBar,private router: Router  ) {
   
  }

  ngOnInit(): void {
    this.listId = this.route.snapshot.paramMap.get("id");
    this.dbOps.viewCandidature(this.listId).subscribe((data:any) =>{this.candidature=data,this.loaded=true,console.log(data)});
  }
  openDialog(editCandidat): void {
    this.modifier=false;
   const dialogRef = this.dialog.open(PopupModalComponent, {
     width: '250px',
     data: {modifier: this.modifier}
   });
   
   dialogRef.afterClosed().subscribe(result => {
     console.log(result),
     this.modifier = result;
     //this.modifier? this.editListing(editCandidat):console.log("failed");

   });

 }
 
}
