namespace on_the_sky
{
    public class Datacontext
    {
        public List<Flight> FlightDB { get; set; }
        public List<Travels> TravelsDB { get; set; }
        public List<Places> PlacesDB { get; set; }
        public Datacontext()
        {
            FlightDB = new List<Flight>
            {
                new Flight{ countryid=211,flightid=111,amount=50,Maximum=65,flighttime=new DateTime()   },
                new Flight{ countryid=212,flightid=112,amount=50,Maximum=65,flighttime=new DateTime()   },
                new Flight{ countryid=213,flightid=113,amount=50,Maximum=65,flighttime=new DateTime()   }
            };

            TravelsDB = new List<Travels>
            {
                new Travels( 211, "oriya_shraga",111,3, 311  ),
               new Travels( 211, "oriya_shraga",111,3, 311  ),
               new Travels( 211, "oriya_shraga",111,3, 311  )
            };

            PlacesDB = new List<Places>
            {
                 new Places { country= "israel" ,countryid= 111  },
                new Places  { country= "usa" ,countryid= 112  },
                new Places { country= "la" ,countryid= 113  }
            };
        }
    }
}
