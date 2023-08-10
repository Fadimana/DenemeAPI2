using Business.Layer.Interface;
using DataAccess.Layer.Entity;
using DataAccess.Layer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer.Contrete
{
    public class FakülteBusinessServices : IFakülteBusinessServices 
    {
        private readonly IFakülteRepository _fakülteRepository;
        public FakülteBusinessServices(IFakülteRepository fakülteRepository) {

            _fakülteRepository = fakülteRepository;   
        }
        public async Task<Fakülte> CreateFakülte(Fakülte fakülte)
        {
            return await _fakülteRepository.CreateFakülte(fakülte);

        }

        public Task DeleteFakülte(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Fakülte>> GetAllFakülte()
        {
            return await _fakülteRepository.GetAllFakülte();
        }

        public async Task<Fakülte> GetFakülte(int id)
        {
            return await _fakülteRepository.GetFakülte(id);
        }

        public Task<Fakülte> UpdateFakülte(Fakülte fakülte)
        {
            throw new NotImplementedException();
        }
    }
}
