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
    public class KampBolgesiProfile : Profile
    {
        public KampBolgesiProfile()
        {
            CreateMap<KampBolgesiDto,KampBolgesi>().ForMember(dest => dest.Cadirlar, opt => opt.MapFrom(src => src.Cadirlar));

            CreateMap<Cadir, CadirDto>().ReverseMap();
            CreateMap<KampBolgesiDto, KampBolgesi>().ReverseMap();
        }
    }
}
