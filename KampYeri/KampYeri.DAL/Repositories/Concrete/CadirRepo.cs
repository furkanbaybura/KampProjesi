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
    public class CadirRepo : Repo<Cadir>
    {
        public CadirRepo(KampYeriDbContext context) : base(context)
        {
        }
        public override Cadir Get(int id)
        {

            return _context.Cadirlar.Include(kb => kb.KampBolgesi).Where(c => c.Id == id).AsNoTracking().SingleOrDefault();
        }

        public override IEnumerable<Cadir> GetAll()
        {
            return _context.Cadirlar.Include(kb => kb.KampBolgesi).AsNoTracking().ToList();
        }
    }
}
