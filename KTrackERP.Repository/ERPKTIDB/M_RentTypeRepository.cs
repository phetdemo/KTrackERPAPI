using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_RentTypeRepository : IM_RentTypeRepository
    {
        private readonly ERPKTIDBContext context;

        public M_RentTypeRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_RentType> Get()
        {
            throw new NotImplementedException();
        }

        public M_RentType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_RentType model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_RentType model)
        {
            throw new NotImplementedException();
        }
    }
}
