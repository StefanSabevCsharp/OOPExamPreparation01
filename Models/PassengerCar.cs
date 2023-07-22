using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamPreparation01.Models
{
    public class PassengerCar : Vehicle
    {
        const double maxMilеagePassengerCar = 450;
        public PassengerCar(string brand, string model, string licensePlateNumber) 
            : base(brand, model, maxMilеagePassengerCar, licensePlateNumber)
        {
        }
    }
}
