using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_TimeSendDataService : IM_TimeSendDataService
    {
        private readonly IM_TimeSendDataRepository m_TimeSendDataRepository;
        public M_TimeSendDataService(IM_TimeSendDataRepository timeSendDataRepository)
        {
            m_TimeSendDataRepository = timeSendDataRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_TimeSendData> Get()
        {
            throw new NotImplementedException();
        }

        public M_TimeSendData GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_TimeSendData model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_TimeSendData model)
        {
            throw new NotImplementedException();
        }
    }
}
