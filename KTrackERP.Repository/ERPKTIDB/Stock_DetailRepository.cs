using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class Stock_DetailRepository : IStockDetail
    {
        private readonly ERPKTIDBContext context;

        public Stock_DetailRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Stock_Detail> Get()
        {
            throw new NotImplementedException();
        }

        public Stock_Detail GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Stock_Detail model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Stock_Detail model)
        {
            throw new NotImplementedException();
        }
    }
}
