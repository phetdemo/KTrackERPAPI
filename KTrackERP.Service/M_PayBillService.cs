using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_PayBillService : IM_PayBillService
    {
        private readonly IM_PayBillRepository m_PayBillRepository;

        public M_PayBillService(IM_PayBillRepository payBillRepository)
        {
            m_PayBillRepository = payBillRepository;
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
