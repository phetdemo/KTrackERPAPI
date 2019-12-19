using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IMaster_DRepository
    {
        IList<Master_D> Get();
        Master_D GetById(int id);
        bool Insert(Master_D model);
        bool Update(int id, Master_D model);
        bool Delete(int id);
    }
}
