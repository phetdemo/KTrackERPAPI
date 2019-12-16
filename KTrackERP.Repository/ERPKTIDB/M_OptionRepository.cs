using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_OptionRepository : IM_OptionRepository
    {
        private readonly ERPKTIDBContext context;

        public M_OptionRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_Option> Get()
        {
            throw new NotImplementedException();
        }

        public M_Option GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_Option model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_Option model)
        {
            throw new NotImplementedException();
        }
    }
}
