using on_the_sky.core.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace on_the_sky.Data.repositories
{
    public class FlightRepositories : IFlightRepository
    {
        private readonly Datacontext _context;

        public FlightRepositories(Datacontext context)
        {
            _context = context;
        }

        public List<Flight> GetAll()
        {
            return _context.FlightDB;
        }
    }
}
