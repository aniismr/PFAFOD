import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
const url='http://localhost:5000';
@Injectable({
  providedIn: 'root'
})
export class DbSelectionService {

  constructor(private http: HttpClient) { }
  getCategories(){
    return this.http.get(url+'/Categorie');
}
addTest(body:any){
 return this.http.post(url+'/Test',body);
}
randomCandidature(type:string,number:number){
  return this.http.get(url+'/Candidature/'+type+'/'+number);
}
getTests(){
  return this.http.get(url+'/Test');
}
}
