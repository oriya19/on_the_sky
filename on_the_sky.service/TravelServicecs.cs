using on_the_sky.core.repositories;
using on_the_sky.core.services;
using on_the_sky.Data.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace on_the_sky.service
{
    public class TravelServicecs: ItravelService
    {
        private ITravelRepository _travelrepository;
        public TravelServicecs(ITravelRepository travelrepository)
        {
            _travelrepository = travelrepository;
        }
        public async Task<List<Travels>> GetAll()
        {
            return await _travelrepository.Getlist();

        }
        public async Task <Travels> GetById(int id)
        {
            return await _travelrepository.GetById(id);
        }
        public async Task ADD(Travels pas)
        {
           await _travelrepository.ADD(pas);

        }
        public async Task<Travels> Put(int id, Travels value)
        {
            return await _travelrepository.Put(id, value);

        }
        public async Task<Travels> Delete(int id)
        {
            return await _travelrepository.Delete(id);
        }
    }
}
