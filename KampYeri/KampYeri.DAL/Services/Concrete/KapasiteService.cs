﻿using AutoMapper;
using DTOs;
using Entities;
using KampYeri.DAL.Repositories.Abstract;
using KampYeri.DAL.Repositories.Concrete;
using KampYeri.DAL.Services.Abstract;
using KampYeri.DAL.Services.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampYeri.DAL.Services.Concrete
{
    public class KapasiteService : Service<Kapasite, KapasiteDto>
    {
        public KapasiteService(KapasiteRepo repo) : base(repo)
        {
            MapperConfiguration config = new MapperConfiguration(config =>
            {
                Profile profile = new KapasiteProfile();
                config.AddProfile(profile);
            });
            base.Mapper = config.CreateMapper();
        }
    }
}
