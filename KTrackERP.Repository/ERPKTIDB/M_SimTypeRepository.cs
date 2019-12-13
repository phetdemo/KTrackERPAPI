using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_SimTypeRepository : IM_SimType
    {
        private readonly ERPKTIDBContext context;

        public M_SimTypeRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_SimType> Get()
        {
            throw new NotImplementedException();
        }

        public M_SimType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_SimType model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_SimType model)
        {
            throw new NotImplementedException();
        }
    }
}
