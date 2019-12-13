using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_JobStatusRepository : IM_JobStatus
    {
        private readonly ERPKTIDBContext context;

        public M_JobStatusRepository(ERPKTIDBContext context)
        {
            this.context = context;
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
