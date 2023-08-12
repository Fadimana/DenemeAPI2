using DataAccess.Layer.Entity;
using DataAccess.Layer.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
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

        public async Task<Bölüm> CreateBölüm(string bölümname, int fakülteid)
        {
            Fakülte fakülte = await _context.Fakülteler.FindAsync(fakülteid);
            Bölüm bölüm = new() { Name = bölümname,FakülteId =fakülteid, Fakülte = fakülte };
            fakülte.Bölümler.Add(bölüm);

            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                MaxDepth = 32,
            };

            string jsonString = JsonSerializer.Serialize(fakülte, options);

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
            return await _context.Bölümler.ToListAsync();
            
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
