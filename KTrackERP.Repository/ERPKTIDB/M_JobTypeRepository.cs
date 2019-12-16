using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_JobTypeRepository : IM_JobTypeRepository
    {
        private readonly ERPKTIDBContext context;

        public M_JobTypeRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_JobType> Get()
        {
            throw new NotImplementedException();
        }

        public M_JobType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_JobType model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_JobType model)
        {
            throw new NotImplementedException();
        }
    }
}
