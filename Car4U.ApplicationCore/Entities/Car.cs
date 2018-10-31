﻿using CarSeller.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Car4U.ApplicationCore.Entities
{
    public class Car : BaseEntity<long>
    {
        private Car()
        {

        }
        public Car(int manufacturedYear, double price, int drivenDistance, string size, int? weight, int? cylinderCapacity, int? fuelCapacity,
            int? tireInfo, int? wheelBase, int? maxSeatingCapacity, int? numDoor)
        {
            ManufactureYear = manufacturedYear;
            DrivenDistance = drivenDistance;
            Size = size;
            Weight = weight;
            CylinderCapacity = cylinderCapacity;
            FuelCapacity = fuelCapacity;
            TireInfo = tireInfo;
            WheelBase = wheelBase;
            MaxSeatingCapacity = maxSeatingCapacity;
            NumDoor = numDoor;
            
        }

        public Car(int manufacturedYear, double price, int drivenDistance)
        {
            ManufactureYear = manufacturedYear;
            Price = price;
            DrivenDistance = drivenDistance;
        }

        public int ManufactureYear { get; set; }

        [Range(0, 1000000)]
        public double Price { get; set; }
        public int DrivenDistance { get; set; }
        [StringLength(50)]
        public string Size { get; set; }
        public int? Weight { get; set; }
        public int? CylinderCapacity { get; set; }
        public int? FuelCapacity { get; set; }
        public int? TireInfo { get; set; }
        public int? WheelBase { get; set; }
        public int? MaxSeatingCapacity { get; set; }
        public int? NumDoor { get; set; }
        public ICollection<CarImage> Images { get; set; }
    }
}