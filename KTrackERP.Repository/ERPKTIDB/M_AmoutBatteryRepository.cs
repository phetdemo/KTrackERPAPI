using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_AmoutBatteryRepository : IM_AmountBatteryRepository
    {
        private readonly ERPKTIDBContext context;

        public M_AmoutBatteryRepository(ERPKTIDBContext context)
        {
            this.context = context;
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
