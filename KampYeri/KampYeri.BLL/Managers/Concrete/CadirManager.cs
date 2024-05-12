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
    public class CadirManager : Manager<CadirDto, Cadir>
    {
        public CadirManager(CadirService service) : base(service)
        {
        }
    }
}
