export class CarImage
{
    car:string;
    height: number;
    width:number;
    id:string;
    type:number;
    uri:string;
    constructor(public src: string, public isAvatar: boolean)
    {

    }
}