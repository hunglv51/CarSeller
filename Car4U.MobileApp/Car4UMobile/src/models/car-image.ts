export class CarImage
{
    car:string;
    height: number;
    width:number;
    id:string;
    uri:string;

    constructor(public src: string, public isAvatar: boolean)
    {

    }
}