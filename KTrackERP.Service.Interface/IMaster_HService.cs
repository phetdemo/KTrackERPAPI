using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IMaster_HService
    {
        IList<Master_H> Get();
        Master_H GetbyId();
        bool Insert(Master_H model);
        bool Update(int id, Master_H model);
        bool Delete(int id);
    }
}
