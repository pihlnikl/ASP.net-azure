using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinBookingApp
{
    public class Reservation
    {
        public int id { get; set; }
        public string cabinId { get; set; }
        public string services { get; set; }
        public string dates { get; set; }
    }
}