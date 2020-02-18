using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IMaster_DRepository
    {
        IList<Master_D> Get();
        Master_D GetById(string id);
        bool Insert(Master_D model);

        bool Delete(int id);
        IList<Master_D> GetMasterType(string prmtyp);
        object GetOptionBox(int boxid);
    }
}
