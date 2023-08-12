using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Layer.Entity
{
    public class Bölüm
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int FakülteId { get; set; }

        public Fakülte Fakülte { get; set; }
    }
}
