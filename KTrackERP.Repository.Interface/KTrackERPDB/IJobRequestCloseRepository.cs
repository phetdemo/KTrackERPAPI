using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IJobRequestCloseRepository
    {
        IList<JobRequestClose> Get();
        object GetById(int id);
        bool Insert(JobRequestClose model);
        object GenerateJobCode();
        bool Update(int id, JobRequestClose model);
        bool Delete(int id);
    }
}
