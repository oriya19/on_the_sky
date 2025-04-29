﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using on_the_sky.core.entities;
using on_the_sky.core.repositories;

namespace on_the_sky.Data.repositories
{
    public class UsersRipositories : iUsersRipository
    {
        private readonly Datacontext _context;

        public UsersRipositories(Datacontext context)
        {
            _context = context;
        }

        public async Task<List<Users>> GetAll()
        {
            return await _context.UsersDB.Include(f => f.UserName).Include(f => f.Password).ToListAsync();
        }
        public async Task<Users> GetByName(string name , string Password)/* --*/
        {
            return await _context.UsersDB.FirstOrDefaultAsync(x => x.UserName == name && x.Password == Password);

        }
        public async Task ADD_user(Users u)
        {
            _context.UsersDB.Add(u);
            await _context.SaveChangesAsync();

        }
        public async Task<Users> Put(int id, Users value)
        {
            var user = await _context.UsersDB.FirstOrDefaultAsync(u => u.Id == id);
            user.UserName = value.UserName;
            user.Password = value.Password;
            user.Role = value.Role;
            await _context.SaveChangesAsync();
            return user;
        }
        public async Task<Users> Delete(int id)
        {
            Users tmp = null;
            var use = await _context.UsersDB.FirstOrDefaultAsync(u => u.Id == id);
            if (use != null)
            {
                tmp = use;
                _context.UsersDB.Remove(use);
            }
            await _context.SaveChangesAsync();
            return tmp;
        }
        public async Task<bool> IsExist(string name, string password)
        {
            var user = await _context.UsersDB.FirstOrDefaultAsync(u => u.UserName == name && u.Password == password);
            if (user != null)
            {
                return true;
            }
            return false;
        }
    }
}

