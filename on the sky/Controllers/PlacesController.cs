using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace on_the_sky.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlacesController : ControllerBase
    {
        //public static List<Places> fplaces = new List<Places> {
        //        new Places { country= "israel" ,countryid= 111  },
        //        new Places  { country= "usa" ,countryid= 112  },
        //        new Places { country= "la" ,countryid= 113  }

        //};
        public readonly Datacontext _context;


        public PlacesController(Datacontext context)
        {
            _context = context;
        }



        // GET: api/<TravelsController>
        [HttpGet]
        public IEnumerable<Places> Get()
        {
            return _context.PlacesDB;
        }

        // GET api/<TravelsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        // POST api/<TravelsController>
        [HttpPost]
        public Places Post([FromBody] Places value)
        {
            _context.PlacesDB.Add(value);
            return value;
        }

        // PUT api/<TravelsController>/5
        [HttpPut("{id}")]
        public Places Put(int id, [FromBody] Places value)
        {
            var index = _context.PlacesDB.FindIndex(e => e.countryid== id);
            _context.PlacesDB[index].countryid = value.countryid;
            _context.PlacesDB[index].country = value.country;

            return _context.PlacesDB[index];                                  // עדכון אובייקט
        }

        // DELETE api/<TravelsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = _context.PlacesDB.FindIndex(e => e.countryid== id);
            _context.PlacesDB.Remove(_context.PlacesDB[index]);                          //מחיקת אובייקט
        }
    }
}
