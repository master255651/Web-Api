using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Flight.Models
{
    public class FlightEntity
    {
        [Key]
        public int FlightId { get; set; }

        [Required]
        public DateTime FlightDate { get; set; }

        [Required]
        public float FlightDuration { get; set; }

        [Required]
        public string Departure { get; set; }

        [Required]
        public string Destination { get; set; }
    }
}
