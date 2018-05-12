using System.Collections.Generic;
using System.Linq;

namespace Roscosoft.Administration.Library.InfrastrucutreContracts
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Entities { get; }
        void Add(T entity);
        void Remove(T entity);
        T GetEntity(int idEntity);
        IEnumerable<T> GetEntities();
    }
}
