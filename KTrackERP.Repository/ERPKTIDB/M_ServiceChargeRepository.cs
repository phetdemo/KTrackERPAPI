using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_ServiceChargeRepository : IM_ServiceCharge
    {
        private readonly ERPKTIDBContext context;

        public M_ServiceChargeRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_ServiceCharge> Get()
        {
            throw new NotImplementedException();
        }

        public M_ServiceCharge GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_ServiceCharge model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_ServiceCharge model)
        {
            throw new NotImplementedException();
        }
    }
}
