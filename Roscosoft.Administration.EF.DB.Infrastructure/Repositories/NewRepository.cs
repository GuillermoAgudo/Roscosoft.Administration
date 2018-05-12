using Microsoft.EntityFrameworkCore;
using Roscosoft.Administration.EF.DB.Infrastructure.Context;
using Roscosoft.Administration.Library.Entites;
using Roscosoft.Administration.Library.InfrastrucutreContracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Roscosoft.Administration.EF.DB.Infrastructure.Repositories
{
    public class NewRepository : IRepository<NewEntity>
    {
        private readonly BaseDbContext BaseDbContext;
        private DbSet<NewEntity> DbSet => BaseDbContext.Set<NewEntity>();

        public IQueryable<NewEntity> Entities => DbSet;

        public NewRepository(BaseDbContext baseDbContext)
        {
            this.BaseDbContext = baseDbContext;
        }

        public void Add(NewEntity entity)
        {
            this.BaseDbContext.Add(entity);
        }

        public void Remove(NewEntity entity)
        {
            this.BaseDbContext.Remove(entity);
        }

        public NewEntity GetEntity(int idEntity)
        {
            return BaseDbContext.News.Where(newEntity => newEntity.IdNew == idEntity).FirstOrDefault();
        }

        public IEnumerable<NewEntity> GetEntities()
        {
            return BaseDbContext.News.ToList();
        }
    }
}
