using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_SoundAlertService : IM_SoundAlertService
    {
        private readonly IM_SoundAlertRepository m_SoundAlertRepository;

        public M_SoundAlertService(IM_SoundAlertRepository soundAlertRepository)
        {
            m_SoundAlertRepository = soundAlertRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_SoundAlert> Get()
        {
            throw new NotImplementedException();
        }

        public M_SoundAlert GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_SoundAlert model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_SoundAlert model)
        {
            throw new NotImplementedException();
        }
    }
}
