using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IM_LicenceDriveType
    {
        IList<M_LicenceDriveType> Get();
        M_LicenceDriveType GetById(int id);
        bool Insert(M_LicenceDriveType model);
        bool Update(int id, M_LicenceDriveType model);
        bool Delete(int id);
    }
}
