using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IM_AmountBatteryRepository
    {
        IList<M_AmoutBattery> Get();
        M_AmoutBattery GetById(int id);
        bool Insert(M_AmoutBattery model);
        bool Update(int id, M_AmoutBattery model);
        bool Delete(int id);
    }
}
