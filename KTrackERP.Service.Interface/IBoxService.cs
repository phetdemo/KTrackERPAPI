using KTrackERP.Entity;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IBoxService
    {
        IList<Box> Get();
        object GetbyId(int id);
        bool Insert(Box model);
        bool Update(int id, Box model);
        bool Delete(int id);
        object GetBoxByJobID(int JobID);
    }
}
