using BerutDataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Berut.Entities.Abstract;

namespace BerutDataAccess.Concrete.MSSQL
{
    public class MssqlEntityRepository<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public List <TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() :
                    context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Add(TEntity entities)
        {
            
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entities);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entities)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entities);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}



        
