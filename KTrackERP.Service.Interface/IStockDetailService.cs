using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IStockDetailService
    {
        IList<Stock_Detail> Get();
        Stock_Detail GetById(int id);
        bool Insert(Stock_Detail model);
        bool Update(int id, Stock_Detail model);
        bool Delete(int id);
    }
}
