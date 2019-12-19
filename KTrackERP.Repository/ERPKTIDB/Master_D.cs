using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class Master_D : IMaster_DRepository
    {
        private readonly ERPKTIDBContext context;

        public Master_D(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Entity.KTrackERPDB.Master_D> Get()
        {
            throw new NotImplementedException();
        }

        public Entity.KTrackERPDB.Master_D GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Entity.KTrackERPDB.Master_D model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Entity.KTrackERPDB.Master_D model)
        {
            throw new NotImplementedException();
        }
    }
}
