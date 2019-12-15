using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IM_LimitSpeedService
    {
        IList<M_LimitSpeed> Get();
        M_LimitSpeed GetById(int id);
        bool Insert(M_LimitSpeed model);
        bool Update(int id, M_LimitSpeed model);
        bool Delete(int id);
    }
}
