using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IM_JobStatus
    {
        IList<M_JobStatus> Get();
        M_JobStatus GetById(int id);
        bool Insert(M_JobStatus model);
        bool Update(int id, M_JobStatus model);
        bool Delete(int id);
    }
}
