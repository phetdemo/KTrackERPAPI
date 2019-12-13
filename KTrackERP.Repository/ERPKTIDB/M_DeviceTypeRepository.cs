using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_DeviceTypeRepository : IM_DeviceType
    {
        private readonly ERPKTIDBContext context;

        public M_DeviceTypeRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_DeviceType> Get()
        {
            throw new NotImplementedException();
        }

        public M_DeviceType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_DeviceType model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_DeviceType model)
        {
            throw new NotImplementedException();
        }
    }
}
