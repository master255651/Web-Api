﻿// <auto-generated />
using System;
using Flight.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FlightApp.Migrations
{
    [DbContext(typeof(FlightContext))]
    partial class FlightContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Flight.Models.FlightEntity", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Departure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FlightDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("FlightDuration")
                        .HasColumnType("real");

                    b.HasKey("FlightId");

                    b.ToTable("Flights");

                    b.HasData(
                        new
                        {
                            FlightId = 1,
                            Departure = "Chisinau",
                            Destination = "Tokyo",
                            FlightDate = new DateTime(2009, 5, 8, 14, 40, 52, 0, DateTimeKind.Unspecified),
                            FlightDuration = 7.7f
                        },
                        new
                        {
                            FlightId = 2,
                            Departure = "Washington",
                            Destination = "New York",
                            FlightDate = new DateTime(2019, 12, 12, 17, 55, 14, 0, DateTimeKind.Unspecified),
                            FlightDuration = 2.2f
                        },
                        new
                        {
                            FlightId = 3,
                            Departure = "Moscow",
                            Destination = "Bucharest",
                            FlightDate = new DateTime(2021, 1, 7, 5, 6, 7, 0, DateTimeKind.Unspecified),
                            FlightDuration = 3f
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
