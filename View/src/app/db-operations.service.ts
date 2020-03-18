import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
@Injectable({
providedIn: 'root'
})
export class DbOperationsService {
constructor(private http: HttpClient) { }
getCandidatures(){
    
return this.http.get('http://localhost:5000/api/candidatures');
}
viewCandidature(id:number){
return this.http.get('http://localhost:5000/api/candidatures/'+id);
}

editCandidature(id:number, newList:any){
 
let headers = new HttpHeaders({ 'Content-Type': 'application/json' });
return this.http.put('http://localhost:5000/api/candidatures/'+id, newList,{headers});
}
editCandidat(id:number, newList:any){
 
    let headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    return this.http.put('http://localhost:5000/api/candidats/'+id, newList,{headers});
    }
editCompetences(id:number, newList:any){

    let headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    return this.http.put('http://localhost:5000/api/competences/'+id, newList,{headers});
    }
   
}