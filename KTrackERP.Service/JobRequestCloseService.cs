using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    
    public class JobRequestCloseService : IJobRequestCloseService
    {
        private readonly IJobRequestCloseRepository jobRequestCloseRepository;

        public JobRequestCloseService(IJobRequestCloseRepository jobRequestCloseRepository)
        {
            this.jobRequestCloseRepository = jobRequestCloseRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<JobRequestClose> Get()
        {
            throw new NotImplementedException();
        }

        public object GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(JobRequestClose model)
        {
            return jobRequestCloseRepository.Insert(model);
        }
        public object GenerateJobCode()
        {
            return jobRequestCloseRepository.GenerateJobCode();
        }

        public bool Update(int id, JobRequestClose model)
        {
            throw new NotImplementedException();
        }
        public object GetCarAndBoxByJobReqByID(int id)
        {
            return jobRequestCloseRepository.GetCarAndBoxByJobReqByID(id);
        }
        public object GetJobRequestInformationByJobReqID(int id)
        {
            return jobRequestCloseRepository.GetJobRequestInformationByJobReqID(id);
        }
    }
}
