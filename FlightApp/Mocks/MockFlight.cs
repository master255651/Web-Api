using Flight.DataBase;
using Flight.Models;
using FlightApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Mocks
{
    public class MockFlight : IFlight
    {
        readonly FlightContext _flightContext;

        public MockFlight(FlightContext context)
        {
            _flightContext = context;
        }

        public IEnumerable<FlightEntity> GetFlights
        {
            get
            {
                return _flightContext.Flights.ToList();
            }
        }

        public FlightEntity Get(int id)
        {
            return _flightContext.Flights.FirstOrDefault(f => f.FlightId == id);
        }

        public void Add(FlightEntity entity)
        {
            _flightContext.Flights.Add(entity);
            _flightContext.SaveChanges();
        }
        public void Update(FlightEntity flight, FlightEntity entity)
        {
            flight.FlightDuration = entity.FlightDuration;
            flight.FlightDate = entity.FlightDate;
            flight.Departure = entity.Departure;
            flight.Destination = entity.Destination;
            _flightContext.SaveChanges();
        }
        public void Delete(FlightEntity flight)
        {
            _flightContext.Flights.Remove(flight);
            _flightContext.SaveChanges();
        }
    }
}
