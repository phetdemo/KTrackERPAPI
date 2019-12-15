using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IM_JobStatusService
    {
        IList<M_JobStatus> Get();
        M_JobStatus GetById(int id);
        bool Insert(M_JobStatus model);
        bool Update(int id, M_JobStatus model);
        bool Delete(int id);
    }
}
