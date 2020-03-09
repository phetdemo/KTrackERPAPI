using KTrackERP.Entity;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IBoxRepository
    {
        IList<Box> Get();
        object GetById(int id);
        bool Insert(Box model);
        bool Update(int id, Box model);
        bool Delete(int id);
        object GetBoxByJobID(int JobID);

    }
}
