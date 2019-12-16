using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_PositionRepository : IM_PositionRepository
    {
        private readonly ERPKTIDBContext context;

        public M_PositionRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_Position> Get()
        {
            throw new NotImplementedException();
        }

        public M_Position GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_Position model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_Position model)
        {
            throw new NotImplementedException();
        }
    }
}
