using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Krešimir_Šumiga
{
    class Train : ITrain
    {
        public int Capacity { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public double TicketIncome { get; set; }

        public List<VehicleType> AllowedVehicleTypes { get; private set; }

        public Train(int capacity)
        {
            Capacity = capacity;
            Vehicles = new List<Vehicle>();
            AllowedVehicleTypes = new List<VehicleType>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public double GetTicketIncome()
        {
            throw new NotImplementedException();
        }
    }
}
