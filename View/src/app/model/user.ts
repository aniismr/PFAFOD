export interface User {
    userId: number;
    email: string;
    password: string;
    nom: string;
    prenom: string;
    token?: string;
    role:string;
}
