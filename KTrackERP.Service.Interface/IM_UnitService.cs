using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IM_UnitService
    {
        IList<M_Unit> Get();
        M_Unit GetById(int id);
        bool Insert(M_Unit model);
        bool Update(int id, M_Unit model);
        bool Delete(int id);
    }
}
