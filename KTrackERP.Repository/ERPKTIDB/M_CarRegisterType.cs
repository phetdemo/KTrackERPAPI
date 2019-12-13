using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_CarRegisterType : IM_CarRegisterType
    {
        private readonly ERPKTIDBContext context;

        public M_CarRegisterType(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Entity.KTrackERPDB.M_CarRegisterType> Get()
        {
            throw new NotImplementedException();
        }

        public Entity.KTrackERPDB.M_CarRegisterType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Entity.KTrackERPDB.M_CarRegisterType model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Entity.KTrackERPDB.M_CarRegisterType model)
        {
            throw new NotImplementedException();
        }
    }
}
