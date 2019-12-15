using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IM_OptionService
    {
        IList<M_Option> Get();
        M_Option GetById(int id);
        bool Insert(M_Option model);
        bool Update(int id, M_Option model);
        bool Delete(int id);
    }
}
