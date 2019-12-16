using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_DeviceService : IM_DeviceService
    {
        private readonly IM_DeviceRepository m_DeviceRepository;

        public M_DeviceService(IM_DeviceRepository deviceRepository)
        {
            m_DeviceRepository = deviceRepository;
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
