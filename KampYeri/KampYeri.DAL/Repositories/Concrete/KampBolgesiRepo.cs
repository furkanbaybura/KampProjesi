using Entities;
using KampYeri.DAL.Context;
using KampYeri.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampYeri.DAL.Repositories.Concrete
{
    public class KampBolgesiRepo : Repo<KampBolgesi>
    {
        public KampBolgesiRepo(KampYeriDbContext context) : base(context)
        {
        }
        public override KampBolgesi Get(int id)
        {

            return _context.KampBolgeleri.Include(kb => kb.Cadirlar).Where(c => c.Id == id).AsNoTracking().SingleOrDefault();
        }

        public override IEnumerable<KampBolgesi> GetAll()
        {
            return _context.KampBolgeleri.Include(kb => kb.Cadirlar).AsNoTracking().ToList();
        }

    }
}
