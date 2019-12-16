using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IM_AccessoriesRepository
    {
        IList<M_Accessories> Get();
        M_Accessories GetById(int id);
        bool Insert(M_Accessories model);
        bool Update(int id, M_Accessories model);
        bool Delete(int id);
    }
}
