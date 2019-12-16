using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IM_TypeStockRepository
    {
        IList<M_TypeStock> Get();
        M_TypeStock GetById(int id);
        bool Insert(M_TypeStock model);
        bool Update(int id, M_TypeStock model);
        bool Delete(int id);
    }
}
