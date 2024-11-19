using Microsoft.AspNetCore.Mvc;
using on_the_sky.service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace on_the_sky.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly IFlightServicecs _flightservice ;


        public FlightController(IFlightServicecs flightservice)
        {
            _flightservice = flightservice;
        }

        // GET: api/<TravelsController>
        [HttpGet]
        public IEnumerable<Flight> Get()
        {
            return _flightservice.Getlist();
        }

        // GET api/<TravelsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        // POST api/<TravelsController>
        [HttpPost]
        public Flight Post([FromBody] Flight value)
        {
            _flightservice.Getlist().Add(value);
            return value;
        }

        // PUT api/<TravelsController>/5
        [HttpPut("{id}")]
        public Flight Put(int id, [FromBody] Flight value)
        {
            var index = _flightservice.Getlist().FindIndex(e => e.flightid == id);
            _flightservice.Getlist()[index].countryid = value.countryid;
            _flightservice.Getlist()[index].flightid = value.flightid;
            _flightservice.Getlist()[index].flighttime = value.flighttime;
            _flightservice.Getlist()[index].Maximum = value.Maximum;
            _flightservice.Getlist()[index].amount = value.amount;
            return _flightservice.Getlist()[index];                                  // עדכון אובייקט
        }

        // DELETE api/<TravelsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            var index = _flightservice.Getlist().FindIndex(e => e.flightid == id);
            _flightservice.Getlist().Remove(_flightservice.Getlist()[index]);                          //מחיקת אובייקט
        }
}
}
