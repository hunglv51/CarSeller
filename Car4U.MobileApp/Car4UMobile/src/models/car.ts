import { CarImage } from "./car-image";

export class Car
{
    id:number;
    manufactureYear:number;
    price: number;
    drivenDistance :number
    size: string ;
    weight:number;
    cylinderCapacity:number;
    fuelCapacity:number;
    tireInfo :number;
    wheelBase :number;
    maxSeatingCapacity :number;
    numDoor :number;
    images: Array<CarImage>;
    carFamily: string ;
}