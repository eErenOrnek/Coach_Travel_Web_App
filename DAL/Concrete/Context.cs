using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class Context: DbContext
    {
        public DbSet<CityFrom> CityFroms { get; set; }
        public DbSet<CityTo> CityTos { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Bus> Busses { get; set; }
        public DbSet<DestinationPassenger> DestinationPassengers { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<CardTicket> CardTickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server = DESKTOP-H3CVTRP\\MSSQLSERVER01; Database = TransitExpressDb; Integrated Security = true;");
            optionsBuilder.UseSqlite("Filename=TransitExpressSqlite.db");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DestinationPassenger>()
                .HasKey(dst => new { dst.DestinationId, dst.PassengerId });
        }
    }
}