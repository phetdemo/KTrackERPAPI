using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_ServiceChargeService : IM_ServiceChargeService
    {
        private readonly IM_ServiceChargeRepository m_ServiceChargeRepository;

        public M_ServiceChargeService(IM_ServiceChargeRepository serviceChargeRepository)
        {
            m_ServiceChargeRepository = serviceChargeRepository;
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
