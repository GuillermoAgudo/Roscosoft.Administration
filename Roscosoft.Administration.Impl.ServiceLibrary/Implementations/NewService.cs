using AutoMapper;
using Roscosoft.Administration.Contracts.ServiceLibrary.Contracts;
using Roscosoft.Administration.Contracts.ServiceLibrary.DTO;
using Roscosoft.Administration.Library.DomainContracts;
using Roscosoft.Administration.Library.Entites;
using System.Collections.Generic;

namespace Roscosoft.Administration.Impl.ServiceLibrary.Implementations
{
    public class NewService : INewService
    {
        private readonly INewLibrary NewLibrary;

        public NewService(INewLibrary newLibrary)
        {
            this.NewLibrary = newLibrary;
        }

        public NewDTO GetNew(int idNew)
        {
            var newEntity = this.NewLibrary.GetNew(idNew);

            return Mapper.Map<NewDTO>(newEntity);
        }

        public IEnumerable<NewDTO> GetNews()
        {
            var news = this.NewLibrary.GetNews();

            return Mapper.Map<IEnumerable<NewEntity>, IEnumerable<NewDTO>>(news);
        }
    }
}
