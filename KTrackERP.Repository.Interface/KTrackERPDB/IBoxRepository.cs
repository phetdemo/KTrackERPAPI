using KTrackERP.Entity;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IBoxRepository
    {
        IList<Box> Get();
        Box GetById(int id);
        bool Insert(Box model);
        bool Update(int id, Box model);
        bool Delete(int id);

    }
}
