

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using on_the_sky.core.entities;

namespace on_the_sky
{
    public class Travels
    {

        [Key]
        
        public int passengerid { get; set; }
        public string passengername { get; set; }
        public int amounttickets { get; set; }
        public int FlightId { get; set; }
        public Flight Flight { get; set; }
        //[ForeignKey(nameof(User))]
        public int UserId { get; set; }

        public Users User { get; set; }
        

    }
}
