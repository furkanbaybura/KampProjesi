﻿using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampYeri.DAL.Services.Abstract
{
    public interface IService<TDto> where TDto : BaseDto
    {
        int Add (TDto dto);
        int Update (TDto dto);
        int Delete (TDto dto);
        IEnumerable<TDto> GetAll ();
        TDto? Get (int id);
    }
}
