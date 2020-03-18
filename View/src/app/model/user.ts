import { Role } from './Role';

export class User {
    _id:number;
    email:string;
    mdp:string;
    nom:string;
    prenom:string;
    photo:string;
    role:Role[];
}
