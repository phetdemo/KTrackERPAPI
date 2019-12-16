using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IM_RentTypeRepository
    {
        IList<M_RentType> Get();
        M_RentType GetById(int id);
        bool Insert(M_RentType model);
        bool Update(int id, M_RentType model);
        bool Delete(int id);
    }
}
