using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;

namespace KTrackERP.Service
{
    public class HStockDetailService : IHStockDetailService
    {
        private readonly IHStockDetailRepository hStockDetailRepository;
        public HStockDetailService(IHStockDetailRepository hStockDetailRepository)
        {
            this.hStockDetailRepository = hStockDetailRepository;
        }

        public object GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
