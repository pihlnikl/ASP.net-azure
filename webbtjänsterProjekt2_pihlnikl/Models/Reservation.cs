using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webbtjänsterProjekt2_pihlnikl.Models
{
    public class Reservation
    {
        public int id { get; set; }
        public string cabinId { get; set; }
        public string services { get; set; }
        public string dates { get; set; }
    }
}
