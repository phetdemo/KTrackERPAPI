﻿using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_DeviceRepository : IM_DeviceRepository
    {
        private readonly ERPKTIDBContext context;

        public M_DeviceRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_Device> Get()
        {
            throw new NotImplementedException();
        }

        public M_Device GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_Device model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_Device model)
        {
            throw new NotImplementedException();
        }
    }
}
