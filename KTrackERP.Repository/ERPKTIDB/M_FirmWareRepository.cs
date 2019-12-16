using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_FirmWareRepository : IM_FirmWareRepository
    {
        private readonly ERPKTIDBContext context;

        public M_FirmWareRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_FirmWare> Get()
        {
            throw new NotImplementedException();
        }

        public M_FirmWare GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_FirmWare model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_FirmWare model)
        {
            throw new NotImplementedException();
        }
    }
}
