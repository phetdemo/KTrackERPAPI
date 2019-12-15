using KTrackERP.Entity.KTrackERPDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTrackERP.Service.Interface
{
    public interface IJobRequestCloseService
    {
        IList<JobRequestClose> Get();
        JobRequestClose GetById(int id);
        bool Insert(JobRequestClose model);
        bool Update(int id, JobRequestClose model);
        bool Delete(int id);
    }
}
