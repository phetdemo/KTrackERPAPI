using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IM_RentTypeService
    {
        IList<M_RentType> Get();
        M_RentType GetById(int id);
        bool Insert(M_RentType model);
        bool Update(int id, M_RentType model);
        bool Delete(int id);
    }
}
