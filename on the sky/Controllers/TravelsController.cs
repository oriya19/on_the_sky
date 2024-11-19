using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace on_the_sky.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelsController : ControllerBase
    {
        //private static List<Travels> ftravels = new List<Travels> {
        //        new Travels( 211, "oriya_shraga",111,3, 311  ),
        //       new Travels( 211, "oriya_shraga",111,3, 311  ),
        //       new Travels( 211, "oriya_shraga",111,3, 311  )
        //};

        public readonly Datacontext _context;
        public TravelsController(Datacontext context)
        {
            _context = context;
        }





        // GET: api/<TravelsController>
        [HttpGet]
        public IEnumerable<Travels> Get()
        {
            return _context.TravelsDB;
        }

        // GET api/<TravelsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

       
        // POST api/<TravelsController>
        [HttpPost]
        public Travels Post([FromBody] Travels value)
        {
            _context.TravelsDB.Add(value);
            return value;
        }

        // PUT api/<TravelsController>/5
        [HttpPut("{id}")]
        public Travels Put(int id, [FromBody] Travels value)
        {
            var index = _context.TravelsDB.FindIndex(e => e.passengerid == id);
            _context.TravelsDB[index].passengerid = value.passengerid;
            _context.TravelsDB[index].passengername = value.passengername;
            _context.TravelsDB[index].flightid = value.flightid;
            _context.TravelsDB[index].countryid = value.countryid;
            _context.TravelsDB[index].amounttickets = value.amounttickets;
            return _context.TravelsDB[index];                                  // עדכון אובייקט
        }

        // DELETE api/<TravelsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            var index = _context.TravelsDB.FindIndex(e => e.passengerid == id);
            _context.TravelsDB.Remove(_context.TravelsDB[index]);                          //מחיקת אובייקט
        }
    }
}
