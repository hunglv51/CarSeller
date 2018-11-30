import { Car } from "./car";

export class Post
{
    userName: string;
    userId: string;
    title: string ;
    content: string ;
    expiredDate: Date;
    createdDate: Date;
    car: Car;
    notifications: Notification[];
    carFamily :string;
    modifiedDate: Date;
    category: string;
    id:string;
    carType:number;
    transmission: number;
    isImported: boolean;
    isUsed :boolean;
    driveType: string;
    
}