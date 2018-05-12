using Roscosoft.Administration.Library.Entites;
using System.Collections.Generic;

namespace Roscosoft.Administration.Library.DomainContracts
{
    public interface INewLibrary
    {
        IEnumerable<NewEntity> GetNews();
        NewEntity GetNew(int idNew);
    }
}
