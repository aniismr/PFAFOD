import { Component, OnInit } from '@angular/core';
import { Candidat } from 'src/app/model/candidat';
import { FormGroup, FormControl } from '@angular/forms';
import { DbOperationsService } from 'src/app/db-operations.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-detail-candidat',
  templateUrl: './detail-candidat.component.html',
  styleUrls: ['./detail-candidat.component.scss']
})
export class DetailCandidatComponent implements OnInit {
  listId;
  candidat:Candidat;
  loaded=false;
  editCandidat=new FormGroup({
    candidatNom: new FormControl(),
    candidatPrenom : new FormControl(),
    email : new FormControl(),
    experience : new FormControl(),
    photo : new FormControl(),
    dateDeNaissance:new FormControl()
  });
  constructor(private dbOps:DbOperationsService,private route:ActivatedRoute) { }

  ngOnInit(): void {
    this.listId = this.route.snapshot.paramMap.get("id");
    this.dbOps.viewCandidat(this.listId).subscribe((data:Candidat)=>{
      this.candidat=data,
      this.editCandidat.patchValue(this.candidat),
      this.loaded=true});
  }
  photoPath(serverPath: string){
    return this.dbOps.createImgPath(serverPath);
  }
  edit(){

  }
}
