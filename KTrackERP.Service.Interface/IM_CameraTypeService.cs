using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IM_CameraTypeService
    {
        IList<M_CameraType> Get();
        M_CameraType GetById(int id);
        bool Insert(M_CameraType model);
        bool Update(int id, M_CameraType model);
        bool Delete(int id);
    }
}
