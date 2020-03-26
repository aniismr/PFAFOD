import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
const url='http://localhost:5000';
@Injectable({
providedIn: 'root'
})

export class DbOperationsService {

constructor(private http: HttpClient) { }
getCompetences(){
    return this.http.get(url+'/Competence');
}
getCandidatures(){
    
return this.http.get(url+'/Candidature');
}
getCandidats(){
    return this.http.get(url+'/Candidat')};
viewCandidature(id:number){
return this.http.get(url+'/Candidature/'+id);
}
viewCandidat(id:number){
    return this.http.get(url+'/Candidat/'+id);
}
editCandidature(id:number, newList:any){
 
let headers = new HttpHeaders({ 'Content-Type': 'application/json' });
return this.http.put('http://localhost:5000/Candidature/'+id, newList,{headers});
}
editCandidat(id:number, newList:any){
 
    let headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    return this.http.put('http://localhost:5000/Candidat/'+id, newList,{headers});
    }
editCompetences(id:number, newList:any){

    let headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    return this.http.put('http://localhost:5000/api/competences/'+id, newList,{headers});
    }
    addCandidat(body:any){
        console.log(body);
        return this.http.post('http://localhost:5000/Candidat',body);
    }
    addCandidatPhoto(body:any){
        return this.http.post('http://localhost:5000/Resources',body);
    }
    public createImgPath = (serverPath: string) => {
        return `https://localhost:5001/Resources/Images/${serverPath}`;
      }
   addCandidature(body:any){
    return this.http.post('http://localhost:5000/Candidature',body);

   }
   addCV(body:any){
    return this.http.post('http://localhost:5000/Resources/CV',body);
   }
}