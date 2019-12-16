using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_LimitSpeedService : IM_LimitSpeedService
    {
        private readonly IM_LimitSpeedRepository m_LimitSpeedRepository;

        public M_LimitSpeedService(IM_LimitSpeedRepository limitSpeedRepository)
        {
            m_LimitSpeedRepository = limitSpeedRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_LimitSpeed> Get()
        {
            throw new NotImplementedException();
        }

        public M_LimitSpeed GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_LimitSpeed model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_LimitSpeed model)
        {
            throw new NotImplementedException();
        }
    }
}
