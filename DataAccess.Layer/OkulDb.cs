using DataAccess.Layer.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Layer
{
    public class OkulDb :DbContext
    {
       public DbSet<Fakülte>Fakülteler { get; set; }
        public DbSet<Bölüm>Bölümler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}