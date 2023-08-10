using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Layer.Entity
{
    public class Fakülte //principal
    {
        public int Id { get; set; }
        public string? FakülteName { get; set; }

        public ICollection<Bölüm>Bölümler { get; set; }

    }
}
