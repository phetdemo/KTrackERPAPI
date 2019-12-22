using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class Master_H : IMaster_HRepository
    {
        private readonly ERPKTIDBContext context;

        public Master_H(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Entity.KTrackERPDB.Master_H> Get()
        {
            return context.Master_H.ToList();
        }

        public Entity.KTrackERPDB.Master_H GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Entity.KTrackERPDB.Master_H model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Entity.KTrackERPDB.Master_H model)
        {
            throw new NotImplementedException();
        }
    }
}
