using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IFileRepository
    {
        IList<File> Get();
        File GetById(int id);
        bool Insert(File model);
        bool Update(int id, File model);
        bool Delete(int id);
    }
}
