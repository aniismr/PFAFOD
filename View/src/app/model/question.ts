import { Categorie } from './categorie';

export interface Question{
    questionID:number;
    ennonce:string;
    rep1:string;
    rep2:string;
    rep3:string;
    repTrue:string;
    categorieID:number;
    categorie:Categorie;
}