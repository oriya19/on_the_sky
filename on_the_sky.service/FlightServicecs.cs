using on_the_sky.core.repositories;
using on_the_sky.core.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace on_the_sky.service
{
    public class FlightServicecs : IFlightService
    {
        private IFlightRepository _Flightrepositories;
        public FlightServicecs(IFlightRepository flightrepositories)
        {
            _Flightrepositories = flightrepositories;
        }
        public List<Flight> Getlist()
        {
            return _Flightrepositories.GetAll();

        }
    }
}
