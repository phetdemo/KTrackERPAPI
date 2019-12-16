using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_LimitSpeedRepository : IM_LimitSpeedRepository
    {
        private readonly ERPKTIDBContext context;

        public M_LimitSpeedRepository(ERPKTIDBContext context)
        {
            this.context = context;
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
