using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_FirmWareService : IM_FirmWareService
    {
        private readonly IM_FirmWareRepository m_FirmWareRepository;

        public M_FirmWareService(IM_FirmWareRepository firmWareRepository)
        {
            m_FirmWareRepository = firmWareRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_FirmWare> Get()
        {
            throw new NotImplementedException();
        }

        public M_FirmWare GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_FirmWare model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_FirmWare model)
        {
            throw new NotImplementedException();
        }
    }
}
