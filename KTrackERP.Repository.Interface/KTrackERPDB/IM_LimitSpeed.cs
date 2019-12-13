using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IM_LimitSpeed
    {
        IList<M_LimitSpeed> Get();
        M_LimitSpeed GetById(int id);
        bool Insert(M_LimitSpeed model);
        bool Update(int id, M_LimitSpeed model);
        bool Delete(int id);
    }
}
