using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class StockDetailService : IStockDetailService
    {
        private readonly IStockDetailRepository stockDetailRepository;

        public StockDetailService(IStockDetailRepository stockDetailRepository)
        {
            this.stockDetailRepository = stockDetailRepository;
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
