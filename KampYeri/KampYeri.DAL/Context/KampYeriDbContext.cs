using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampYeri.DAL.Context
{
    public class KampYeriDbContext :DbContext
    {
        public DbSet<KampBolgesi> KampBolgeleri { get; set; }
        public DbSet<Kapasite> Kapasiteler {  get; set; }
        public DbSet<Cadir> Cadirlar { get; set; }
        public KampYeriDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }
    }
}
