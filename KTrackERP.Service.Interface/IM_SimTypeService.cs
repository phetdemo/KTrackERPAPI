using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IM_SimTypeService
    {
        IList<M_SimType> Get();
        M_SimType GetById(int id);
        bool Insert(M_SimType model);
        bool Update(int id, M_SimType model);
        bool Delete(int id);
    }
}
