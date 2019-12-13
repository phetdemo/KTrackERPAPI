using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IM_Device
    {
        IList<M_Device> Get();
        M_Device GetById(int id);
        bool Insert(M_Device model);
        bool Update(int id, M_Device model);
        bool Delete(int id);
    }
}
