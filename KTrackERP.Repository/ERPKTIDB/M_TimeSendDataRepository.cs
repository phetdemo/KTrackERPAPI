using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_TimeSendDataRepository : IM_TimeSendData
    {
        private readonly ERPKTIDBContext context;

        public M_TimeSendDataRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_TimeSendData> Get()
        {
            throw new NotImplementedException();
        }

        public M_TimeSendData GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_TimeSendData model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_TimeSendData model)
        {
            throw new NotImplementedException();
        }
    }
}
