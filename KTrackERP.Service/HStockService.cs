using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;

namespace KTrackERP.Service
{
    public class HStockService : IHStockService
    {
        private readonly IHStockRepository hStockRepository;
        public HStockService(IHStockRepository hStockRepository)
        {
            this.hStockRepository = hStockRepository;
        }

        public object GetById(int id)
        {
            return hStockRepository.GetById(id);
        }

        public bool Insert(HStock model)
        {
            throw new NotImplementedException();
        }
    }
}
