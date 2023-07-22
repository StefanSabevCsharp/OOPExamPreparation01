using OOPExamPreparation01.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPExamPreparation01.Models
{
    public abstract class Vehicle : IVehicle

    {
        const int MaxBatteryLevel = 100;

        string brand;
        string model;
        double maxmileage;
        string licenseplatenumber;
        int batterylevel;
        bool isdamaged;

        public Vehicle(string brand, string model, double maxMilеage, string licensePlateNumber)
        {
            Brand = brand;
            Model = model;
            MaxMilеage = maxMilеage;
            LicensePlateNumber = licensePlateNumber;
            BatteryLevel = MaxBatteryLevel;
            IsDamaged = false;
        }

        public string Brand
        {
            get => this.brand;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMesseges.VehicleExceptionMesseges.NullOrEmptyBrand);
                }
                this.brand = value;
            }
        }


        public string Model
        {
            get => this.model;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMesseges.VehicleExceptionMesseges.NullOrEmptyModel);
                }
                this.model = value;
            }
        }

        public double MaxMilеage { get; private set; }

        public string LicensePlateNumber
        {
            get => this.licenseplatenumber;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMesseges.VehicleExceptionMesseges.NullOrEmptyLicensePlateNumber);
                }
                this.licenseplatenumber = value;
            }
        }


        public int BatteryLevel { get; private set; }

        public bool IsDamaged { get; private set; }

        void Drive(double milage)
        {            double batteryLevelToReduce = milage / MaxMilеage * 100;            if (this is CargoVan)            {
                batteryLevelToReduce += 5;
            }            BatteryLevel -= (int)Math.Round(batteryLevelToReduce);
        }
        void Recharge()
        {
            BatteryLevel = MaxBatteryLevel;
        }
        void ChangeStatus()
        {
            if (isdamaged == false)
            {
                isdamaged = true;
            }
            else if (isdamaged == true)
            {
                isdamaged = false;
            }
        }
        public override string ToString()
        {
            string carStatus = "";
            if (isdamaged == false)
            {
                carStatus = "OK";
            }
            else if (isdamaged == true)
            {
                carStatus = "damaged";
            }
            return $"{Brand} {Model} License plate: {LicensePlateNumber} Battery: {BatteryLevel} Status: {carStatus}";
        }

    }
}
