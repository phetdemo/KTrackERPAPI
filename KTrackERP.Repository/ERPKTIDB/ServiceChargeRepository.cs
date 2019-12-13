using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class ServiceChargeRepository : IServiceCharge
    {
        private readonly ERPKTIDBContext context;

        public ServiceChargeRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<ServiceCharge> Get()
        {
            throw new NotImplementedException();
        }

        public ServiceCharge GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ServiceCharge model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, ServiceCharge model)
        {
            throw new NotImplementedException();
        }
    }
}
