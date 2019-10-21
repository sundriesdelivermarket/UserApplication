using SundiresDeliverApp.Core.Database_Entity;
using SundiresDeliverApp.Core.Repository_Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SundiresDeliverApp.Core.AppRepository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly SundriesMarketEntities Context;
        private IDbSet<TEntity> dbEntity;

        public Repository()
        {
            Context = new SundriesMarketEntities();
            dbEntity = Context.Set<TEntity>();
        }
            

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public TEntity Get(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbEntity.ToList();
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }
    }
}
