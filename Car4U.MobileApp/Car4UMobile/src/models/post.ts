import { CarImage } from "./car-image";

export class Post
{
    carType: string;
    city: string;
    createdDate: Date;
    drivenDistance: number;
    id: string;
    images: CarImage[];
    isImported: boolean;
    isUsed:boolean;
    manufacturedYear: number;
    phone: string;
    price: number;
    title:string;
    transmission: string;

}