using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_PeriodPayRepository : IM_PeriodPay
    {
        private readonly ERPKTIDBContext context;

        public M_PeriodPayRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_PeriodPay> Get()
        {
            throw new NotImplementedException();
        }

        public M_PeriodPay GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_PeriodPay model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_PeriodPay model)
        {
            throw new NotImplementedException();
        }
    }
}
