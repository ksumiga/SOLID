using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Krešimir_Šumiga
{
    internal class Terminal 
    {
        public List<Train> Trains { get; set; }
        public List<Shljaker> Shljakker { get; set; }
        public double TotalIncome { get; set; }

        public Terminal()
        {
            Trains = new List<Train>();
            Shljakker = new List<Shljaker>();
        }
    }
}
