using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IM_CameraTypeRepository
    {
        IList<M_CameraType> Get();
        M_CameraType GetById(int id);
        bool Insert(M_CameraType model);
        bool Update(int id, M_CameraType model);
        bool Delete(int id);
    }
}
