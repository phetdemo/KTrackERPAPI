using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IM_AccessoriesService
    {
        IList<M_Accessories> Get();
        M_Accessories GetById(int id);
        bool Insert(M_Accessories model);
        bool Update(int id, M_Accessories model);
        bool Delete(int id);
    }
}
