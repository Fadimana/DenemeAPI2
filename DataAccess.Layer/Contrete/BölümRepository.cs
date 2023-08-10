using DataAccess.Layer.Entity;
using DataAccess.Layer.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Layer.Contrete
{
    public class BölümRepository : IBölümRepository
    {
        private readonly OkulDb _context;
        public BölümRepository(OkulDb context)
        {
            _context = context;
        }

        public async Task<Bölüm> CreateBölüm(Bölüm bölüm)
        {
            await _context.Bölümler.AddAsync(bölüm);
            await _context.SaveChangesAsync();
            return bölüm;
        }

        public Task DeleteBölüm(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Bölüm>> GetAllBölüm()
        {
            return  _context.Bölümler.ToList();
            
        }

        public async Task<Bölüm> GetBölüm(int id)
        {
            Bölüm bölüm1= await _context.Bölümler.Where(x => x.Id == id).FirstOrDefaultAsync();
            return bölüm1;
        } 

        public Task<Bölüm> UpdateBölüm(Bölüm bölüm)
        {
            throw new NotImplementedException();
        }
    }
}
