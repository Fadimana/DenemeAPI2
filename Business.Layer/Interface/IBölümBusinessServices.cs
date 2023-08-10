using DataAccess.Layer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer.Interface
{
    public interface IBölümBusinessServices
    {
        Task<Bölüm> GetBölüm(int id);
        Task<List<Bölüm>> GetAllBölüm();

        Task<Bölüm> CreateBölüm(Bölüm bölüm);
        Task DeleteBölüm(int id);

        Task<Bölüm> UpdateBölüm(Bölüm bölüm);
    }
}
