using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Krešimir_Šumiga
{
    internal class Shljaker :IShljaker
    {
            public string Name { get; set; }
            public double Salary { get; set; }
            public double Income { get; set; }

            private Shljaker(string name, double salary)
            {
                Name = name;
                Salary = salary;
            }

        public void Refuel(Vehicle vehicle)
        {
            if (vehicle.GasLevel.Equals(vehicle.GasLevel * 0.10)) {

                vehicle.GasLevel = vehicle.GasLevel * 100;
            }
        }

        public void RechargeBattery(Vehicle vehicle)
        {
            if (vehicle.BatteryLevel.Equals(vehicle.BatteryLevel * 0.10))
            {

                vehicle.BatteryLevel = vehicle.BatteryLevel * 100;
            }
        }

        public void AddIncome(double income , VehicleType type, double ticketPrice)
        {
            if (income == 0) {
                
                if(type == VehicleType.CAR || type == VehicleType.CAR)
                {
                    Salary= ticketPrice * 0.10;
                }
                else 
                {
                    Salary = ticketPrice * 0.20;    
                }
            }
        }
    }
}
