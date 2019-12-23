using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IMaster_HRepository
    {
        IList<Master_H> Get();
        Master_H GetById(int id);
        bool Insert(Master_H model);

        bool Delete(int id);
    }
}
