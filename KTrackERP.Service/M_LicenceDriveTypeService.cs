using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_LicenceDriveTypeService : IM_LicenceDriveTypeService
    {
        private readonly IM_LicenceDriveTypeRepository m_LicenceDriveTypeRepository;

        public M_LicenceDriveTypeService(IM_LicenceDriveTypeRepository licenceDriveTypeRepository)
        {
            m_LicenceDriveTypeRepository = licenceDriveTypeRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_LicenceDriveType> Get()
        {
            throw new NotImplementedException();
        }

        public M_LicenceDriveType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_LicenceDriveType model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_LicenceDriveType model)
        {
            throw new NotImplementedException();
        }
    }
}
