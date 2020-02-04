using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IJobRequestCloseService
    {
        IList<JobRequestClose> Get();
        object GetById(int id);
        bool Insert(JobRequestClose model);
        bool Update(int id, JobRequestClose model);
        bool Delete(int id);
    }
}
