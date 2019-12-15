﻿using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IM_ServiceChargeService
    {
        IList<M_ServiceCharge> Get();
        M_ServiceCharge GetById(int id);
        bool Insert(M_ServiceCharge model);
        bool Update(int id, M_ServiceCharge model);
        bool Delete(int id);
    }
}
