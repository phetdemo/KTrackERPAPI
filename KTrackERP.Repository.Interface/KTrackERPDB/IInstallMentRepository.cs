using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IInstallMentRepository
    {
        IList<InstallMent> Get();
        InstallMent GetById(int id);
        bool Insert(InstallMent model);
        bool Update(int id, InstallMent model);
        bool Delete(int id);
    }
}
