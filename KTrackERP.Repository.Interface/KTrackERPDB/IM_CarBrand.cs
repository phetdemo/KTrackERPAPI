using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IM_CarBrand
    {
        IList<M_CarBrand> Get();
        M_CarBrand GetById(int id);
        bool Insert(M_CarBrand model);
        bool Update(int id, M_CarBrand model);
        bool Delete(int id);
    }
}
