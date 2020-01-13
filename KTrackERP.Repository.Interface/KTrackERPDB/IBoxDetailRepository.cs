using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IBoxDetailRepository
    {
        IList<BoxDetail> Get();
        object GetById(int id);
        bool Insert(BoxDetail model);
        bool Update(int id, BoxDetail model);
        bool Delete(int id);
    }
}
