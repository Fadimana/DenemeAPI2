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
    public class FakülteRepository : IFakülteRepository
    {
        private readonly OkulDb _context;
        public FakülteRepository(OkulDb context)
        {
            _context = context;
        }

        public async Task<Fakülte> CreateFakülte(Fakülte fakülte)
        {
            
            //Fakülte fak = new Fakülte();
            //Bölüm bölüm = new Bölüm();
            //fak.FakülteName = fakülte.FakülteName;
            //fak.Bölümler.Add(new() { BölümName = bölüm.BölümName });
            //fak.Bölümler.Add(new() { BölümName = bölüm.BölümName }); 

            await _context.AddAsync(fakülte);
            await _context.SaveChangesAsync();
            return fakülte;
        }

        public Task DeleteFakülte(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Fakülte>> GetAllFakülte()
        {
            return await _context.Fakülteler.ToListAsync();
                
             
        }

        public async Task<Fakülte> GetFakülte(int id)
        {
            Fakülte fak=await _context.Fakülteler.FindAsync(id);
            return fak;
        }

        public Task<Fakülte> UpdateFakülte(Fakülte fakülte)
        {
            throw new NotImplementedException();
        }
    }
}
