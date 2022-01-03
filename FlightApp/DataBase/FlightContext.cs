using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flight.Models;
using Microsoft.EntityFrameworkCore;

namespace Flight.DataBase
{
    public class FlightContext : DbContext
    {
        public FlightContext(DbContextOptions<FlightContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        public DbSet<FlightEntity> Flights { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlightEntity>().HasData(
                new FlightEntity
                {
                    FlightId = 1,
                    FlightDate = DateTime.ParseExact("2009-05-08 14:40:52", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture),
                    FlightDuration = 7.7f,
                    Departure = "Chisinau",
                    Destination = "Tokyo"
                },
                new FlightEntity
                {
                    FlightId = 2,
                    FlightDate = DateTime.ParseExact("2019-12-12 17:55:14", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture),
                    FlightDuration = 2.2f,
                    Departure = "Washington",
                    Destination = "New York"
                },
                new FlightEntity
                {
                    FlightId = 3,
                    FlightDate = DateTime.ParseExact("2021-01-07 05:06:07", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture),
                    FlightDuration = 3.0f,
                    Departure = "Moscow",
                    Destination = "Bucharest"
                }
            );
        }
    }
}
