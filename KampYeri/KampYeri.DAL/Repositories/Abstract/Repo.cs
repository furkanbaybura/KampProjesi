using Entities;
using KampYeri.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampYeri.DAL.Repositories.Abstract
{
    public abstract class Repo<TEntity> : IRepo<TEntity> where TEntity : BaseEntity
    {
        protected  KampYeriDbContext _context;
        protected DbSet<TEntity> entities;

        protected Repo(KampYeriDbContext context)
        {

            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTrackingWithIdentityResolution;
            entities= _context.Set<TEntity>(); 
        }
        public int Add(TEntity entity)
        {
           // _context.Entry(entity).State = EntityState.Added;
            entities.Add(entity);
            return _context.SaveChanges();
        }

        public int Delete(TEntity entity)
        {
          // _context.Entry(entity).State = EntityState.Deleted;
            entities.Remove(entity);
            return _context.SaveChanges();
        }

        public virtual TEntity Get(int id)
        {
            return entities.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return entities.AsNoTracking().ToList();
        }

        public int Update(TEntity entity)
        {
            entity.UpdatedTime = DateTime.Now;
            _context.Entry(entity).State = EntityState.Modified;
            entities.Update(entity);
            return _context.SaveChanges();
        }
    }
}
