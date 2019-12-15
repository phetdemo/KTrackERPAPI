using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IM_DeviceTypeService
    {
        IList<M_DeviceType> Get();
        M_DeviceType GetById(int id);
        bool Insert(M_DeviceType model);
        bool Update(int id, M_DeviceType model);
        bool Delete(int id);
    }
}
