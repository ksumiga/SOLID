using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Krešimir_Šumiga
{
    internal class LargeTrain :Train
    {
        public int MaxCapacity { get; set; }
        public double TicketPrice { get; set; }

        private LargeTrain(int maxCapacity, double ticketPrice) : base(6)
        {
            MaxCapacity = maxCapacity;
            TicketPrice = ticketPrice;
        }
    }
}
