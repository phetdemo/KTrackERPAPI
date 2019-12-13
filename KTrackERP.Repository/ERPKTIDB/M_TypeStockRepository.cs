using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_TypeStockRepository : IM_TypeStock
    {
        private readonly ERPKTIDBContext context;

        public M_TypeStockRepository(ERPKTIDBContext context)
        {
            this.context = context;
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
