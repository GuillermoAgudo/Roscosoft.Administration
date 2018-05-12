using Roscosoft.Administration.Contracts.ServiceLibrary.DTO;
using System.Collections.Generic;

namespace Roscosoft.Administration.Contracts.ServiceLibrary.Contracts
{
    public interface INewService
    {
        IEnumerable<NewDTO> GetNews();
        NewDTO GetNew(int idNew);
    }
}
