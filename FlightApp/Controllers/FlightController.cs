using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flight.Models;
using FlightApp.Interfaces;

namespace FlightApp.Controllers
{
    [Route("flight")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IFlight _flight;
        public EmployeeController(IFlight flight)
        {
            _flight = flight;
        }

        [HttpGet("/flights")]
        public IActionResult GetAllFlights()
        {
            IEnumerable<FlightEntity> flights = _flight.GetFlights;

            return Ok(flights);
        }

        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            FlightEntity employee = _flight.Get(id);
            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        [HttpGet]
        public async Task<FlightEntity> Get()
        {
            int id;
            int.TryParse(HttpContext.Request.Query["flightid"].ToString(), out id);

            FlightEntity employee;

            return await Task.Run(() => employee = _flight.Get(id));
        }

        [HttpPost("/newflight")]
        public IActionResult Post([FromBody] FlightEntity flight)
        {
            if (flight == null)
            {
                return BadRequest("Flight is null.");
            }
            _flight.Add(flight);

            return CreatedAtRoute("Get", new { Id = flight.FlightId }, flight);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] FlightEntity flight)
        {
            if (flight == null)
            {
                return BadRequest("Employee is null.");
            }

            FlightEntity flightEntityToUpdate = _flight.Get(id);
            if (flightEntityToUpdate == null)
            {
                return NotFound("The flight record couldn't be found.");
            }
            _flight.Update(flightEntityToUpdate, flight);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            FlightEntity flight = _flight.Get(id);
            if (flight == null)
            {
                return NotFound("The flight record couldn't be found.");
            }
            _flight.Delete(flight);
            return NoContent();
        }
    }
}