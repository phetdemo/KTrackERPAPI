using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IFileService
    {
        IList<File> Get();
        File GetById(int id);
        bool Insert(File model);
        bool Update(int id, File model);
        bool Delete(int id);
    }
}
