using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class StockRepository : IStockRepository
    {
        private readonly ERPKTIDBContext context;

        public StockRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Stock> Get()
        {
            throw new NotImplementedException();
        }

        public Stock GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Stock model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Stock model)
        {
            throw new NotImplementedException();
        }
    }
}
