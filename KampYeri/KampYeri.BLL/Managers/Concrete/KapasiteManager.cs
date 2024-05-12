using DTOs;
using Entities;
using KampYeri.BLL.Managers.Abstract;
using KampYeri.DAL.Services.Abstract;
using KampYeri.DAL.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampYeri.BLL.Managers.Concrete
{
    public class KapasiteManager : Manager<KapasiteDto, Kapasite>
    {
        public KapasiteManager(KapasiteService service) : base(service)
        {
        }
    }
}
