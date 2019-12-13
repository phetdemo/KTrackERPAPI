using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_LicenceDriveTypeRepository : IM_LicenceDriveType
    {
        private readonly ERPKTIDBContext context;

        public M_LicenceDriveTypeRepository(ERPKTIDBContext context)
        {
            this.context = context;
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
