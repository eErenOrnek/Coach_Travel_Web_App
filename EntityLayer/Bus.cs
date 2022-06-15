using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Bus
    {
        public int BusId { get; set; }
        public string BusBrand { get; set; }
        public string BusModel { get; set; }
        public string BusCapacity { get; set; }
        public string HirePrice { get; set; }
        public string ImageUrl { get; set; }
    }
}
