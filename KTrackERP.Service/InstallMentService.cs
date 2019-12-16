using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class InstallMentService : IInstallMentService
    {
        private readonly IInstallMentRepository installMentRepository;

        public InstallMentService(IInstallMentRepository installMentRepository)
        {
            this.installMentRepository = installMentRepository;
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
