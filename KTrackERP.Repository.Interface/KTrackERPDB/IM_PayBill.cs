using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IM_PayBill
    {
        IList<M_PayBill> Get();
        M_PayBill GetById(int id);
        bool Insert(M_PayBill model);
        bool Update(int id, M_PayBill model);
        bool Delete(int id);
    }
}
