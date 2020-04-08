import { Component, OnInit } from '@angular/core';
import { Candidat } from 'src/app/model/candidat';
import { DbOperationsService } from 'src/app/db-operations.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Competence } from 'src/app/model/competence';
import { Candidature } from 'src/app/model/candidature';

@Component({
  selector: 'app-add-candidature',
  templateUrl: './add-candidature.component.html',
  styleUrls: ['./add-candidature.component.scss']
})
export class AddCandidatureComponent implements OnInit {
  candidature:Candidature;
  loaded=false;
  candidats: Candidat[] ;
  competences:Competence[];
  addCandidature =new FormGroup({
    datePostulation:new FormControl(new Date().toLocaleDateString),
    type:new FormControl(),
    candidatId:new FormControl(),
    competenceCandidature : new FormControl(),
    reponse:new FormControl(),
    cv:new FormControl()
  })
  constructor(private dbOps: DbOperationsService) { }

  ngOnInit(): void {
this.dbOps.getCandidats().subscribe((data:any)=>{this.candidats=data,this.dbOps.getCompetences().subscribe((data:any)=>{this.competences=data,this.loaded=true})})
  }
  public uploadFile = (files) => {
    if (files.length === 0) {
      return;
    }
 
    let fileToUpload = <File>files[0];
    const formData = new FormData();
    formData.append('file', fileToUpload, fileToUpload.name);
    this.dbOps.addCV(formData).subscribe((event:any)=>{this.candidature.cv=event.fname,this.dbOps.addCandidature(this.candidature).subscribe()});
  }
  register(files){
    this.candidature=this.addCandidature.value
    console.log(this.candidature);
    this.uploadFile(files); 
  }

}
