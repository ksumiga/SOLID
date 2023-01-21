using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Krešimir_Šumiga
{
    internal interface IShljaker
    {
        string Name { get; }
        double Salary { get; }
        double Income { get; }

        void Refuel(Vehicle vehicle);
        void RechargeBattery(Vehicle vehicle);
        void AddIncome(double income, VehicleType type, double ticketPrice);
    }
}
