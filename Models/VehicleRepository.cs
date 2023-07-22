using OOPExamPreparation01.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamPreparation01.Models
{
    public class VehicleRepository : IRepository<IVehicle>
    {
        private List<IVehicle> vehicles;

        public VehicleRepository()
        {
            vehicles = new List<IVehicle>();
        }

        public void AddModel(IVehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public IVehicle FindById(string identifier)
        {
            IVehicle vehicle = vehicles.FirstOrDefault(v => v.LicensePlateNumber == identifier);
            return vehicle;
        }

        public IReadOnlyCollection<IVehicle> GetAll()
        {
           return vehicles.AsReadOnly();
        }

        public bool RemoveById(string identifier)
        {
            IVehicle vehicle = vehicles.FirstOrDefault(v => v.LicensePlateNumber == identifier);
            if (vehicle == null)
            {
                return false;
            }
            vehicles.Remove(vehicle);
            return true;
        }
    }
}
