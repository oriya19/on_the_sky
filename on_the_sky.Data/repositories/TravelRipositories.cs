using Microsoft.EntityFrameworkCore;
using on_the_sky.core.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace on_the_sky.Data.repositories
{
    public class TravelRipositories: ITravelRepository
    {
        private readonly Datacontext _context;
        public TravelRipositories(Datacontext context)
        {
            _context= context;
        }
        public async Task<List<Travels>> Getlist()
        {
            return await _context.TravelsDB.Include(t => t.Flight).ToListAsync();
        }
       
        public async Task<Travels> GetById(int id)
        {
            return await _context.TravelsDB.FirstOrDefaultAsync(x => x.passengerid == id);

        }
        public async Task ADD(Travels pas)
        {
           _context.TravelsDB.Add(pas);
            await _context.SaveChangesAsync();
        }


        public async Task<Travels> Put(int id, Travels value)
        {
            var trv = await _context.TravelsDB.FirstOrDefaultAsync(t => t.passengerid == id);

            //var index = flight_db.FindIndex(e => e.flightid == id);
            trv.Flight = value.Flight;
            trv.passengername = value.passengername;
            trv.amounttickets = value.amounttickets;
            trv.FlightId = value.FlightId;
            await _context.SaveChangesAsync();

            return trv;
        }

        public async Task<Travels> Delete(int id)
        {
            Travels tmp = null;
            var trv = await _context.TravelsDB.FirstOrDefaultAsync(e => e.passengerid == id);
            if (trv != null)
            {
                tmp = trv;
                _context.TravelsDB.Remove(tmp);
            }
          
            await _context.SaveChangesAsync();

            return tmp;
        }
    }
}
