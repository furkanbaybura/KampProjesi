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
    public class KapasiteRepo : Repo<Kapasite>
    {
        public KapasiteRepo(KampYeriDbContext context) : base(context)
        {
        }


    }
}
