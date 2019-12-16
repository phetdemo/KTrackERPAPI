using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_PayBillRepository : IM_PayBillRepository
    {
        private readonly ERPKTIDBContext context;

        public M_PayBillRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_PayBill> Get()
        {
            throw new NotImplementedException();
        }

        public M_PayBill GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_PayBill model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_PayBill model)
        {
            throw new NotImplementedException();
        }
    }
}
