using DataAccess.Layer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer.Interface
{
    public interface IFakülteBusinessServices
    {
        Task<Fakülte> GetFakülte(int id);
        Task<List<Fakülte>> GetAllFakülte();

        Task<Fakülte> CreateFakülte(Fakülte fakülte);
        Task DeleteFakülte(int id);

        Task<Fakülte> UpdateFakülte(Fakülte fakülte);
    }
}
