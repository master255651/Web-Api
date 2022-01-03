using Flight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Interfaces
{
    public interface IFlight
    {
        IEnumerable<FlightEntity> GetFlights { get;}
        FlightEntity Get(int id);
        void Add(FlightEntity entity);
        void Update(FlightEntity dbEntity, FlightEntity entity);
        void Delete(FlightEntity entity);
    }
}
