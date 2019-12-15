using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IM_PayMonthSpacialService
    {
        IList<M_PayMonthSpacial> Get();
        M_PayMonthSpacial GetById(int id);
        bool Insert(M_PayMonthSpacial model);
        bool Update(int id, M_PayMonthSpacial model);
        bool Delete(int id);
    }
}
