using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_AccessoriesRepository : IM_Accessories
    {
        private readonly ERPKTIDBContext context;

        public M_AccessoriesRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_Accessories> Get()
        {
            throw new NotImplementedException();
        }

        public M_Accessories GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_Accessories model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_Accessories model)
        {
            throw new NotImplementedException();
        }
    }
}
