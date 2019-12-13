using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class JobRequestCloseRepository : IJobRequestClose
    {
        private readonly ERPKTIDBContext context;

        public JobRequestCloseRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<JobRequestClose> Get()
        {
            throw new NotImplementedException();
        }

        public JobRequestClose GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(JobRequestClose model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, JobRequestClose model)
        {
            throw new NotImplementedException();
        }
    }
}
