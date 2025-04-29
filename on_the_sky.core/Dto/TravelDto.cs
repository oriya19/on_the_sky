using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace on_the_sky.core.Dto
{
    public class TravelDto
    {
        public int passengerid { get; set; }
        public string passengername { get; set; }
        public int FlightId { get; set; }
        public int amounttickets { get; set; }
        public FlightDto Flight { get; set; }

    }
}
