﻿using on_the_sky.core.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace on_the_sky.core.services
{
    public interface IplaceService
    {
        public Task<List<Places>> GetAll();
        public Task<Places> GetById(int id);
        public Task ADD(Places place);
        public Task<Places> Put(int id, Places value);
        public Task<Places> Delete(int id);
    }
}
