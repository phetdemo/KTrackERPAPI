using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IM_WareHouseRepository
    {
        IList<M_WareHouse> Get();
        M_WareHouse GetById(int id);
        bool Insert(M_WareHouse model);
        bool Update(int id, M_WareHouse model);
        bool Delete(int id);
    }
}
