using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace on_the_sky
{
    public class Flight
    {
        [Key]
      
        public int flightid { get; set; }
        public DateTime flighttime { get; set; }
        public int countryID { get; set; }

        public int Maximum { get; set; }
        public int amount { get; set; }
        public List<Travels>  passangers { get; set; }
        public Places country { get; set; }


    }

}
