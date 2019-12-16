using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_TypeStockService : IM_TypeStockService
    {
        private readonly IM_TypeStockRepository m_TypeStockRepository;

        public M_TypeStockService(IM_TypeStockRepository typeStockRepository)
        {
            m_TypeStockRepository = typeStockRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_TypeStock> Get()
        {
            throw new NotImplementedException();
        }

        public M_TypeStock GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_TypeStock model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_TypeStock model)
        {
            throw new NotImplementedException();
        }
    }
}
