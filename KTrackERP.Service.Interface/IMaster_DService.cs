
using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IMaster_DService
    {
        IList<Master_D> Get();
        Master_D GetbyId(string id);
        bool Insert(Master_D model);

        bool Delete(int id);
        IList<Master_D> GetMasterType(string prmtyp);
        object GetOptionBox(int boxid);
    }
}
