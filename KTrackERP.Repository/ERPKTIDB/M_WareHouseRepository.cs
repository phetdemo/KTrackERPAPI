using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_WareHouseRepository : IM_WareHouse
    {
        private readonly ERPKTIDBContext context;

        public M_WareHouseRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_WareHouse> Get()
        {
            throw new NotImplementedException();
        }

        public M_WareHouse GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_WareHouse model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_WareHouse model)
        {
            throw new NotImplementedException();
        }
    }
}
