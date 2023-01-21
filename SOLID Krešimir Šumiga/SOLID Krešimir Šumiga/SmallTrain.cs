using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Krešimir_Šumiga
{
    class SmallTrain : Train
    {
        public int MaxCapacity { get; set; }
        public double TicketPrice { get; set; }

        private SmallTrain(int maxCapacity, double ticketPrice) : base(8)
        {
            MaxCapacity = maxCapacity;
            TicketPrice = ticketPrice;
        }
    }
}
