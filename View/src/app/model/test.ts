import { TestCandidature } from './test-candidature';
import { TestCategorie } from './test-categorie';

export interface Test{
    testId:number;
    date:string;
    nbCandidature:number;
    heure:string;
    testCandidature:TestCandidature[];
    testCategorie:TestCategorie[];
    type:string;
    nbPartie:number;
}