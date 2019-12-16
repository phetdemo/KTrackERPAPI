using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_PayMonthSpecialRepository : IM_PayMonthSpacialRepository
    {
        private readonly ERPKTIDBContext context;

        public M_PayMonthSpecialRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_PayMonthSpacial> Get()
        {
            throw new NotImplementedException();
        }

        public M_PayMonthSpacial GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_PayMonthSpacial model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_PayMonthSpacial model)
        {
            throw new NotImplementedException();
        }
    }
}
