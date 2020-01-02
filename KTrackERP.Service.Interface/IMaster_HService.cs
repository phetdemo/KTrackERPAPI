using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IMaster_HService
    {
        IList<Master_H> Get();
        object GetbyId(string id);
        bool Insert(Master_H model);
        bool Delete(int id);
    }
}
