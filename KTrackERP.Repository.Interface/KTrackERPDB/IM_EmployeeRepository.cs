using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IM_EmployeeRepository
    {
        IList<M_Employee> Get();
        M_Employee GetById(int id);
        bool Insert(M_Employee model);
        bool Update(int id, M_Employee model);
        bool Delete(int id);
    }
}
