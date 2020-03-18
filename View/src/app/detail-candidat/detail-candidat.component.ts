import { Component, OnInit } from '@angular/core';
import{ ActivatedRoute } from "@angular/router";
import {Router } from   '@angular/router';
import  {DbOperationsService} from '../db-operations.service';
import { Candidat} from '../model/candidat';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';

import { delay, ignoreElements } from 'rxjs/operators';
import { Candidature } from '../model/candidature';
import { Competence } from '../model/Competence';
import { PopupModalComponent } from '../popup-modal/popup-modal.component';
import {MatSnackBar} from '@angular/material/snack-bar';

export interface Dialog {
  modifier: boolean;

}
@Component({
  selector: 'app-detail-candidat',
  templateUrl: './detail-candidat.component.html',
  styleUrls: ['./detail-candidat.component.scss']
})
export class DetailCandidatComponent implements OnInit {
  listId;
  candidature : Candidature;
  loaded:boolean=false;

  
  successMsg = false;

  constructor(private route:ActivatedRoute, private dbOps:DbOperationsService,public dialog: MatDialog,private _snackBar: MatSnackBar,private router: Router) {
   
   }
   modifier:boolean=false;
   openDialog(editCandidat): void {
     this.modifier=false;
    const dialogRef = this.dialog.open(PopupModalComponent, {
      width: '250px',
      data: {modifier: this.modifier}
    });
    
    dialogRef.afterClosed().subscribe(result => {
      console.log(result),
      this.modifier = result,
      this.modifier? this.editListing(editCandidat):console.log("failed");

    });

  }

  openSnackBar() {
    this._snackBar.open("Modifier avec succès", "OK", {
      duration: 2000,

    });
  }
  ngOnInit() {
  this.listId = this.route.snapshot.paramMap.get("id");
  console.log(this.loaded);

  this.dbOps.viewCandidature(this.listId).subscribe((candidat : any )=> {this.candidature=new Candidature(candidat.id,candidat.datepostulation,candidat.type,candidat.candidat[0],candidat.cv,candidat.status),candidat.competence.forEach(element => {
    this.candidature.competences.push(new Competence(element.id,element.libele))
  }),this.candidature.candidat.experience=candidat.candidat[0].experience,this.candidature.candidat.date_de_naissance=candidat.candidat[0].date_de_naissance,this.loaded=true,console.log(this.candidature.competences[0].label),console.log(this.candidature.candidat.date_de_naissance)});
 

  }
submit(){
 console.log(this.candidature.candidat.nom);  }

  editListing(updatedList){

    let cmpts=[];
    let compt=this.candidature.competences;
    if(updatedList.value.competences[0]!='c'){
      compt=updatedList.value.competences;
    }
    console.log(updatedList.value.competences[0]=="c");

    compt.forEach(element => {
      cmpts.push({"id":element.id,
        "libele": element.label});
    });
    let candidat=
      {
        "id": this.candidature.candidat.id,
        "photo": this.candidature.candidat.photo,
        "nom": updatedList.value.nom,
        "prenom": updatedList.value.prenom,
        "email": updatedList.value.email,
        "experience": updatedList.value.experience,
        "date_de_naissance": updatedList.value.datenaissance
      };
    let body={
      "id":this.candidature.id,
      "datepostulation": this.candidature.datepostulation,
      "type": this.candidature.type,
      "candidat": [candidat],
      "competence": cmpts,
      "cv": this.candidature.cv,
      "status":updatedList.value.status,
    };

    
    console.log(body);
    console.log(candidat);
    console.log(cmpts);

  cmpts.forEach(competence => this.dbOps.editCompetences(competence.id,competence).subscribe());
  this.dbOps.editCandidat(this.candidature.candidat.id,candidat).subscribe();
  this.dbOps.editCandidature(this.listId, body).subscribe((result:any)=>{this.openSnackBar(),this.router.navigateByUrl("/")});
  }

}
