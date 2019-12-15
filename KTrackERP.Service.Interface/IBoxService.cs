using KTrackERP.Entity;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IBoxService
    {
        IList<Box> Get();
        Box GetbyId();
        bool Insert(Box model);
        bool Update(int id, Box model);
        bool Delete(int id);
    }
}
