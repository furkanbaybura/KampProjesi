using AutoMapper;
using DTOs;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampYeri.DAL.Services.Profiles
{
    public class KapasiteProfile : Profile
    {
        public KapasiteProfile()
        {

            CreateMap<Kapasite, KapasiteDto>().ReverseMap();
        }
    }
}
