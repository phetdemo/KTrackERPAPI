using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IJobRequestRepository
    {
        IList<JobRequest> Get();
        object GetById(int id);
        bool Insert(JobRequest model);
        bool Update(int id, JobRequest model);
        bool Delete(int id);
        object GetJobWorkList(int jobstatusID);
        object GenerateJobCode(string jobtype);
        object GetHistoryJob(int jobstatus);
    }
}
