using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class JobRequestService : IJobRequestService
    {
        private readonly IJobRequestRepository jobRequestRepository;

        public JobRequestService(IJobRequestRepository jobRequestRepository)
        {
            this.jobRequestRepository = jobRequestRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<JobRequest> Get()
        {
            throw new NotImplementedException();
        }

        public object GetById(int id)
        {
            return jobRequestRepository.GetById(id);
        }

        public bool Insert(JobRequest model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, JobRequest model)
        {
            throw new NotImplementedException();
        }
    }
}
