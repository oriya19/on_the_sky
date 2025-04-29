using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using on_the_sky.core.Dto;
using on_the_sky.core.entities;
using on_the_sky.core.services;
using on_the_sky.models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace on_the_sky.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class TravelsController : ControllerBase
    {
        private readonly ItravelService _travelservice;
        private readonly IMapper _mapper;
        private readonly iUsersService _usersService;


        public TravelsController(ItravelService travelservice, IMapper map, iUsersService usersService)
        {
            _travelservice = travelservice;
            _mapper=map;
            _usersService = usersService;

        }

        // GET: api/<TravelsController>
        [HttpGet]
        [Authorize(Roles = "manager")]
        public async Task<ActionResult> Get()
        {
            var TravelsList = await _travelservice.GetAll();
            var Travels= _mapper.Map<IEnumerable<TravelDto>>(TravelsList);
            return Ok(Travels);
        }

        // GET api/<TravelsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var tra = await _travelservice.GetById(id);
            var travel= _mapper.Map<TravelDto>(tra);
            if (tra != null)
            {
                return Ok(travel);
            }
            return NotFound();
        }


        // POST api/<TravelsController>
        [HttpGet("is-exist")]
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] TravelsPostModel t)
        {
            var newTravel = _mapper.Map<Travels>(t);

            if (await _usersService.GetByName(t.UserName, t.Password) == null){
                var user= new Users { Password = t.Password , UserName=t.UserName , Role= Users.eRole.passanger };
                 await _usersService.ADD(user);
                newTravel.User = user;
                newTravel.UserId=user.Id;
            }
            else
            {
                var user2 = await _usersService.GetByName(t.UserName, t.Password);
                newTravel.User = user2;
                newTravel.UserId = user2.Id;

            }
            await _travelservice.ADD(newTravel);
            return Ok();
        }
    

        // PUT api/<TravelsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] TravelsPostModel t)
        {
     
            var travel = await _travelservice.Put(id, _mapper.Map<Travels>(t));
        if (travel != null)
        {
            return Ok(travel);
        }
        return NotFound();                                    // עדכון אובייקט
        }

        // DELETE api/<TravelsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var travel = await _travelservice.Delete(id);
            if (travel != null)
            {
                return Ok();
            }
            return NotFound();                         //מחיקת אובייקט
        }
    }
}
