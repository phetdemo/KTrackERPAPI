using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class StockService : IStockService
    {
        private readonly IStockRepository stockRepository;

        public StockService(IStockRepository stockRepository)
        {
            this.stockRepository = stockRepository;
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
