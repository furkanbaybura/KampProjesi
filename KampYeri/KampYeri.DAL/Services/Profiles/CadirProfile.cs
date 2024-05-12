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
    public class CadirProfile : Profile
    {
        public CadirProfile()
        {
            CreateMap<CadirDto, Cadir>().ForMember(dest => dest.KampBolgesi, opt => opt.MapFrom(src => src.KampBolgesi));
   
            CreateMap<KampBolgesiDto , KampBolgesi>().ReverseMap();
            CreateMap<CadirDto, Cadir>().ReverseMap();

        }
    }
}
