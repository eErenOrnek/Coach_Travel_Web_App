// <auto-generated />
using System;
using DAL.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("EntityLayer.Bus", b =>
                {
                    b.Property<int>("BusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BusBrand")
                        .HasColumnType("TEXT");

                    b.Property<string>("BusCapacity")
                        .HasColumnType("TEXT");

                    b.Property<string>("BusModel")
                        .HasColumnType("TEXT");

                    b.Property<string>("HirePrice")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("BusId");

                    b.ToTable("Busses");
                });

            modelBuilder.Entity("EntityLayer.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("EntityLayer.CardTicket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DestinationId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("DestinationId");

                    b.ToTable("CardTickets");
                });

            modelBuilder.Entity("EntityLayer.CityFrom", b =>
                {
                    b.Property<int>("CityFromId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("CityFromId");

                    b.ToTable("CityFroms");
                });

            modelBuilder.Entity("EntityLayer.CityTo", b =>
                {
                    b.Property<int>("CityToId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("CityToId");

                    b.ToTable("CityTos");
                });

            modelBuilder.Entity("EntityLayer.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CityFromId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CityToId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("PassengerNumber")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("DestinationId");

                    b.HasIndex("CityFromId");

                    b.HasIndex("CityToId");

                    b.ToTable("Destinations");
                });

            modelBuilder.Entity("EntityLayer.DestinationPassenger", b =>
                {
                    b.Property<int>("DestinationId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PassengerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DestinationId", "PassengerId");

                    b.HasIndex("PassengerId");

                    b.ToTable("DestinationPassengers");
                });

            modelBuilder.Entity("EntityLayer.Passenger", b =>
                {
                    b.Property<int>("PassengerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .HasColumnType("TEXT");

                    b.HasKey("PassengerId");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("EntityLayer.CardTicket", b =>
                {
                    b.HasOne("EntityLayer.Card", "Card")
                        .WithMany("CardTickets")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Destination", "Destination")
                        .WithMany()
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("Destination");
                });

            modelBuilder.Entity("EntityLayer.Destination", b =>
                {
                    b.HasOne("EntityLayer.CityFrom", "CityFrom")
                        .WithMany("Destinations")
                        .HasForeignKey("CityFromId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.CityTo", "CityTo")
                        .WithMany("Destinations")
                        .HasForeignKey("CityToId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CityFrom");

                    b.Navigation("CityTo");
                });

            modelBuilder.Entity("EntityLayer.DestinationPassenger", b =>
                {
                    b.HasOne("EntityLayer.Destination", "Destination")
                        .WithMany("DestinationPassengers")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Passenger", "Passenger")
                        .WithMany("DestinationPassengers")
                        .HasForeignKey("PassengerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Destination");

                    b.Navigation("Passenger");
                });

            modelBuilder.Entity("EntityLayer.Card", b =>
                {
                    b.Navigation("CardTickets");
                });

            modelBuilder.Entity("EntityLayer.CityFrom", b =>
                {
                    b.Navigation("Destinations");
                });

            modelBuilder.Entity("EntityLayer.CityTo", b =>
                {
                    b.Navigation("Destinations");
                });

            modelBuilder.Entity("EntityLayer.Destination", b =>
                {
                    b.Navigation("DestinationPassengers");
                });

            modelBuilder.Entity("EntityLayer.Passenger", b =>
                {
                    b.Navigation("DestinationPassengers");
                });
#pragma warning restore 612, 618
        }
    }
}
