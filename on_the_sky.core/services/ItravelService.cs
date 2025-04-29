using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace on_the_sky.core.services
{
    public interface ItravelService
    {
        public Task<List<Travels>> GetAll();
        public Task<Travels> GetById(int id);
        public Task ADD(Travels f);
        public Task<Travels> Put(int id, Travels value);
        public Task<Travels> Delete(int id);
    }
}
