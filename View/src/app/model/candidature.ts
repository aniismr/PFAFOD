import { Candidat } from './candidat';
import { CompetenceCandidature } from './competence-candidature';

export interface Candidature {
    candidatureID:number;
    datePostulation:string;
    type:string;
    candidatID:number;
    candidat:Candidat;
    competenceCandidature:CompetenceCandidature[];
    reponse:string;
    cv:string;
}
