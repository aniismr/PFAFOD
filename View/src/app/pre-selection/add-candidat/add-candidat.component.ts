import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Candidat } from 'src/app/model/candidat';
import { DbOperationsService } from 'src/app/db-operations.service';

@Component({
  selector: 'app-add-candidat',
  templateUrl: './add-candidat.component.html',
  styleUrls: ['./add-candidat.component.scss']
})
export class AddCandidatComponent implements OnInit {
  candidat:Candidat;
  addCandidat=new FormGroup({
    candidatNom: new FormControl(),
    candidatPrenom : new FormControl(),
    email : new FormControl(),
    experience : new FormControl(),
    photo : new FormControl(),
    dateDeNaissance:new FormControl()
  });
  constructor(private dbOps:DbOperationsService) { }

  ngOnInit(): void {
  }
  public uploadFile = (files) => {
    if (files.length === 0) {
      return;
    }
 
    let fileToUpload = <File>files[0];
    const formData = new FormData();
    formData.append('file', fileToUpload, fileToUpload.name);
    this.dbOps.addCandidatPhoto(formData).subscribe((event:any)=>{this.candidat.photo=event.fname,this.dbOps.addCandidat(this.candidat).subscribe()});
  }
  register(files){
    this.candidat=this.addCandidat.value;
    this.uploadFile(files);
  
  }
}
