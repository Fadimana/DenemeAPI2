using Business.Layer.Interface;
using DataAccess.Layer.Contrete;
using DataAccess.Layer.Entity;
using DataAccess.Layer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer.Contrete
{
    public class BölümBusinessServices : IBölümBusinessServices
    {
        private readonly IBölümRepository _bölümRepository;

        public BölümBusinessServices(IBölümRepository bölümRepository)
        {
            _bölümRepository = bölümRepository;
        }
        public Task<Bölüm> CreateBölüm(string bölümname, int fakülteid)
        {
            return _bölümRepository.CreateBölüm(bölümname, fakülteid);
        }

        public Task DeleteBölüm(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Bölüm>> GetAllBölüm()
        {
            return await _bölümRepository.GetAllBölüm();
        }

        public async Task<Bölüm> GetBölüm(int id)
        {
            if (id>=0)
            {
                return await _bölümRepository.GetBölüm(id);
            }
            throw new NotImplementedException("Id giriniz.");
        }

        public Task<Bölüm> UpdateBölüm(Bölüm bölüm)
        {
            throw new NotImplementedException();
        }
    }
}
