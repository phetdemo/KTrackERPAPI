using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_CarBrandRepository : IM_CarBrand
    {
        private readonly ERPKTIDBContext context;

        public M_CarBrandRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_CarBrand> Get()
        {
            throw new NotImplementedException();
        }

        public M_CarBrand GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_CarBrand model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_CarBrand model)
        {
            throw new NotImplementedException();
        }
    }
}
