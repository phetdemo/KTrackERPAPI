using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IM_TimeSendDataService
    {
        IList<M_TimeSendData> Get();
        M_TimeSendData GetById(int id);
        bool Insert(M_TimeSendData model);
        bool Update(int id, M_TimeSendData model);
        bool Delete(int id);
    }
}
