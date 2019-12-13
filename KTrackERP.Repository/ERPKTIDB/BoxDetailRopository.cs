using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class BoxDetailRopository : IBoxDetailRepository
    {
        private readonly ERPKTIDBContext context;

        public BoxDetailRopository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<BoxDetail> Get()
        {
            throw new NotImplementedException();
        }

        public BoxDetail GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(BoxDetail model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, BoxDetail model)
        {
            throw new NotImplementedException();
        }
    }
}
