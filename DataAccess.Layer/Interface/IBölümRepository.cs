using DataAccess.Layer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Layer.Interface
{
    public interface IBölümRepository
    {
        Task<Bölüm> GetBölüm(int id);
        Task<List<Bölüm>> GetAllBölüm();

        Task<Bölüm> CreateBölüm(string bölümname, int fakülteid);
        Task DeleteBölüm(int id);

        Task<Bölüm> UpdateBölüm(Bölüm bölüm);
    }
}
