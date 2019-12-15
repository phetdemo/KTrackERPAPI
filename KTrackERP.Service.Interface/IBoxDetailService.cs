using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    interface IBoxDetailService
    {
        IList<BoxDetail> Get();
        BoxDetail GetbyId();
        bool Insert(BoxDetail model);
        bool Update(int id, BoxDetail model);
        bool Delete(int id);
    }
}
