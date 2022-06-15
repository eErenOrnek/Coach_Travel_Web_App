using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class SeedDatabase
    {
        public static void Seed()
        {
            var context = new Context();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Busses.Count() == 0)
                {
                    context.Busses.AddRange(Busses);
                }
                if (context.CityFroms.Count() == 0)
                {
                    context.CityFroms.AddRange(CityFroms);
                }
                if (context.CityTos.Count() == 0)
                {
                    context.CityTos.AddRange(CityTos);
                }
                if (context.Passengers.Count() == 0)
                {
                    context.Passengers.AddRange(Passengers);
                }
                if (context.Destinations.Count() == 0)
                {
                    context.Destinations.AddRange(Destinations);
                }
                if (context.DestinationPassengers.Count() == 0)
                {
                    context.DestinationPassengers.AddRange(DestinationPassengers);
                }
                context.SaveChanges();
            }
        }

        private static Bus[] Busses =
        {
            new Bus() {BusBrand = "Mercedes-Benz Tourrider", BusModel = "2022", BusCapacity = "70", HirePrice = "£500", ImageUrl = "mercedes-benz-tourrider.jpg"},
            new Bus() {BusBrand = "Volvo 9900", BusModel = "2022", BusCapacity = "85", HirePrice = "£650", ImageUrl = "volvo-9900.webp"},
            new Bus() {BusBrand = "MAN Lion's Coach", BusModel = "2020", BusCapacity = "90", HirePrice = "£550", ImageUrl = "man-lions-coach.jpg"},
            new Bus() {BusBrand = "Neoplan Skyliner", BusModel = "2022", BusCapacity = "85", HirePrice = "£400", ImageUrl = "neoplan-skyliner.jpg"}
        };

        private static CityFrom[] CityFroms =
        {
            new CityFrom() {Name = "İstanbul"},
            new CityFrom() {Name = "Ankara"},
            new CityFrom() {Name = "İzmir"},
            new CityFrom() {Name = "Bursa"},
            new CityFrom() {Name = "Antalya"},
            new CityFrom() {Name = "Trabzon"},
            new CityFrom() {Name = "Rize"},
            new CityFrom() {Name = "Muğla"}
        };

        private static CityTo[] CityTos =
        {
            new CityTo() {Name = "İstanbul"},
            new CityTo() {Name = "Ankara"},
            new CityTo() {Name = "İzmir"},
            new CityTo() {Name = "Bursa"},
            new CityTo() {Name = "Antalya"},
            new CityTo() {Name = "Trabzon"},
            new CityTo() {Name = "Rize"},
            new CityTo() {Name = "Muğla"}
        };

        private static Destination[] Destinations =
        {
            new Destination() {CityFromId = 2, CityToId = 4, Date= ("2022-05-15 00:00:00"), PassengerNumber = 1, Price = 250},
            new Destination() {CityFromId = 2, CityToId = 5, Date = ("2022-05-16 15:00:00"), PassengerNumber = 1, Price = 170},
            new Destination() {CityFromId = 2, CityToId = 6, Date = ("2022-05-17 14:00:00") , PassengerNumber = 1, Price = 170},
            new Destination() {CityFromId = 3, CityToId = 4, Date = ("2022-05-16"), PassengerNumber = 1, Price = 200},
            new Destination() {CityFromId = 4, CityToId = 5, Date = ("2022-05-17 18:00:00"), PassengerNumber = 1, Price = 140},
            new Destination() {CityFromId = 6, CityToId = 8, Date = ("2022-05-18"), PassengerNumber = 1, Price = 280},
            new Destination() {CityFromId = 7, CityToId = 6, Date = ("2022-05-20 15:00:00"), PassengerNumber = 1, Price = 500},
            new Destination() {CityFromId = 1, CityToId = 2, Date = ("2022-05-13 20:00:00"), PassengerNumber = 1, Price = 150},
            new Destination() {CityFromId = 1, CityToId = 2, Date = ("2022-05-13 10:00:00"), PassengerNumber = 1, Price = 100},
            new Destination() {CityFromId = 1, CityToId = 3, Date = ("2022-05-13 09:00:00"), PassengerNumber = 1, Price = 200},
            new Destination() {CityFromId = 1, CityToId = 4, Date = ("2022-05-13 08:00:00"), PassengerNumber = 1, Price = 200},
            new Destination() {CityFromId = 1, CityToId = 5, Date = ("2022-05-14 21:00:00"), PassengerNumber = 1, Price = 40},
            new Destination() {CityFromId = 1, CityToId = 6, Date = ("2022-05-15 22:00:00"), PassengerNumber = 1, Price = 400},
            new Destination() {CityFromId = 2, CityToId = 1, Date = ("2022-05-13 23:00:00"), PassengerNumber = 1, Price = 500},
            new Destination() {CityFromId = 2, CityToId = 4, Date = ("2022-05-16 19:00:00"), PassengerNumber = 1, Price = 350},
        };

        private static Passenger[] Passengers =
        {
            new Passenger() {Name = "Eren", Surname = "Örnek", Email = "ornekeren@gmail.com", Phone = "05387451881"},
            new Passenger() {Name = "Eray", Surname = "Örnek", Email = "erayornek@gmail.com", Phone = "05352125545"},
            new Passenger() {Name = "Ceren", Surname = "Yılmaz", Email = "ceyilmz@gmail.com", Phone = "05376779812"},
            new Passenger() {Name = "Deren", Surname = "Çelik", Email = "celikderen@gmail.com", Phone = "05355321212"},
            new Passenger() {Name = "Kerem", Surname = "Tığ", Email = "ktig12@gmail.com", Phone = "05353531212"},
            new Passenger() {Name = "Aslı", Surname = "Kırcı", Email = "kircias@gmail.com", Phone = "05531231212"},
            new Passenger() {Name = "Berkay", Surname = "Kurtuluş", Email = "bkurtulus@gmail.com", Phone = "05351235645"},
            new Passenger() {Name = "Deran", Surname = "Aslan", Email = "daslan@gmail.com", Phone = "05456541281"},
        };

        private static DestinationPassenger[] DestinationPassengers =
{
            new DestinationPassenger() {Destination = Destinations[1], Passenger = Passengers[1]},
            new DestinationPassenger() {Destination = Destinations[1], Passenger = Passengers[2]},
            new DestinationPassenger() {Destination = Destinations[3], Passenger = Passengers[3]},
            new DestinationPassenger() {Destination = Destinations[2], Passenger = Passengers[4]},
            new DestinationPassenger() {Destination = Destinations[4], Passenger = Passengers[5]},
            new DestinationPassenger() {Destination = Destinations[2], Passenger = Passengers[6]},
        };
    }
}
