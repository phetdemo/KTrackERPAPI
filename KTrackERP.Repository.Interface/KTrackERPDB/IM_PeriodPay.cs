using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IM_PeriodPay
    {
        IList<M_PeriodPay> Get();
        M_PeriodPay GetById(int id);
        bool Insert(M_PeriodPay model);
        bool Update(int id, M_PeriodPay model);
        bool Delete(int id);
    }
}
