using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class JobRequestRepository : IJobRequestRepository
    {
        private readonly ERPKTIDBContext context;

        public JobRequestRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<JobRequest> Get()
        {
            throw new NotImplementedException();
        }

        public JobRequest GetById(int id)
        {
            throw new NotImplementedException();
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
