using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_UnitRepository : IM_UnitRepository
    {
        private readonly ERPKTIDBContext context;

        public M_UnitRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_Unit> Get()
        {
            return context.M_Unit.ToList();
        }

        public M_Unit GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_Unit model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_Unit model)
        {
            throw new NotImplementedException();
        }
    }
}
