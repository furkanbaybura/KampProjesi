﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampYeri.DAL.Repositories.Abstract
{
    public interface IRepo<TEntity> where TEntity : BaseEntity
    {
        int Add (TEntity entity);
        int Update (TEntity entity);   
        int Delete (TEntity entity);
        TEntity Get (int id);
        IEnumerable<TEntity> GetAll ();
    }
}
