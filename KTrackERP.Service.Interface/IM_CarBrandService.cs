using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IM_CarBrandService
    {
        IList<M_CarBrand> Get();
        M_CarBrand GetById(int id);
        bool Insert(M_CarBrand model);
        bool Update(int id, M_CarBrand model);
        bool Delete(int id);
    }
}
