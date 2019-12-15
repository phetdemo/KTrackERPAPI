using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IServiceChargeService
    {
        IList<ServiceCharge> Get();
        ServiceCharge GetById(int id);
        bool Insert(ServiceCharge model);
        bool Update(int id, ServiceCharge model);
        bool Delete(int id);
    }
}
