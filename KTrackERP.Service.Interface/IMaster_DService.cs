
using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IMaster_DService
    {
        IList<Master_D> Get();
        Master_D GetbyId();
        bool Insert(Master_D model);
        bool Update(int id, Master_D model);
        bool Delete(int id);
    }
}
