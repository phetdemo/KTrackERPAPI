using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IM_DeviceTypeRepository
    {
        IList<M_DeviceType> Get();
        M_DeviceType GetById(int id);
        bool Insert(M_DeviceType model);
        bool Update(int id, M_DeviceType model);
        bool Delete(int id);
    }
}
