using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IStockRepository
    {
        IList<Stock> Get();
        Stock GetById(int id);
        bool Insert(Stock model);
        bool Update(int id, Stock model);
        bool Delete(int id);
    }
}
