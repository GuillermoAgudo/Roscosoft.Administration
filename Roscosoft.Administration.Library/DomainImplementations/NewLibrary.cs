using Roscosoft.Administration.Library.DomainContracts;
using Roscosoft.Administration.Library.Entites;
using Roscosoft.Administration.Library.InfrastrucutreContracts;
using System.Collections.Generic;

namespace Roscosoft.Administration.Library.DomainImplementations
{
    public class NewLibrary : INewLibrary
    {
        private readonly IRepository<NewEntity> NewRepository;

        public NewLibrary(IRepository<NewEntity> newRepository)
        {
            this.NewRepository = newRepository;
        }

        public NewEntity GetNew(int idNew)
        {
            return this.NewRepository.GetEntity(idNew);
        }

        public IEnumerable<NewEntity> GetNews()
        {
            return this.NewRepository.GetEntities();
        }
    }
}
