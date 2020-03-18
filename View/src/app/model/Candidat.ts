import {Candidature} from "../model/candidature";


export class Candidat {
    id: number;
    nom:string;
    prenom:string;
    email:string;
    cv:string;
    experience:number;
    date_de_naissance:string;
    photo:string;
    constructor(id:number,nom:string,prenom:string,email:string){
        this.nom=nom;
        this.id=id;
        this.prenom=prenom;
        this.email=email;
        
    }

    }