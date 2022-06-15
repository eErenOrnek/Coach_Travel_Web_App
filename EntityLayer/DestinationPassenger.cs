using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class DestinationPassenger
    {
        public int DestinationId { get; set; }
        public Destination Destination { get; set; }
        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; }
    }
}
