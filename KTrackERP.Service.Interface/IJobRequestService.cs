﻿using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IJobRequestService
    {
        IList<JobRequest> Get();
        object GetById(int id);
        bool Insert(JobRequest model);
        bool Update(int id, JobRequest model);
        bool Delete(int id);
        object GetJobWorkList(int jobstatusID);
        object GenerateJobCode(string jobtype);
        object GetHistoryJob(int jobtype, int jobstatus);
        object GetWorkListAll();
        object GetJobRef();
    }
}
