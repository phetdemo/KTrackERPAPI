using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IMaster_HRepository
    {
        IList<Master_H> Get();
        object GetById(string id);
        bool Insert(Master_H model);

        bool Delete(int id);
    }
}
