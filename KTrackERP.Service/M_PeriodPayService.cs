using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_PeriodPayService : IM_PeriodPayService
    {
        private readonly IM_PeriodPayRepository m_PeriodPayRepository;

        public M_PeriodPayService(IM_PeriodPayRepository periodPayRepository)
        {
            m_PeriodPayRepository = periodPayRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_PeriodPay> Get()
        {
            throw new NotImplementedException();
        }

        public M_PeriodPay GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_PeriodPay model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_PeriodPay model)
        {
            throw new NotImplementedException();
        }
    }
}
