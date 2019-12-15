using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IJobRequestService
    {
        IList<JobRequest> Get();
        JobRequest GetById(int id);
        bool Insert(JobRequest model);
        bool Update(int id, JobRequest model);
        bool Delete(int id);
    }
}
