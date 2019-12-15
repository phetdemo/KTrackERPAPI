using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IInstallMentService
    {
        IList<InstallMent> Get();
        InstallMent GetById(int id);
        bool Insert(InstallMent model);
        bool Update(int id, InstallMent model);
        bool Delete(int id);
    }
}
