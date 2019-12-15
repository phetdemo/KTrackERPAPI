using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IStockService
    {
        IList<Stock> Get();
        Stock GetById(int id);
        bool Insert(Stock model);
        bool Update(int id, Stock model);
        bool Delete(int id);
    }
}
