using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IM_FirmWareService
    {
        IList<M_FirmWare> Get();
        M_FirmWare GetById(int id);
        bool Insert(M_FirmWare model);
        bool Update(int id, M_FirmWare model);
        bool Delete(int id);
    }
}
