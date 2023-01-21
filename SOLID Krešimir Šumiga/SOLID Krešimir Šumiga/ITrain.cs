using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Krešimir_Šumiga
{
    internal interface ITrain
    {
        int Capacity { get; }
        List<Vehicle> Vehicles { get; }
        double TicketIncome { get; }
        List<VehicleType> AllowedVehicleTypes { get; }

        void AddVehicle(Vehicle vehicle);
        void RemoveVehicle(Vehicle vehicle);
        double GetTicketIncome();
    }
}
