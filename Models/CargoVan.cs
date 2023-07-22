using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamPreparation01.Models
{
    public class CargoVan : Vehicle
    {
        const double maxMilеageCargoVan = 180;
        public CargoVan(string brand, string model, string licensePlateNumber) 
            : base(brand, model, maxMilеageCargoVan, licensePlateNumber)
        {
        }
    }
}
