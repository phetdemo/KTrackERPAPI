using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_AmountBatteryService : IM_AmountBatteryService
    {
        private readonly IM_AmountBatteryRepository m_AmountBatteryRepository;

        public M_AmountBatteryService(IM_AmountBatteryRepository amountBatteryRepository)
        {
            m_AmountBatteryRepository = amountBatteryRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_AmoutBattery> Get()
        {
            throw new NotImplementedException();
        }

        public M_AmoutBattery GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_AmoutBattery model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_AmoutBattery model)
        {
            throw new NotImplementedException();
        }
    }
}
