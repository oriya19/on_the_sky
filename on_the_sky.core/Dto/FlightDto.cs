using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace on_the_sky.core.Dto
{
    public class FlightDto
    {
        public int flightid { get; set; }
        public DateTime flighttime { get; set; }
        public int countryID { get; set; }

        public int Maximum { get; set; }
        public int amount { get; set; }
        public PlaceDto country { get; set; }
    }
}
