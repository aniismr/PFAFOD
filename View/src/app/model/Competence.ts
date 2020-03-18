export class Competence{
    private _label:string;
    private _id:number;
    set label(value:string){
        this._label=value;
    }
    get label(){
        return this._label;
    }
    get id(){
        return this._id;
    }
    constructor(id:number,label:string){
        this._id=id;
        this._label=label;
    }
} 