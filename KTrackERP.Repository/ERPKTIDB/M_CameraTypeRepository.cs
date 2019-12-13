using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_CameraTypeRepository : IM_CameraType
    {
        private readonly ERPKTIDBContext context;

        public M_CameraTypeRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_CameraType> Get()
        {
            throw new NotImplementedException();
        }

        public M_CameraType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_CameraType model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_CameraType model)
        {
            throw new NotImplementedException();
        }
    }
}
