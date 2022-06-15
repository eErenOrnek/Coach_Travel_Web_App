using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer
{
    public class Destination
    {
        //public Destination()
        //{
        //    this.Passengers = new HashSet<Passenger>();
        //}
        public int DestinationId { get; set; }
        public int CityFromId { get; set; }
        public CityFrom CityFrom { get; set; }
        public int CityToId { get; set; }
        public CityTo CityTo { get; set; }
        //public DateTime Date { get; set; }
        public string Date { get; set; }
        public decimal? Price { get; set; }
        public int PassengerNumber { get; set; }
        public List<DestinationPassenger> DestinationPassengers { get; set; }
    }
}
