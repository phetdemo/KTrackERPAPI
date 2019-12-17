using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class ServiceChargeService : IServiceChargeService
    {
        private readonly IServiceChargeRepository serviceChargeRepository;

        public ServiceChargeService(IServiceChargeRepository serviceChargeRepository)
        {
            this.serviceChargeRepository = serviceChargeRepository;
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
