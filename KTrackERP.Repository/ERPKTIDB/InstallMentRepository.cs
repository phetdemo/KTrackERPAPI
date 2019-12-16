using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class InstallMentRepository : IInstallMentRepository
    {
        private readonly ERPKTIDBContext context;

        public InstallMentRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<InstallMent> Get()
        {
            throw new NotImplementedException();
        }

        public InstallMent GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(InstallMent model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, InstallMent model)
        {
            throw new NotImplementedException();
        }
    }
}
