using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer
{
    public class Passenger
    {
        //public Passenger()
        //{
        //    this.Destinations = new HashSet<Destination>();
        //}
        public int PassengerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<DestinationPassenger> DestinationPassengers { get; set; }
    }
}
