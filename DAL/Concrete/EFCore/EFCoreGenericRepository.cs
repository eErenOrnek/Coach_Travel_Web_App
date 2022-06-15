using DAL.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EFCore
{
    public class EFCoreGenericRepository<TEntity, TContext> : IRepository<TEntity> where TEntity : class where TContext : Context, new()
    {
        public void Create(TEntity entity)
        {
            using var context = new Context();
            context.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            using var context = new Context();
            context.Set<TEntity>().Remove(entity);
        }

        public List<TEntity> GetAll()
        {
            using var context = new Context();
            return context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            using var context = new Context();
            return context.Set<TEntity>().Find(id);
        }

        public virtual void Update(TEntity entity)
        {
            using var context = new Context();
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
