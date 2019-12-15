using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IM_PositionService
    {
        IList<M_Position> Get();
        M_Position GetById(int id);
        bool Insert(M_Position model);
        bool Update(int id, M_Position model);
        bool Delete(int id);
    }
}
