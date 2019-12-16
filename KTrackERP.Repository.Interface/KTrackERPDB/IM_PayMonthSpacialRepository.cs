using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IM_PayMonthSpacialRepository
    {
        IList<M_PayMonthSpacial> Get();
        M_PayMonthSpacial GetById(int id);
        bool Insert(M_PayMonthSpacial model);
        bool Update(int id, M_PayMonthSpacial model);
        bool Delete(int id);
    }
}
