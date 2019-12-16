using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_JobStatusService : IM_JobStatusService
    {
        private readonly IM_JobStatusRepository m_JobStatusRepository;

        public M_JobStatusService(IM_JobStatusRepository jobStatusRepository)
        {
            m_JobStatusRepository = jobStatusRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_JobStatus> Get()
        {
            throw new NotImplementedException();
        }

        public M_JobStatus GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_JobStatus model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_JobStatus model)
        {
            throw new NotImplementedException();
        }
    }
}
