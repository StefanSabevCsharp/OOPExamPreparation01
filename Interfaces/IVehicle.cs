using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OOPExamPreparation01.Interfaces
{
    public interface IVehicle
    {
        string Brand { get; }
        string Model { get; }
        double MaxMilеage { get; }
        string LicensePlateNumber { get; }
        int BatteryLevel { get; }
        bool IsDamaged { get; }
    }
}
