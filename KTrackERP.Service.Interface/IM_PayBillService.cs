using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IM_PayBillService
    {
        IList<M_PayBill> Get();
        M_PayBill GetById(int id);
        bool Insert(M_PayBill model);
        bool Update(int id, M_PayBill model);
        bool Delete(int id);
    }
}
