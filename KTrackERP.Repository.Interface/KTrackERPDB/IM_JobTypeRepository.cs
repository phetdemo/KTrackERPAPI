using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IM_JobTypeRepository
    {
        IList<M_JobType> Get();
        M_JobType GetById(int id);
        bool Insert(M_JobType model);
        bool Update(int id, M_JobType model);
        bool Delete(int id);
    }
}
