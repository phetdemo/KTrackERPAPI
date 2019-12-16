using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_PayMonthSpacialService : IM_PayMonthSpacialService
    {
        private readonly IM_PayMonthSpacialRepository m_PayMonthSpacialRepository;

        public M_PayMonthSpacialService(IM_PayMonthSpacialRepository payMonthSpacialRepository)
        {
            m_PayMonthSpacialRepository = payMonthSpacialRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_PayMonthSpacial> Get()
        {
            throw new NotImplementedException();
        }

        public M_PayMonthSpacial GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_PayMonthSpacial model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_PayMonthSpacial model)
        {
            throw new NotImplementedException();
        }
    }
}
