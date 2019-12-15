using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IM_CarRegisterTypeService
    {
        IList<M_CarRegisterType> Get();
        M_CarRegisterType GetById(int id);
        bool Insert(M_CarRegisterType model);
        bool Update(int id, M_CarRegisterType model);
        bool Delete(int id);
    }
}
