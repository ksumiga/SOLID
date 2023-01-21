using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Krešimir_Šumiga
{
    internal class Vehicle
    {
        public int Id { get; set; }
        public int GasLevel { get; set; }
        public int BatteryLevel { get; set; }
        public VehicleType VehicleType { get; }

        double TicketPrice { get; }

        private Vehicle(double gasLevel, double batteryLevel, VehicleType type, double ticketPrice)
        {
            GasLevel = (int)gasLevel;
            BatteryLevel = (int)batteryLevel;
            VehicleType = type;
            TicketPrice = ticketPrice;
        }

    }
}
