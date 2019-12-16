using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_SoundAlertRepository : IM_SoundAlertRepository
    {
        private readonly ERPKTIDBContext context;

        public M_SoundAlertRepository(ERPKTIDBContext context)
        {
            this.context = context;
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
