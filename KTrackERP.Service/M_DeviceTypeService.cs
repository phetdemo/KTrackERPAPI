using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_DeviceTypeService : IM_DeviceTypeService
    {
        private readonly IM_DeviceTypeRepository m_DeviceTypeRepository;

        public M_DeviceTypeService(IM_DeviceTypeRepository deviceTypeRepository)
        {
            m_DeviceTypeRepository = deviceTypeRepository;
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
