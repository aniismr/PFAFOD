import {Candidat} from "../model/Candidat";
import {Competence} from "../model/Competence";
export class Candidature{
    private _id:number;
    private _candidat:Candidat;
    private _datepostulation:string;
    private _type:string;
    private _competences:Array<Competence>;
    private _cv:string;
    private _status:string;
    constructor(id:number,datepostulation:string,type:string,candidat:any,cv:string,status:string){
        this._id=id;
        this._candidat=candidat;
        this._datepostulation=datepostulation;
        this._type=type;
        this._cv=cv;
        this.candidat=new Candidat(candidat.id,candidat.nom,candidat.prenom,candidat.email);
        this.candidat.photo=candidat.photo;
        this._competences=new Array<Competence>();
        this._status=status;
    }
    get cv(){
        return this._cv;
    
    }
    get status(){
        return this._status;
    }
    set static(value){
        this._status=value;
    }
    set cv(value){
        this._cv=value;
    }
    get candidat(){
        return this._candidat;
    }
    get datepostulation(){
        return this._datepostulation;
    }
    get competences(){
        return this._competences;
    }
    get type(){
        return this._type;
    }
    get id(){
        return this._id;
    }
    set id(value){
        this._id=value;
    }
    set candidat(value){
        this._candidat=value;
    }
    set type(value){
        this._type=value;
    }
    set datepostulation(value){
        this._datepostulation=value;
    }
    set competences(value){
        this._competences=value;
    }
}